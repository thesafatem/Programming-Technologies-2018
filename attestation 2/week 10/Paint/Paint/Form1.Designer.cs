namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.color2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button22 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-6, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 460);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.tool_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.Location = new System.Drawing.Point(58, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "rect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.tool_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "ell";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.tool_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "trian";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.tool_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(232, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "pen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.tool_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(287, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "erase";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.tool_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(342, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 44);
            this.button7.TabIndex = 8;
            this.button7.Text = "brush";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.tool_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(397, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 44);
            this.button8.TabIndex = 9;
            this.button8.Text = "text";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.tool_Click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.Location = new System.Drawing.Point(547, 3);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(30, 29);
            this.color1.TabIndex = 10;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Color 2";
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.White;
            this.color2.Location = new System.Drawing.Point(592, 3);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(30, 29);
            this.color2.TabIndex = 12;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(646, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(22, 22);
            this.button11.TabIndex = 14;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(646, 25);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(22, 22);
            this.button12.TabIndex = 15;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button13.Location = new System.Drawing.Point(674, 25);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(22, 22);
            this.button13.TabIndex = 17;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(674, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(22, 22);
            this.button14.TabIndex = 16;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Yellow;
            this.button15.Location = new System.Drawing.Point(702, 25);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(22, 22);
            this.button15.TabIndex = 19;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Green;
            this.button16.Location = new System.Drawing.Point(702, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(22, 22);
            this.button16.TabIndex = 18;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Purple;
            this.button17.Location = new System.Drawing.Point(730, 25);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(22, 22);
            this.button17.TabIndex = 21;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Blue;
            this.button18.Location = new System.Drawing.Point(730, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(22, 22);
            this.button18.TabIndex = 20;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Aqua;
            this.button19.Location = new System.Drawing.Point(758, 25);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(22, 22);
            this.button19.TabIndex = 23;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gray;
            this.button20.Location = new System.Drawing.Point(758, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(22, 22);
            this.button20.TabIndex = 22;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.tencolors_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.OldLace;
            this.button21.Location = new System.Drawing.Point(786, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(52, 44);
            this.button21.TabIndex = 24;
            this.button21.Text = "Color change";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thin",
            "Medium",
            "Thick",
            "Very thick",
            "Most thick"});
            this.comboBox1.Location = new System.Drawing.Point(452, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(452, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Thickness";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.OldLace;
            this.button9.Location = new System.Drawing.Point(902, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 44);
            this.button9.TabIndex = 28;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.OldLace;
            this.button10.Location = new System.Drawing.Point(844, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 44);
            this.button10.TabIndex = 29;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.OldLace;
            this.button22.Location = new System.Drawing.Point(958, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(52, 44);
            this.button22.TabIndex = 30;
            this.button22.Text = "Open";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1013, 510);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

