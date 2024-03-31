using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;

        private void Statistic_Load(object sender, EventArgs e)
        {
            //get panels color 
            panTotalColor = PanelTotal.BackColor;
            panMaleColor = PanelMale.BackColor;
            panFemaleColor = PanelFemale.BackColor;

            //display the values 
            STUDENT student = new STUDENT();

            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            //tinh %, cac bạn xem lại phép toán 
            // (tong student X 100) / (total students)
            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentPercentage = (totalFemale * (100 / total));
            LabelTotal.Text = ("Total Students: " + total.ToString());
            LabelMale.Text = ("Male : " + (maleStudentsPercentage.ToString("0.00") + "%"));
            LabelFemale.Text = ("Female: " + (femaleStudentPercentage.ToString("0.00") + "%"));
        }


        //Thử việc event làm việc với Panel 
        private void LabelTotal_MouseEnter(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = panTotalColor;
            LabelTotal.BackColor = Color.White;
        }

        private void LabelTotal_MouseLeave(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = Color.White;
            LabelTotal.BackColor = panTotalColor;
        }

        private void LabelMale_MouseEnter(object sender, EventArgs e)
        {
            LabelMale.ForeColor = panMaleColor;
            PanelMale.BackColor = Color.White;
        }

        private void LabelMale_MouseLeave(object sender, EventArgs e)
        {
            LabelMale.ForeColor = Color.White;
            PanelMale.BackColor = panMaleColor;
        }

        private void LabelFemale_MouseEnter(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = panFemaleColor;
            PanelFemale.BackColor = Color.White;
        }

        private void LabelFemale_MouseLeave(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = Color.White;
            PanelFemale.BackColor = panFemaleColor;
        }

    }
}
