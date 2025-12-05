namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonDone = new Button();
            textVarX = new TextBox();
            textResult = new TextBox();
            buttonHelp = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(582, 354);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(206, 84);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += button1_Click;
            // 
            // textVarX
            // 
            textVarX.Location = new Point(168, 409);
            textVarX.Name = "textVarX";
            textVarX.Size = new Size(125, 27);
            textVarX.TabIndex = 1;
            textVarX.TextChanged += textVarX_TextChanged;
            // 
            // textResult
            // 
            textResult.Location = new Point(663, 321);
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.Size = new Size(125, 27);
            textResult.TabIndex = 2;
            textResult.TextChanged += textResult_TextChanged;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(427, 409);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(126, 29);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 348);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(524, 20);
            label1.TabIndex = 5;
            label1.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в \r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(354, 20);
            label2.TabIndex = 5;
            label2.Text = "TextBox. Округлить до трёх знаков после запятой.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(419, 20);
            label3.TabIndex = 5;
            label3.Text = "Графический интерфейс оформить по шаблону из лекции.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(601, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 81);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(168, 354);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(125, 104);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Введите значение х";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(582, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(206, 320);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод Данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 160);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 0;
            label4.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 449);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Controls.Add(textResult);
            Controls.Add(textVarX);
            Controls.Add(buttonDone);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private TextBox textVarX;
        private TextBox textResult;
        private Button buttonHelp;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
    }
}
