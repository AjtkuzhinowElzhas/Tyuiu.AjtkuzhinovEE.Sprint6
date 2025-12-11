namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task3.V8
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            textBoxResult = new TextBox();
            buttonHelp_AEE = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(791, 393);
            button1.Name = "button1";
            button1.Size = new Size(173, 45);
            button1.TabIndex = 0;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 435);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(377, 60);
            label1.TabIndex = 0;
            label1.Text = "Дан массив 5 на 5 элементов.\r\n\r\n Заменить четные значения в четвертой строке на 0.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 188);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 6;
            label6.Text = "16 -10   4  15  16";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 168);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 5;
            label5.Text = "10  18  -5   9  -6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 148);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 4;
            label4.Text = "-20 -15  -6   8  -4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 128);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 3;
            label3.Text = "15 -13 -19   9   1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "-10  10  -7  19   6";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(407, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 302);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "0";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(791, 43);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(161, 27);
            textBoxResult.TabIndex = 3;
            // 
            // buttonHelp_AEE
            // 
            buttonHelp_AEE.Location = new Point(661, 409);
            buttonHelp_AEE.Name = "buttonHelp_AEE";
            buttonHelp_AEE.Size = new Size(94, 29);
            buttonHelp_AEE.TabIndex = 4;
            buttonHelp_AEE.Text = "?";
            buttonHelp_AEE.UseVisualStyleBackColor = true;
            buttonHelp_AEE.Click += buttonHelp_AEE_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 450);
            Controls.Add(buttonHelp_AEE);
            Controls.Add(textBoxResult);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Айткужинов Елжас | Таск 3 | Вариант 8";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBoxResult;
        private Button buttonHelp_AEE;
    }
}
