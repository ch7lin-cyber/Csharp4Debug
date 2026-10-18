using System.Globalization;
using System.IO.Ports;

namespace ModbusReadWrite
{
    public partial class main : Form
    {
        private readonly System.Windows.Forms.Timer portTimer = new() { Interval = 1000 };
        private SerialPort? port;
        private bool busy;
        private readonly List<Button> commands = new();

        public main()
        {
            InitializeComponent();
            Setup(baudrate_comb, new[] { "4800", "9600", "19200", "38400", "57600", "115200", "230400" }, "115200");
            Setup(format_comb, (from bits in new[] { 7, 8 } from parity in new[] { "N", "E", "O" } from stop in new[] { 1, 2 } select $"{bits}/{parity}/{stop}").ToArray(), "8/N/1");
            Setup(rtuAscii_comb, new[] { "RTU", "ASCII" }, "RTU");
            comPort_comb.DropDownStyle = ComboBoxStyle.DropDownList;
            link_btn.Text = "連線";
            link_btn.Click += (_, _) => { if (port != null) Disconnect(); else Connect(); };
            // Bind Designer fields directly; name-based Controls lookups can return null.
            var rows = new (TextBox Address, TextBox Value, Button Read, Button Write, CheckBox Hex)[]
            {
                (address1_hex, addressW1_txt, readAddress1_btn, writeAddress1_btn, hex1_check),
                (address2_hex, addressW2_txt, readAddress2_btn, writeAddress2_btn, hex2_check),
                (address3_hex, addressW3_txt, readAddress3_btn, writeAddress3_btn, hex3_check),
                (address4_hex, addressW4_txt, readAddress4_btn, writeAddress4_btn, hex4_check),
                (address5_hex, addressW5_txt, readAddress5_btn, writeAddress5_btn, hex5_check),
                (address6_hex, addressW6_txt, readAddress6_btn, writeAddress6_btn, hex6_check),
                (address7_hex, addressW7_txt, readAddress7_btn, writeAddress7_btn, hex7_check),
                (address8_hex, addressW8_txt, readAddress8_btn, writeAddress8_btn, hex8_check),
                (address9_hex, addressW9_txt, readAddress9_btn, writeAddress9_btn, hex9_check),
                (address10_hex, addressW10_txt, readAddress10_btn, writeAddress10_btn, hex10_check),
                (address11_hex, addressW11_txt, readAddress11_btn, writeAddress11_btn, hex11_check),
                (address12_hex, addressW12_txt, readAddress12_btn, writeAddress12_btn, hex12_check),
                (address13_hex, addressW13_txt, readAddress13_btn, writeAddress13_btn, hex13_check),
            };
            foreach (var (address, value, read, write, hex) in rows)
            {
                commands.AddRange(new[] { read, write });
                bool previousHex = true;
                hex.CheckedChanged += (_, _) =>
                {
                    try
                    {
                        ushort a = Parse(address.Text, previousHex), v = Parse(value.Text, previousHex);
                        address.Text = Format(a, hex.Checked); value.Text = Format(v, hex.Checked);
                        previousHex = hex.Checked; hex.Text = hex.Checked ? "HEX" : "DEC";
                    }
                    catch (Exception ex) { hex.Checked = previousHex; Report(ex.Message); }
                };
                read.Click += async (_, _) => await Execute(address, value, hex, false);
                write.Click += async (_, _) => await Execute(address, value, hex, true);
            }
            portTimer.Tick += (_, _) => RefreshPorts();
            Shown += (_, _) => { RefreshPorts(); portTimer.Start(); };
            FormClosing += (_, _) => { portTimer.Stop(); Disconnect(); portTimer.Dispose(); };
            SetCommands(false);
        }

