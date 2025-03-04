namespace TaskManagementSystem
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label1 = new Label();
            TotalTasks = new Label();
            panel2 = new Panel();
            label3 = new Label();
            PendingTasks = new Label();
            panel3 = new Panel();
            label5 = new Label();
            InProgressTasks = new Label();
            panel4 = new Panel();
            label7 = new Label();
            CompletedTasks = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Montserrat-Arabic Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel3.Location = new Point(43, 26);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(179, 68);
            bigLabel3.TabIndex = 1;
            bigLabel3.Text = "Report";
            // 
            // chart1
            // 
            chart1.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.ForeColor = Color.Transparent;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(413, 165);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = Color.Black;
            series1.ShadowOffset = 2;
            chart1.Series.Add(series1);
            chart1.Size = new Size(454, 465);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TotalTasks);
            panel1.Location = new Point(43, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 191);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat-Arabic ExtraBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(191, 48);
            label1.TabIndex = 0;
            label1.Text = "Total Tasks";
            // 
            // TotalTasks
            // 
            TotalTasks.AutoSize = true;
            TotalTasks.BackColor = Color.Transparent;
            TotalTasks.Font = new Font("Montserrat-Arabic Medium", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalTasks.ForeColor = Color.White;
            TotalTasks.Location = new Point(71, 47);
            TotalTasks.Name = "TotalTasks";
            TotalTasks.Size = new Size(93, 108);
            TotalTasks.TabIndex = 1;
            TotalTasks.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PendingTasks);
            panel2.Location = new Point(43, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 65);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat-Arabic ExtraBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(121, 39);
            label3.TabIndex = 0;
            label3.Text = "Pending";
            // 
            // PendingTasks
            // 
            PendingTasks.AutoSize = true;
            PendingTasks.BackColor = Color.Transparent;
            PendingTasks.Font = new Font("Montserrat-Arabic Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PendingTasks.ForeColor = Color.White;
            PendingTasks.Location = new Point(160, 2);
            PendingTasks.Name = "PendingTasks";
            PendingTasks.Size = new Size(49, 55);
            PendingTasks.TabIndex = 1;
            PendingTasks.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Chocolate;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(InProgressTasks);
            panel3.Location = new Point(43, 470);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 65);
            panel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat-Arabic ExtraBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(151, 39);
            label5.TabIndex = 0;
            label5.Text = "InProgress";
            // 
            // InProgressTasks
            // 
            InProgressTasks.AutoSize = true;
            InProgressTasks.BackColor = Color.Transparent;
            InProgressTasks.Font = new Font("Montserrat-Arabic Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InProgressTasks.ForeColor = Color.White;
            InProgressTasks.Location = new Point(160, 2);
            InProgressTasks.Name = "InProgressTasks";
            InProgressTasks.Size = new Size(49, 55);
            InProgressTasks.TabIndex = 1;
            InProgressTasks.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrange;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(CompletedTasks);
            panel4.Location = new Point(43, 544);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 65);
            panel4.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat-Arabic ExtraBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 11);
            label7.Name = "label7";
            label7.Size = new Size(157, 39);
            label7.TabIndex = 0;
            label7.Text = "Completed";
            // 
            // CompletedTasks
            // 
            CompletedTasks.AutoSize = true;
            CompletedTasks.BackColor = Color.Transparent;
            CompletedTasks.Font = new Font("Montserrat-Arabic Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompletedTasks.ForeColor = Color.White;
            CompletedTasks.Location = new Point(160, 2);
            CompletedTasks.Name = "CompletedTasks";
            CompletedTasks.Size = new Size(49, 55);
            CompletedTasks.TabIndex = 1;
            CompletedTasks.Text = "0";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(891, 694);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(chart1);
            Controls.Add(bigLabel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel1;
        private Label label1;
        private Label TotalTasks;
        private Panel panel2;
        private Label label3;
        private Label PendingTasks;
        private Panel panel3;
        private Label label5;
        private Label InProgressTasks;
        private Panel panel4;
        private Label label7;
        private Label CompletedTasks;
    }
}