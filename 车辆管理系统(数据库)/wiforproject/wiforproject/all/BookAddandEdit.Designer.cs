namespace wiforproject.all
{
    partial class BookAddandEdit
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
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            inputNumber1 = new AntdUI.InputNumber();
            inputNumber2 = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(328, 12);
            label1.Name = "label1";
            label1.Size = new Size(94, 43);
            label1.TabIndex = 1;
            label1.Text = "";
            // 
            // label2
            // 
            label2.Location = new Point(186, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 2;
            label2.Text = "图书名称";
            // 
            // label3
            // 
            label3.Location = new Point(186, 135);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 2;
            label3.Text = "图书作者";
            // 
            // label4
            // 
            label4.Location = new Point(186, 196);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 2;
            label4.Text = "图书价格";
            // 
            // label5
            // 
            label5.Location = new Point(186, 277);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 2;
            label5.Text = "图书标签";
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(342, 182);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(75, 23);
            inputNumber1.TabIndex = 4;
            inputNumber1.Text = "inputNumber1";
            // 
            // inputNumber2
            // 
            inputNumber2.Location = new Point(315, 182);
            inputNumber2.Name = "inputNumber2";
            inputNumber2.Size = new Size(136, 46);
            inputNumber2.TabIndex = 4;
            inputNumber2.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(315, 378);
            button1.Name = "button1";
            button1.Size = new Size(151, 60);
            button1.TabIndex = 5;
            button1.Text = "button1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(297, 268);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 75);
            textBox3.TabIndex = 6;
            // 
            // BookAddandEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(inputNumber2);
            Controls.Add(inputNumber1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookAddandEdit";
            Text = "BookAddandEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.InputNumber inputNumber2;
        private AntdUI.Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}