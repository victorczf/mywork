namespace WinFormsApp1.Book
{
    partial class BookAdd
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
            ucBook1 = new WinFormsApp1.Controls.UCBook("新增");
            SuspendLayout();
            // 
            // ucBook1
            // 
            ucBook1.Location = new Point(79, 12);
            ucBook1.Margin = new Padding(2, 3, 2, 3);
            ucBook1.Name = "ucBook1";
            ucBook1.Size = new Size(672, 707);
            ucBook1.TabIndex = 0;
            // 
            // BookAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 631);
            Controls.Add(ucBook1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "BookAdd";
            Text = "BookAdd";
            ResumeLayout(false);
        }

        #endregion

        private Controls.UCBook ucBook1;
    }
}