namespace wiforproject.car
{
    partial class Addcar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 37);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "车辆";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 94);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "车牌号：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 152);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 1;
            label3.Text = "每小时费用：";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "轿车", "跑车", "SUV" });
            comboBox1.Location = new Point(284, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 152);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 1;
            label4.Text = "每小时费用：";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "轿车", "跑车", "SUV" });
            comboBox2.Location = new Point(284, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 216);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 1;
            label5.Text = "车辆类型：";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "轿车", "跑车", "SUV" });
            comboBox3.Location = new Point(284, 213);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 25);
            comboBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(302, 327);
            button1.Name = "button1";
            button1.Size = new Size(103, 47);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Addcar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addcar";
            Text = "Addcar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Button button1;
    }
}