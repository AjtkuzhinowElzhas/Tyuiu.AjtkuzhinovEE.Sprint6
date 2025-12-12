namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task7.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonOpenFile_AEE = new Button();
            buttonExecute_AEE = new Button();
            buttonOpen_AEE = new Button();
            buttonHelp_AEE = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            dataGridViewIn = new DataGridView();
            groupBox2 = new GroupBox();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            dataGridViewOut = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_AEE = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonOpenFile_AEE);
            panel1.Controls.Add(buttonExecute_AEE);
            panel1.Controls.Add(buttonOpen_AEE);
            panel1.Controls.Add(buttonHelp_AEE);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 88);
            panel1.TabIndex = 0;
            // 
            // buttonOpenFile_AEE
            // 
            buttonOpenFile_AEE.Image = (Image)resources.GetObject("buttonOpenFile_AEE.Image");
            buttonOpenFile_AEE.Location = new Point(353, 12);
            buttonOpenFile_AEE.Name = "buttonOpenFile_AEE";
            buttonOpenFile_AEE.Size = new Size(158, 70);
            buttonOpenFile_AEE.TabIndex = 3;
            buttonOpenFile_AEE.UseVisualStyleBackColor = true;
            buttonOpenFile_AEE.Click += buttonOpen_AEE_Click;
            // 
            // buttonExecute_AEE
            // 
            buttonExecute_AEE.Image = (Image)resources.GetObject("buttonExecute_AEE.Image");
            buttonExecute_AEE.Location = new Point(184, 12);
            buttonExecute_AEE.Name = "buttonExecute_AEE";
            buttonExecute_AEE.Size = new Size(153, 70);
            buttonExecute_AEE.TabIndex = 2;
            buttonExecute_AEE.UseVisualStyleBackColor = true;
            buttonExecute_AEE.Click += buttonExecute_AEE_Click;
            // 
            // buttonOpen_AEE
            // 
            buttonOpen_AEE.Image = (Image)resources.GetObject("buttonOpen_AEE.Image");
            buttonOpen_AEE.Location = new Point(27, 12);
            buttonOpen_AEE.Name = "buttonOpen_AEE";
            buttonOpen_AEE.Size = new Size(128, 70);
            buttonOpen_AEE.TabIndex = 1;
            buttonOpen_AEE.UseVisualStyleBackColor = true;
            buttonOpen_AEE.Click += buttonOpen_AEE_Click;
            // 
            // buttonHelp_AEE
            // 
            buttonHelp_AEE.Image = (Image)resources.GetObject("buttonHelp_AEE.Image");
            buttonHelp_AEE.Location = new Point(938, 12);
            buttonHelp_AEE.Name = "buttonHelp_AEE";
            buttonHelp_AEE.Size = new Size(94, 70);
            buttonHelp_AEE.TabIndex = 0;
            buttonHelp_AEE.UseVisualStyleBackColor = true;
            buttonHelp_AEE.Click += buttonHelp_AEE_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 103);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1043, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1005, 68);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(dataGridViewIn);
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(633, 434);
            panel3.TabIndex = 2;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(27, 32);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(577, 376);
            dataGridViewIn.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(615, 416);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(groupBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(633, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(434, 434);
            panel4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOut);
            groupBox3.Location = new Point(16, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(406, 416);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(6, 26);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(377, 379);
            dataGridViewOut.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.White;
            splitter1.Location = new Point(633, 191);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 434);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_AEE
            // 
            openFileDialogTask_AEE.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 625);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 18 | Айткужинов Е.Е.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Splitter splitter1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewIn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOut;
        private TextBox textBox1;
        private Button buttonHelp_AEE;
        private Button buttonOpen_AEE;
        private OpenFileDialog openFileDialogTask_AEE;
        private SaveFileDialog saveFileDialogMatrix;
        private Button buttonExecute_AEE;
        private Button buttonOpenFile_AEE;
    }
}
