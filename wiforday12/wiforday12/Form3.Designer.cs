namespace WinFormsApp2
{
    partial class Form3
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
            panel1 = new DoubleBufferPanel();
            SuspendLayout(); // 暂停 界面 布局(界面绘制)
            // 
            // panel1
            // 
            panel1.Location = new Point(296, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 388);
            panel1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 609);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false); // 启动界面绘制
        }

        #endregion

        private Panel panel1;
    }
}