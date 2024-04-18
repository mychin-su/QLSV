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
    public partial class StaticsChartByResult : Form
    {
        public StaticsChartByResult()
        {
            InitializeComponent();
        }

        Score score = new Score();
        private void StaticsChartByResult_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ phương thức getResultStudent()
            DataTable dataTable = score.getResultStudent();
            chartScore.DataSource = dataTable;
            chartScore.Series["Result"].XValueMember = "Result";
            chartScore.Series["Result"].YValueMembers = "TotalStudents";
        }

        private void Button_ColumnChart_Click(object sender, EventArgs e)
        {
            DataTable dataTable = score.getResultStudent();
            chartScore.DataSource = dataTable;
            chartScore.Series.Clear();
            chartScore.Series.Add("Score");
            chartScore.Series["Score"].XValueMember = "Result";
            chartScore.Series["Score"].YValueMembers = "TotalStudents";
        }
    }
}
