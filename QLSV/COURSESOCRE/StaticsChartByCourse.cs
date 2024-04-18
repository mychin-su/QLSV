using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSESOCRE
{
    public partial class StaticsChartByCourse : Form
    {
        public StaticsChartByCourse()
        {
            InitializeComponent();
        }

        Score score = new Score();   //getAvgScoreByCourse
        private void StaticsChartByCourse_Load(object sender, EventArgs e)
        {
            FillChart();
        }

        private void FillChart()
        {
            DataTable dataTable = score.getAvgScoreByCourse();
            chartCourse.DataSource = dataTable;
            chartCourse.ChartAreas["ChartArea1"].AxisX.Title = "Course";
            chartCourse.ChartAreas["ChartArea1"].AxisY.Title = "Score";
            chartCourse.Series["Course"].XValueMember = "CourseName";
            chartCourse.Series["Course"].YValueMembers = "AverageGrade";
        }

        private void Button_PieChart_Click(object sender, EventArgs e)
        {
            DataTable dataTable = score.getAvgScoreByCourse();
            chartCourse.DataSource = dataTable;
            chartCourse.Series.Clear();
            chartCourse.Series.Add("Course");
            chartCourse.Series["Course"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartCourse.Series["Course"].XValueMember = "CourseName";
            chartCourse.Series["Course"].YValueMembers = "AverageGrade";
            chartCourse.Series["Course"].IsValueShownAsLabel = true;
        }

    
    }
}
