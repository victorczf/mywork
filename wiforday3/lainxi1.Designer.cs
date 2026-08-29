namespace WinFormsApp1
{
    partial class lainxi1
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
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 83);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "光标x位置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 133);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 1;
            label2.Text = "光标y位置";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 83);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 133);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // lainxi1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "lainxi1";
            Text = "lainxi1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}