namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task4.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonDone_AEE = new Button();
            buttonHelp_AEE = new Button();
            chartTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            panel1 = new Panel();
            buttonSave_AEE = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            textBoxResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chartTask).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_AEE
            // 
            buttonDone_AEE.Location = new Point(646, 12);
            buttonDone_AEE.Name = "buttonDone_AEE";
            buttonDone_AEE.Size = new Size(110, 63);
            buttonDone_AEE.TabIndex = 0;
            buttonDone_AEE.Text = "Выполнить";
            buttonDone_AEE.UseVisualStyleBackColor = true;
            buttonDone_AEE.Click += buttonDone_AEE_Click;
            // 
            // buttonHelp_AEE
            // 
            buttonHelp_AEE.Location = new Point(1022, 12);
            buttonHelp_AEE.Name = "buttonHelp_AEE";
            buttonHelp_AEE.Size = new Size(94, 63);
            buttonHelp_AEE.TabIndex = 1;
            buttonHelp_AEE.Text = "?";
            buttonHelp_AEE.UseVisualStyleBackColor = true;
            buttonHelp_AEE.Click += buttonHelp_AEE_Click;
            // 
            // chartTask
            // 
            chartArea2.Name = "ChartArea1";
            chartTask.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTask.Legends.Add(legend2);
            chartTask.Location = new Point(285, 105);
            chartTask.Name = "chartTask";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTask.Series.Add(series2);
            chartTask.Size = new Size(831, 333);
            chartTask.TabIndex = 2;
            chartTask.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "график функции sin(x)";
            chartTask.Titles.Add(title2);
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(285, 48);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(101, 27);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(436, 48);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(buttonSave_AEE);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxStop);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxStart);
            panel1.Controls.Add(buttonDone_AEE);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 99);
            panel1.TabIndex = 5;
            // 
            // buttonSave_AEE
            // 
            buttonSave_AEE.Location = new Point(775, 12);
            buttonSave_AEE.Name = "buttonSave_AEE";
            buttonSave_AEE.Size = new Size(141, 63);
            buttonSave_AEE.TabIndex = 6;
            buttonSave_AEE.Text = "Сохранить";
            buttonSave_AEE.UseVisualStyleBackColor = true;
            buttonSave_AEE.Click += buttonSave_AEE_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FloralWhite;
            label2.Location = new Point(436, 25);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец шага :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Location = new Point(285, 25);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Старт шага:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(textBoxResult);
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 340);
            panel2.TabIndex = 6;
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(0, 0);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(259, 340);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 450);
            Controls.Add(chartTask);
            Controls.Add(buttonHelp_AEE);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Айткужинов Елжас | Таск 4 |Вариант 4";
            ((System.ComponentModel.ISupportInitialize)chartTask).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_AEE;
        private Button buttonHelp_AEE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTask;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button buttonSave_AEE;
        private TextBox textBoxResult;
    }
}
