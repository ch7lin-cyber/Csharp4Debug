using System.Diagnostics;
using System.IO.Ports;
using System.Text;

namespace ModbusReadWrite;

internal static class Modbus
{
    internal static ushort Crc(byte[] bytes)
    {
        ushort crc = 0xFFFF;
        foreach (byte b in bytes) { crc ^= b; for (int i = 0; i < 8; i++) crc = (ushort)((crc & 1) != 0 ? (crc >> 1) ^ 0xA001 : crc >> 1); }
        return crc;
    }
    internal static byte Lrc(byte[] bytes) => unchecked((byte)-bytes.Sum(b => (int)b));
    internal static byte[] Exchange(SerialPort port, byte[] request, bool ascii)
    {
        // At least 3.5 character times between transactions (fixed 1.75 ms above 19200).
        Thread.Sleep(port.BaudRate > 19200 ? 2 : (int)Math.Ceiling(3500.0 * (1 + port.DataBits + (port.Parity == Parity.None ? 0 : 1) + (port.StopBits == StopBits.Two ? 2 : 1)) / port.BaudRate));
        port.DiscardInBuffer();
        byte[] wire;
        if (ascii) wire = Encoding.ASCII.GetBytes(":" + Convert.ToHexString(request) + Lrc(request).ToString("X2") + "\r\n");
        else { ushort crc = Crc(request); wire = request.Concat(new[] { (byte)crc, (byte)(crc >> 8) }).ToArray(); }
        port.Write(wire, 0, wire.Length);
        var timer = Stopwatch.StartNew();
        int Read()
        {
            int remaining = 1000 - (int)timer.ElapsedMilliseconds;
            if (remaining <= 0) throw new TimeoutException("Modbus 回覆逾時。");
            port.ReadTimeout = remaining;
            return port.ReadByte();
        }
        byte[] payload;
        if (ascii)
        {
            if (Read() != ':') throw new InvalidDataException("ASCII 回覆缺少冒號。");
            var text = new StringBuilder();
            while (true) { int b = Read(); if (b == '\r') { if (Read() != '\n') throw new InvalidDataException("ASCII 結尾錯誤。"); break; } if (text.Length >= 512) throw new InvalidDataException("ASCII 回覆過長。"); text.Append((char)b); }
            byte[] frame = Convert.FromHexString(text.ToString());
            if (frame.Length < 4 || (frame.Sum(b => (int)b) & 255) != 0) throw new InvalidDataException("LRC 錯誤。");
            payload = frame[..^1];
        }
        else
        {
            var frame = new List<byte> { (byte)Read(), (byte)Read(), (byte)Read() };
            int length = (frame[1] & 0x80) != 0 ? 5 : frame[1] == 3 ? 5 + frame[2] : frame[1] == 6 ? 8 : throw new InvalidDataException("未知功能碼。");
            if (length > 256) throw new InvalidDataException("RTU 回覆過長。");
            while (frame.Count < length) frame.Add((byte)Read());
            byte[] bytes = frame.ToArray(); payload = bytes[..^2];
            if (Crc(payload) != (bytes[^2] | bytes[^1] << 8)) throw new InvalidDataException("CRC 錯誤。");
        }
        if (payload[0] != request[0]) throw new InvalidDataException("回覆站號不符。");
        if (payload[1] == (request[1] | 0x80) && payload.Length == 3) throw new InvalidDataException($"Modbus 異常碼 0x{payload[2]:X2}");
        if (payload[1] != request[1]) throw new InvalidDataException("回覆功能碼不符。");
        if (request[1] == 3 && (payload.Length != 5 || payload[2] != 2)) throw new InvalidDataException("03 回覆長度錯誤。");
        if (request[1] == 6 && !payload.SequenceEqual(request)) throw new InvalidDataException("06 回覆與寫入內容不符。");
        return payload;
    }
}
