namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task6.V1
{
    partial class FormMain
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Location = new Point(2, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 131);
            panel1.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 696);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 1 | Айткужинов.Е.Е";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}
