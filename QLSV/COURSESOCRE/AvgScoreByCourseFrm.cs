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
    public partial class AvgScoreByCourseFrm : Form
    {
        public AvgScoreByCourseFrm()
        {
            InitializeComponent();
        }
        Score score = new Score();  

        private void AvgScoreByCourseFrm_Load(object sender, EventArgs e)
        {
            guna2DataGridView_AvgCourse.DataSource = score.getAvgScoreByCourse();
        }
    }
}
