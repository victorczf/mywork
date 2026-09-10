namespace wiforproject
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            inputNumber1 = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(306, 23);
            label1.Name = "label1";
            label1.ShowTooltip = false;
            label1.Size = new Size(93, 43);
            label1.TabIndex = 0;
            label1.Text = "注册";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 89);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 1;
            label2.Text = "用户名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 131);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 1;
            label3.Text = "密码";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 204);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 1;
            label4.Text = "年龄";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(188, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 55);
            panel1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(50, 19);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(38, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 272);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 1;
            label5.Text = "性别";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 357);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 1;
            label6.Text = "班级";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "01班", "02班", "03班" });
            comboBox1.Location = new Point(188, 357);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(198, 199);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(99, 22);
            inputNumber1.TabIndex = 5;
            inputNumber1.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(325, 397);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "提交";
            button1.Click += button1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(inputNumber1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
         
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Button button1;
    }
}