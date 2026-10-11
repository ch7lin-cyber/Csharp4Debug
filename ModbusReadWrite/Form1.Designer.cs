namespace ModbusReadWrite
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            link_btn = new Button();
            comPort_comb = new ComboBox();
            comPort_lbl = new Label();
            address1_lbl = new Label();
            this.address1_hex = new TextBox();
            this.readAddress1_btn = new Button();
            textBox1 = new TextBox();
            writeAddress1_btn = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label3 = new Label();
            button5 = new Button();
            button6 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label4 = new Label();
            button7 = new Button();
            button8 = new Button();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label5 = new Label();
            button9 = new Button();
            button10 = new Button();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            label6 = new Label();
            button11 = new Button();
            button12 = new Button();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            label7 = new Label();
            button13 = new Button();
            button14 = new Button();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            label8 = new Label();
            button15 = new Button();
            button16 = new Button();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            label9 = new Label();
            button17 = new Button();
            button18 = new Button();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            label10 = new Label();
            button19 = new Button();
            button20 = new Button();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            label11 = new Label();
            button21 = new Button();
            button22 = new Button();
            textBox24 = new TextBox();
            textBox25 = new TextBox();
            label12 = new Label();
            button23 = new Button();
            button24 = new Button();
            baudrate_comb = new ComboBox();
            baudRate_txt = new Label();
            format_comb = new ComboBox();
            rtuAscii_comb = new ComboBox();
            SuspendLayout();
            // 
            // link_btn
            // 
            link_btn.Location = new Point(220, 1);
            link_btn.Name = "link_btn";
            link_btn.Size = new Size(102, 36);
            link_btn.TabIndex = 0;
            link_btn.Text = "連線/斷線";
            link_btn.UseVisualStyleBackColor = true;
            // 
            // comPort_comb
            // 
            comPort_comb.FormattingEnabled = true;
            comPort_comb.Location = new Point(74, 12);
            comPort_comb.Name = "comPort_comb";
            comPort_comb.Size = new Size(140, 25);
            comPort_comb.TabIndex = 1;
            // 
            // comPort_lbl
            // 
            comPort_lbl.AutoSize = true;
            comPort_lbl.Location = new Point(5, 16);
            comPort_lbl.Name = "comPort_lbl";
            comPort_lbl.Size = new Size(63, 17);
            comPort_lbl.TabIndex = 2;
            comPort_lbl.Text = "ComPort";
            // 
            // address1_lbl
            // 
            address1_lbl.AutoSize = true;
            address1_lbl.Location = new Point(12, 53);
            address1_lbl.Name = "address1_lbl";
            address1_lbl.Size = new Size(55, 17);
            address1_lbl.TabIndex = 3;
            address1_lbl.Text = "address";
            // 
            // address1_hex
            // 
            this.address1_hex.Location = new Point(74, 50);
            this.address1_hex.Name = "address1_hex";
            this.address1_hex.Size = new Size(90, 24);
            this.address1_hex.TabIndex = 4;
            this.address1_hex.Text = "1010h";
            // 
            // readAddress1_btn
            // 
            this.readAddress1_btn.Location = new Point(170, 49);
            this.readAddress1_btn.Name = "readAddress1_btn";
            this.readAddress1_btn.Size = new Size(44, 24);
            this.readAddress1_btn.TabIndex = 0;
            this.readAddress1_btn.Text = "R";
            this.readAddress1_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 24);
            textBox1.TabIndex = 4;
            textBox1.Text = "0x1234";
            // 
            // writeAddress1_btn
            // 
            writeAddress1_btn.Location = new Point(316, 50);
            writeAddress1_btn.Name = "writeAddress1_btn";
            writeAddress1_btn.Size = new Size(44, 24);
            writeAddress1_btn.TabIndex = 0;
            writeAddress1_btn.Text = "W";
            writeAddress1_btn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 24);
            textBox2.TabIndex = 8;
            textBox2.Text = "0x1234";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(74, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 24);
            textBox3.TabIndex = 9;
            textBox3.Text = "1010h";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 7;
            label1.Text = "address";
            // 
            // button1
            // 
            button1.Location = new Point(316, 80);
            button1.Name = "button1";
            button1.Size = new Size(44, 24);
            button1.TabIndex = 5;
            button1.Text = "W";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(170, 79);
            button2.Name = "button2";
            button2.Size = new Size(44, 24);
            button2.TabIndex = 6;
            button2.Text = "R";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(220, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(90, 24);
            textBox4.TabIndex = 13;
            textBox4.Text = "0x1234";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(74, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(90, 24);
            textBox5.TabIndex = 14;
            textBox5.Text = "1010h";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 12;
            label2.Text = "address";
            // 
            // button3
            // 
            button3.Location = new Point(316, 110);
            button3.Name = "button3";
            button3.Size = new Size(44, 24);
            button3.TabIndex = 10;
            button3.Text = "W";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(170, 109);
            button4.Name = "button4";
            button4.Size = new Size(44, 24);
            button4.TabIndex = 11;
            button4.Text = "R";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(220, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(90, 24);
            textBox6.TabIndex = 18;
            textBox6.Text = "0x1234";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(74, 140);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(90, 24);
            textBox7.TabIndex = 19;
            textBox7.Text = "1010h";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 17;
            label3.Text = "address";
            // 
            // button5
            // 
            button5.Location = new Point(316, 140);
            button5.Name = "button5";
            button5.Size = new Size(44, 24);
            button5.TabIndex = 15;
            button5.Text = "W";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(170, 139);
            button6.Name = "button6";
            button6.Size = new Size(44, 24);
            button6.TabIndex = 16;
            button6.Text = "R";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(220, 170);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(90, 24);
            textBox8.TabIndex = 23;
            textBox8.Text = "0x1234";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(74, 170);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(90, 24);
            textBox9.TabIndex = 24;
            textBox9.Text = "1010h";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 22;
            label4.Text = "address";
            // 
            // button7
            // 
            button7.Location = new Point(316, 170);
            button7.Name = "button7";
            button7.Size = new Size(44, 24);
            button7.TabIndex = 20;
            button7.Text = "W";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(170, 169);
            button8.Name = "button8";
            button8.Size = new Size(44, 24);
            button8.TabIndex = 21;
            button8.Text = "R";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(220, 200);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(90, 24);
            textBox10.TabIndex = 28;
            textBox10.Text = "0x1234";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(74, 200);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(90, 24);
            textBox11.TabIndex = 29;
            textBox11.Text = "1010h";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 203);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 27;
            label5.Text = "address";
            // 
            // button9
            // 
            button9.Location = new Point(316, 200);
            button9.Name = "button9";
            button9.Size = new Size(44, 24);
            button9.TabIndex = 25;
            button9.Text = "W";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(170, 199);
            button10.Name = "button10";
            button10.Size = new Size(44, 24);
            button10.TabIndex = 26;
            button10.Text = "R";
            button10.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(220, 230);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(90, 24);
            textBox12.TabIndex = 33;
            textBox12.Text = "0x1234";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(74, 230);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(90, 24);
            textBox13.TabIndex = 34;
            textBox13.Text = "1010h";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 233);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 32;
            label6.Text = "address";
            // 
            // button11
            // 
            button11.Location = new Point(316, 230);
            button11.Name = "button11";
            button11.Size = new Size(44, 24);
            button11.TabIndex = 30;
            button11.Text = "W";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(170, 229);
            button12.Name = "button12";
            button12.Size = new Size(44, 24);
            button12.TabIndex = 31;
            button12.Text = "R";
            button12.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(220, 260);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(90, 24);
            textBox14.TabIndex = 38;
            textBox14.Text = "0x1234";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(74, 260);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(90, 24);
            textBox15.TabIndex = 39;
            textBox15.Text = "1010h";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 263);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 37;
            label7.Text = "address";
            // 
            // button13
            // 
            button13.Location = new Point(316, 260);
            button13.Name = "button13";
            button13.Size = new Size(44, 24);
            button13.TabIndex = 35;
            button13.Text = "W";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(170, 259);
            button14.Name = "button14";
            button14.Size = new Size(44, 24);
            button14.TabIndex = 36;
            button14.Text = "R";
            button14.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(220, 290);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(90, 24);
            textBox16.TabIndex = 43;
            textBox16.Text = "0x1234";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(74, 290);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(90, 24);
            textBox17.TabIndex = 44;
            textBox17.Text = "1010h";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 293);
            label8.Name = "label8";
            label8.Size = new Size(55, 17);
            label8.TabIndex = 42;
            label8.Text = "address";
            // 
            // button15
            // 
            button15.Location = new Point(316, 290);
            button15.Name = "button15";
            button15.Size = new Size(44, 24);
            button15.TabIndex = 40;
            button15.Text = "W";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(170, 289);
            button16.Name = "button16";
            button16.Size = new Size(44, 24);
            button16.TabIndex = 41;
            button16.Text = "R";
            button16.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(220, 320);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(90, 24);
            textBox18.TabIndex = 48;
            textBox18.Text = "0x1234";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(74, 320);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(90, 24);
            textBox19.TabIndex = 49;
            textBox19.Text = "1010h";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 323);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 47;
            label9.Text = "address";
            // 
            // button17
            // 
            button17.Location = new Point(316, 320);
            button17.Name = "button17";
            button17.Size = new Size(44, 24);
            button17.TabIndex = 45;
            button17.Text = "W";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(170, 319);
            button18.Name = "button18";
            button18.Size = new Size(44, 24);
            button18.TabIndex = 46;
            button18.Text = "R";
            button18.UseVisualStyleBackColor = true;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(220, 350);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(90, 24);
            textBox20.TabIndex = 53;
            textBox20.Text = "0x1234";
            // 
            // textBox21
            // 
            textBox21.Location = new Point(74, 350);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(90, 24);
            textBox21.TabIndex = 54;
            textBox21.Text = "1010h";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 353);
            label10.Name = "label10";
            label10.Size = new Size(55, 17);
            label10.TabIndex = 52;
            label10.Text = "address";
            // 
            // button19
            // 
            button19.Location = new Point(316, 350);
            button19.Name = "button19";
            button19.Size = new Size(44, 24);
            button19.TabIndex = 50;
            button19.Text = "W";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(170, 349);
            button20.Name = "button20";
            button20.Size = new Size(44, 24);
            button20.TabIndex = 51;
            button20.Text = "R";
            button20.UseVisualStyleBackColor = true;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(220, 380);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(90, 24);
            textBox22.TabIndex = 58;
            textBox22.Text = "0x1234";
            // 
            // textBox23
            // 
            textBox23.Location = new Point(74, 380);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(90, 24);
            textBox23.TabIndex = 59;
            textBox23.Text = "1010h";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 383);
            label11.Name = "label11";
            label11.Size = new Size(55, 17);
            label11.TabIndex = 57;
            label11.Text = "address";
            // 
            // button21
            // 
            button21.Location = new Point(316, 380);
            button21.Name = "button21";
            button21.Size = new Size(44, 24);
            button21.TabIndex = 55;
            button21.Text = "W";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(170, 379);
            button22.Name = "button22";
            button22.Size = new Size(44, 24);
            button22.TabIndex = 56;
            button22.Text = "R";
            button22.UseVisualStyleBackColor = true;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(220, 410);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(90, 24);
            textBox24.TabIndex = 63;
            textBox24.Text = "0x1234";
            // 
            // textBox25
            // 
            textBox25.Location = new Point(74, 410);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(90, 24);
            textBox25.TabIndex = 64;
            textBox25.Text = "1010h";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 413);
            label12.Name = "label12";
            label12.Size = new Size(55, 17);
            label12.TabIndex = 62;
            label12.Text = "address";
            // 
            // button23
            // 
            button23.Location = new Point(316, 410);
            button23.Name = "button23";
            button23.Size = new Size(44, 24);
            button23.TabIndex = 60;
            button23.Text = "W";
            button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Location = new Point(170, 409);
            button24.Name = "button24";
            button24.Size = new Size(44, 24);
            button24.TabIndex = 61;
            button24.Text = "R";
            button24.UseVisualStyleBackColor = true;
            // 
            // baudrate_comb
            // 
            baudrate_comb.FormattingEnabled = true;
            baudrate_comb.Location = new Point(397, 8);
            baudrate_comb.Name = "baudrate_comb";
            baudrate_comb.Size = new Size(91, 25);
            baudrate_comb.TabIndex = 1;
            baudrate_comb.Text = "115200 ";
            // 
            // baudRate_txt
            // 
            baudRate_txt.AutoSize = true;
            baudRate_txt.Location = new Point(357, 12);
            baudRate_txt.Name = "baudRate_txt";
            baudRate_txt.Size = new Size(34, 17);
            baudRate_txt.TabIndex = 2;
            baudRate_txt.Text = "胞率";
            // 
            // format_comb
            // 
            format_comb.FormattingEnabled = true;
            format_comb.Location = new Point(537, 8);
            format_comb.Name = "format_comb";
            format_comb.Size = new Size(91, 25);
            format_comb.TabIndex = 1;
            format_comb.Text = "8/N/1";
            // 
            // rtuAscii_comb
            // 
            rtuAscii_comb.FormattingEnabled = true;
            rtuAscii_comb.Location = new Point(648, 8);
            rtuAscii_comb.Name = "rtuAscii_comb";
            rtuAscii_comb.Size = new Size(91, 25);
            rtuAscii_comb.TabIndex = 1;
            rtuAscii_comb.Text = "ASCII";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox24);
            Controls.Add(textBox25);
            Controls.Add(label12);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(textBox22);
            Controls.Add(textBox23);
            Controls.Add(label11);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(textBox20);
            Controls.Add(textBox21);
            Controls.Add(label10);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(textBox18);
            Controls.Add(textBox19);
            Controls.Add(label9);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(textBox16);
            Controls.Add(textBox17);
            Controls.Add(label8);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(textBox14);
            Controls.Add(textBox15);
            Controls.Add(label7);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(textBox12);
            Controls.Add(textBox13);
            Controls.Add(label6);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(label5);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(this.address1_hex);
            Controls.Add(address1_lbl);
            Controls.Add(baudRate_txt);
            Controls.Add(comPort_lbl);
            Controls.Add(rtuAscii_comb);
            Controls.Add(format_comb);
            Controls.Add(baudrate_comb);
            Controls.Add(comPort_comb);
            Controls.Add(writeAddress1_btn);
            Controls.Add(this.readAddress1_btn);
            Controls.Add(link_btn);
            Name = "main";
            Text = "Modbus Read/Write";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button link_btn;
        private ComboBox comPort_comb;
        private Label comPort_lbl;
        private Label address1_lbl;
        private TextBox address_hex;
        private TextBox textBox1;
        private Button writeAddress1_btn;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label3;
        private Button button5;
        private Button button6;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label4;
        private Button button7;
        private Button button8;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label5;
        private Button button9;
        private Button button10;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label label6;
        private Button button11;
        private Button button12;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label7;
        private Button button13;
        private Button button14;
        private TextBox textBox16;
        private TextBox textBox17;
        private Label label8;
        private Button button15;
        private Button button16;
        private TextBox textBox18;
        private TextBox textBox19;
        private Label label9;
        private Button button17;
        private Button button18;
        private TextBox textBox20;
        private TextBox textBox21;
        private Label label10;
        private Button button19;
        private Button button20;
        private TextBox textBox22;
        private TextBox textBox23;
        private Label label11;
        private Button button21;
        private Button button22;
        private TextBox textBox24;
        private TextBox textBox25;
        private Label label12;
        private Button button23;
        private Button button24;
        private ComboBox baudrate_comb;
        private Label baudRate_txt;
        private ComboBox format_comb;
        private ComboBox rtuAscii_comb;
    }
}
