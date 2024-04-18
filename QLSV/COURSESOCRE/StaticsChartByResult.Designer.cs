namespace QLSV.COURSESOCRE
{
    partial class StaticsChartByResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_ColumnChart = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).BeginInit();
            this.SuspendLayout();
            // 
            // chartScore
            // 
            chartArea4.Name = "ChartArea1";
            this.chartScore.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartScore.Legends.Add(legend4);
            this.chartScore.Location = new System.Drawing.Point(21, 12);
            this.chartScore.Name = "chartScore";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Result";
            this.chartScore.Series.Add(series4);
            this.chartScore.Size = new System.Drawing.Size(514, 555);
            this.chartScore.TabIndex = 0;
            this.chartScore.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "staticsScore";
            title4.Text = "Statics Result";
            this.chartScore.Titles.Add(title4);
            // 
            // Button_ColumnChart
            // 
            this.Button_ColumnChart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_ColumnChart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_ColumnChart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_ColumnChart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_ColumnChart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ColumnChart.ForeColor = System.Drawing.Color.White;
            this.Button_ColumnChart.Location = new System.Drawing.Point(563, 522);
            this.Button_ColumnChart.Name = "Button_ColumnChart";
            this.Button_ColumnChart.Size = new System.Drawing.Size(180, 45);
            this.Button_ColumnChart.TabIndex = 1;
            this.Button_ColumnChart.Text = "Column Chart";
            this.Button_ColumnChart.Click += new System.EventHandler(this.Button_ColumnChart_Click);
            // 
            // StaticsChartByResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 581);
            this.Controls.Add(this.Button_ColumnChart);
            this.Controls.Add(this.chartScore);
            this.Name = "StaticsChartByResult";
            this.Text = "StaticsChartByResult";
            this.Load += new System.EventHandler(this.StaticsChartByResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartScore;
        private Guna.UI2.WinForms.Guna2Button Button_ColumnChart;
    }
}