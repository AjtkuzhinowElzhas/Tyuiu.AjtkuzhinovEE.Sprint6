namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task2.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            textBoxStartStep = new TextBox();
            label1 = new Label();
            textBoxStopStep = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            buttonHelp_AEE = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            dataGridViewFunction_AEE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AEE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.ForeColor = Color.Black;
            buttonDone.Location = new Point(461, 357);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(177, 81);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += button1_Click;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(12, 411);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 387);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "Старт шага :";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(196, 411);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(125, 27);
            textBoxStopStep.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 387);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "Конец шага :";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(5, 349);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // buttonHelp_AEE
            // 
            buttonHelp_AEE.BackColor = Color.Cyan;
            buttonHelp_AEE.Location = new Point(361, 357);
            buttonHelp_AEE.Name = "buttonHelp_AEE";
            buttonHelp_AEE.Size = new Size(94, 81);
            buttonHelp_AEE.TabIndex = 7;
            buttonHelp_AEE.Text = "Справка";
            buttonHelp_AEE.UseVisualStyleBackColor = false;
            buttonHelp_AEE.Click += buttonHelp_AEE_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 343);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 261);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewFunction_AEE);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(654, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(577, 426);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // dataGridViewFunction_AEE
            // 
            chartArea2.Name = "ChartArea1";
            dataGridViewFunction_AEE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            dataGridViewFunction_AEE.Legends.Add(legend2);
            dataGridViewFunction_AEE.Location = new Point(167, 23);
            dataGridViewFunction_AEE.Name = "dataGridViewFunction_AEE";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataGridViewFunction_AEE.Series.Add(series2);
            dataGridViewFunction_AEE.Size = new Size(404, 397);
            dataGridViewFunction_AEE.TabIndex = 1;
            dataGridViewFunction_AEE.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(146, 397);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 450);
            Controls.Add(buttonHelp_AEE);
            Controls.Add(label2);
            Controls.Add(textBoxStopStep);
            Controls.Add(label1);
            Controls.Add(textBoxStartStep);
            Controls.Add(buttonDone);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Айткужинов Елжас";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AEE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxStartStep;
        private Label label1;
        private TextBox textBoxStopStep;
        private Label label2;
        private GroupBox groupBox1;
        private Button buttonHelp_AEE;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataGridViewFunction_AEE;
    }
}