        private static void Setup(ComboBox box, string[] items, string selected)
        { box.Items.Clear(); box.Items.AddRange(items); box.DropDownStyle = ComboBoxStyle.DropDownList; box.SelectedItem = selected; }
        private void RefreshPorts()
        {
            try
            {
                var names = SerialPort.GetPortNames().OrderBy(n => int.TryParse(n.AsSpan(3), out int v) ? v : int.MaxValue).ToArray();
                if (port != null && !names.Contains(port.PortName)) { Disconnect(); Report("COM Port 已移除。"); }
                string? selected = comPort_comb.SelectedItem as string;
                if (!names.SequenceEqual(comPort_comb.Items.Cast<string>()))
                {
                    comPort_comb.Items.Clear(); comPort_comb.Items.AddRange(names);
                    if (selected != null && names.Contains(selected)) comPort_comb.SelectedItem = selected;
                    else if (names.Length > 0) comPort_comb.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { Report(ex.Message); }
        }
        private void Connect()
        {
            SerialPort? candidate = null;
            try
            {
                if (comPort_comb.SelectedItem is not string name) throw new InvalidOperationException("請選擇 COM Port。");
                string[] f = format_comb.Text.Split('/');
                if (rtuAscii_comb.Text == "RTU" && f[0] != "8") throw new InvalidOperationException("RTU 必須使用 8 data bits。");
                candidate = new SerialPort(name, int.Parse(baudrate_comb.Text), f[1] == "E" ? Parity.Even : f[1] == "O" ? Parity.Odd : Parity.None, int.Parse(f[0]), f[2] == "2" ? StopBits.Two : StopBits.One)
                { ReadTimeout = 1000, WriteTimeout = 1000, Handshake = Handshake.None };
                candidate.Open(); port = candidate; link_btn.Text = "斷線"; SetSettings(false); SetCommands(true); Report($"已連線 {name}");
            }
            catch (Exception ex) { candidate?.Dispose(); Report(ex.Message); }
        }
        private void Disconnect()
        { var old = port; port = null; old?.Dispose(); link_btn.Text = "連線"; SetSettings(true); SetCommands(false); }
        private void SetSettings(bool enabled)
        { foreach (Control c in new Control[] { comPort_comb, baudrate_comb, format_comb, rtuAscii_comb, numericUpDown1 }) c.Enabled = enabled; }
        private void SetCommands(bool enabled) { foreach (var b in commands) b.Enabled = enabled; }
        private void Report(string message) { if (!IsDisposed) rxtx_msg_txt.AppendText($"{DateTime.Now:HH:mm:ss} {message}{Environment.NewLine}"); }
        private static ushort Parse(string text, bool hex)
        {
            text = text.Trim();
            if (hex) { if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase)) text = text[2..]; if (text.EndsWith("h", StringComparison.OrdinalIgnoreCase)) text = text[..^1]; }
            if (!ushort.TryParse(text, hex ? NumberStyles.AllowHexSpecifier : NumberStyles.None, CultureInfo.InvariantCulture, out ushort value))
                throw new FormatException(hex ? "請輸入 0000～FFFF 的 HEX 數值。" : "請輸入 0～65535 的 DEC 數值。");
            return value;
        }
        private static string Format(ushort value, bool hex) => hex ? $"0x{value:X4}" : value.ToString(CultureInfo.InvariantCulture);
        private async Task Execute(TextBox address, TextBox value, CheckBox hex, bool write)
        {
            if (busy || port == null) return;
            SerialPort current = port;
            try
            {
                ushort a = Parse(address.Text, hex.Checked), v = write ? Parse(value.Text, hex.Checked) : (ushort)1;
                byte[] request = { (byte)numericUpDown1.Value, (byte)(write ? 6 : 3), (byte)(a >> 8), (byte)a, (byte)(v >> 8), (byte)v };
                bool ascii = rtuAscii_comb.Text == "ASCII";
                busy = true; SetCommands(false);
                Report("TX " + Convert.ToHexString(request));
                byte[] response = await Task.Run(() => Modbus.Exchange(current, request, ascii));
                if (IsDisposed || port != current) return;
                Report("RX " + Convert.ToHexString(response));
                if (write) Report("寫入成功"); else value.Text = Format((ushort)((response[3] << 8) | response[4]), hex.Checked);
            }
            catch (Exception ex) { if (!IsDisposed) { Report(ex.Message); if (ex is IOException || ex is UnauthorizedAccessException || ex is ObjectDisposedException) Disconnect(); } }
            finally { busy = false; if (!IsDisposed) SetCommands(port != null); }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
