namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
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
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.change_sign = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.delete_last = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Clear_Memory = new System.Windows.Forms.Button();
            this.Call_Memory = new System.Windows.Forms.Button();
            this.Subtract_From_Memory = new System.Windows.Forms.Button();
            this.Add_To_Memory = new System.Windows.Forms.Button();
            this.Save_To_Memory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 9;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 54);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "sqrt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(118, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "sqrt^x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(224, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "lnx";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(330, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "logxy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(330, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = "cotx";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(224, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "tanx";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(118, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.TabIndex = 6;
            this.button7.Text = "cosx";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(12, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 35);
            this.button8.TabIndex = 5;
            this.button8.Text = "sinx";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(330, 236);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 35);
            this.button9.TabIndex = 12;
            this.button9.Text = "x^y";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(224, 236);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 35);
            this.button10.TabIndex = 11;
            this.button10.Text = "e^x";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(118, 236);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 35);
            this.button11.TabIndex = 10;
            this.button11.Text = "10^x";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button12.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(12, 236);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 35);
            this.button12.TabIndex = 9;
            this.button12.Text = "x^2";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button13.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(330, 277);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 35);
            this.button13.TabIndex = 16;
            this.button13.Text = "÷";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(224, 277);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 35);
            this.button14.TabIndex = 15;
            this.button14.Text = "mod";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button15.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(118, 277);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 35);
            this.button15.TabIndex = 14;
            this.button15.Text = "!";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Mono_operations);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button16.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(12, 277);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 35);
            this.button16.TabIndex = 13;
            this.button16.Text = "%";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button17.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(330, 318);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 35);
            this.button17.TabIndex = 20;
            this.button17.Text = "х";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(224, 318);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 35);
            this.button18.TabIndex = 19;
            this.button18.Text = "9";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button19.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(118, 318);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 35);
            this.button19.TabIndex = 18;
            this.button19.Text = "8";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(12, 318);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 35);
            this.button20.TabIndex = 17;
            this.button20.Text = "7";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button21.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(330, 359);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 35);
            this.button21.TabIndex = 24;
            this.button21.Text = "-";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button22.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(224, 359);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 35);
            this.button22.TabIndex = 23;
            this.button22.Text = "6";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button23.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(118, 359);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 35);
            this.button23.TabIndex = 22;
            this.button23.Text = "5";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button24.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(12, 359);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 35);
            this.button24.TabIndex = 21;
            this.button24.Text = "4";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button25.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button25.Location = new System.Drawing.Point(330, 400);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(100, 35);
            this.button25.TabIndex = 28;
            this.button25.Text = "+";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.Bi_operations);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button26.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.Location = new System.Drawing.Point(224, 400);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 35);
            this.button26.TabIndex = 27;
            this.button26.Text = "3";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button27.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.Location = new System.Drawing.Point(118, 400);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(100, 35);
            this.button27.TabIndex = 26;
            this.button27.Text = "2";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button28.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.Location = new System.Drawing.Point(12, 400);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(100, 35);
            this.button28.TabIndex = 25;
            this.button28.Text = "1";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Equal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equal.Location = new System.Drawing.Point(330, 441);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(100, 35);
            this.Equal.TabIndex = 32;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ControlLight;
            this.point.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.Location = new System.Drawing.Point(224, 441);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(100, 35);
            this.point.TabIndex = 31;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button31.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button31.Location = new System.Drawing.Point(118, 441);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(100, 35);
            this.button31.TabIndex = 30;
            this.button31.Text = "0";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.Enter_Numbers);
            // 
            // change_sign
            // 
            this.change_sign.BackColor = System.Drawing.SystemColors.ControlLight;
            this.change_sign.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_sign.Location = new System.Drawing.Point(12, 441);
            this.change_sign.Name = "change_sign";
            this.change_sign.Size = new System.Drawing.Size(100, 35);
            this.change_sign.TabIndex = 29;
            this.change_sign.Text = "±";
            this.change_sign.UseVisualStyleBackColor = false;
            this.change_sign.Click += new System.EventHandler(this.change_sign_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button33.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button33.Location = new System.Drawing.Point(330, 113);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(100, 35);
            this.button33.TabIndex = 36;
            this.button33.Text = "1/x";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.Mono_operations);
            // 
            // delete_last
            // 
            this.delete_last.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delete_last.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_last.Location = new System.Drawing.Point(224, 113);
            this.delete_last.Name = "delete_last";
            this.delete_last.Size = new System.Drawing.Size(100, 35);
            this.delete_last.TabIndex = 35;
            this.delete_last.Text = "⮾";
            this.delete_last.UseVisualStyleBackColor = false;
            this.delete_last.Click += new System.EventHandler(this.delete_last_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ControlLight;
            this.C.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(118, 113);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 35);
            this.C.TabIndex = 34;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CE.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.Location = new System.Drawing.Point(12, 113);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(100, 35);
            this.CE.TabIndex = 33;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Clear_Memory
            // 
            this.Clear_Memory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Clear_Memory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_Memory.Location = new System.Drawing.Point(12, 72);
            this.Clear_Memory.Name = "Clear_Memory";
            this.Clear_Memory.Size = new System.Drawing.Size(79, 35);
            this.Clear_Memory.TabIndex = 37;
            this.Clear_Memory.Text = "MC";
            this.Clear_Memory.UseVisualStyleBackColor = false;
            this.Clear_Memory.Click += new System.EventHandler(this.Clear_Memory_Click);
            // 
            // Call_Memory
            // 
            this.Call_Memory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Call_Memory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Call_Memory.Location = new System.Drawing.Point(97, 72);
            this.Call_Memory.Name = "Call_Memory";
            this.Call_Memory.Size = new System.Drawing.Size(79, 35);
            this.Call_Memory.TabIndex = 38;
            this.Call_Memory.Text = "MR";
            this.Call_Memory.UseVisualStyleBackColor = false;
            this.Call_Memory.Click += new System.EventHandler(this.Call_Memory_Click);
            // 
            // Subtract_From_Memory
            // 
            this.Subtract_From_Memory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Subtract_From_Memory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtract_From_Memory.Location = new System.Drawing.Point(267, 72);
            this.Subtract_From_Memory.Name = "Subtract_From_Memory";
            this.Subtract_From_Memory.Size = new System.Drawing.Size(79, 35);
            this.Subtract_From_Memory.TabIndex = 40;
            this.Subtract_From_Memory.Text = "M-";
            this.Subtract_From_Memory.UseVisualStyleBackColor = false;
            this.Subtract_From_Memory.Click += new System.EventHandler(this.Subtract_From_Memory_Click);
            // 
            // Add_To_Memory
            // 
            this.Add_To_Memory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Add_To_Memory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_To_Memory.Location = new System.Drawing.Point(182, 72);
            this.Add_To_Memory.Name = "Add_To_Memory";
            this.Add_To_Memory.Size = new System.Drawing.Size(79, 35);
            this.Add_To_Memory.TabIndex = 39;
            this.Add_To_Memory.Text = "M+";
            this.Add_To_Memory.UseVisualStyleBackColor = false;
            this.Add_To_Memory.Click += new System.EventHandler(this.Add_To_Memory_Click);
            // 
            // Save_To_Memory
            // 
            this.Save_To_Memory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Save_To_Memory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_To_Memory.Location = new System.Drawing.Point(351, 72);
            this.Save_To_Memory.Name = "Save_To_Memory";
            this.Save_To_Memory.Size = new System.Drawing.Size(79, 35);
            this.Save_To_Memory.TabIndex = 41;
            this.Save_To_Memory.Text = "MS";
            this.Save_To_Memory.UseVisualStyleBackColor = false;
            this.Save_To_Memory.Click += new System.EventHandler(this.Save_To_Memory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(443, 483);
            this.Controls.Add(this.Save_To_Memory);
            this.Controls.Add(this.Subtract_From_Memory);
            this.Controls.Add(this.Add_To_Memory);
            this.Controls.Add(this.Call_Memory);
            this.Controls.Add(this.Clear_Memory);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.delete_last);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.point);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.change_sign);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
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
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button change_sign;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button delete_last;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Clear_Memory;
        private System.Windows.Forms.Button Call_Memory;
        private System.Windows.Forms.Button Subtract_From_Memory;
        private System.Windows.Forms.Button Add_To_Memory;
        private System.Windows.Forms.Button Save_To_Memory;
        public System.Windows.Forms.TextBox textBox1;
    }
}

