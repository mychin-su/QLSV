namespace QLSV.COURSESOCRE
{
    partial class StaticsChartByCourse
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartCourse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_PieChart = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCourse
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCourse.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCourse.Legends.Add(legend2);
            this.chartCourse.Location = new System.Drawing.Point(12, 12);
            this.chartCourse.Name = "chartCourse";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Course";
            this.chartCourse.Series.Add(series2);
            this.chartCourse.Size = new System.Drawing.Size(676, 513);
            this.chartCourse.TabIndex = 0;
            this.chartCourse.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "staticsCourse";
            title2.Text = "Statics By Course";
            this.chartCourse.Titles.Add(title2);
            // 
            // Button_PieChart
            // 
            this.Button_PieChart.AutoRoundedCorners = true;
            this.Button_PieChart.BorderRadius = 22;
            this.Button_PieChart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_PieChart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_PieChart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_PieChart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_PieChart.FillColor = System.Drawing.Color.Lime;
            this.Button_PieChart.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_PieChart.ForeColor = System.Drawing.Color.Red;
            this.Button_PieChart.Location = new System.Drawing.Point(711, 478);
            this.Button_PieChart.Name = "Button_PieChart";
            this.Button_PieChart.Size = new System.Drawing.Size(180, 47);
            this.Button_PieChart.TabIndex = 1;
            this.Button_PieChart.Text = "Pie Chart";
            this.Button_PieChart.Click += new System.EventHandler(this.Button_PieChart_Click);
            // 
            // StaticsChartByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(903, 537);
            this.Controls.Add(this.Button_PieChart);
            this.Controls.Add(this.chartCourse);
            this.Name = "StaticsChartByCourse";
            this.Text = "StaticsChartByCourse";
            this.Load += new System.EventHandler(this.StaticsChartByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCourse;
        private Guna.UI2.WinForms.Guna2Button Button_PieChart;
    }
}