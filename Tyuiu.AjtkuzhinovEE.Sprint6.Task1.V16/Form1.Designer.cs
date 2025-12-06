namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task1.V16
{
    partial class Form1
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
            button1 = new Button();
            buttonHelp_AEE = new Button();
            textBoxResult_AEE = new TextBox();
            textBoxStartValue_AEE = new TextBox();
            textBoxStopValue_AEE = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(593, 340);
            button1.Name = "button1";
            button1.Size = new Size(195, 113);
            button1.TabIndex = 0;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonHelp_AEE
            // 
            buttonHelp_AEE.BackColor = Color.Red;
            buttonHelp_AEE.Location = new Point(493, 340);
            buttonHelp_AEE.Name = "buttonHelp_AEE";
            buttonHelp_AEE.Size = new Size(94, 113);
            buttonHelp_AEE.TabIndex = 1;
            buttonHelp_AEE.Text = "Справка";
            buttonHelp_AEE.UseVisualStyleBackColor = false;
            buttonHelp_AEE.Click += buttonHelp_AEE_Click;
            // 
            // textBoxResult_AEE
            // 
            textBoxResult_AEE.Location = new Point(593, 41);
            textBoxResult_AEE.Multiline = true;
            textBoxResult_AEE.Name = "textBoxResult_AEE";
            textBoxResult_AEE.Size = new Size(195, 293);
            textBoxResult_AEE.TabIndex = 2;
            // 
            // textBoxStartValue_AEE
            // 
            textBoxStartValue_AEE.Location = new Point(12, 426);
            textBoxStartValue_AEE.Name = "textBoxStartValue_AEE";
            textBoxStartValue_AEE.Size = new Size(149, 27);
            textBoxStartValue_AEE.TabIndex = 3;
            // 
            // textBoxStopValue_AEE
            // 
            textBoxStopValue_AEE.Location = new Point(239, 426);
            textBoxStopValue_AEE.Name = "textBoxStopValue_AEE";
            textBoxStopValue_AEE.Size = new Size(175, 27);
            textBoxStopValue_AEE.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 403);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Старт шага :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 403);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 6;
            label2.Text = "Конец шага :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 383);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 7;
            label3.Text = "Ввод данных";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 9);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Результат :";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 475);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxStopValue_AEE);
            Controls.Add(textBoxStartValue_AEE);
            Controls.Add(textBoxResult_AEE);
            Controls.Add(buttonHelp_AEE);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonHelp_AEE;
        private TextBox textBoxResult_AEE;
        private TextBox textBoxStartValue_AEE;
        private TextBox textBoxStopValue_AEE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
