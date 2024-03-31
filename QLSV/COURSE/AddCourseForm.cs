using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSE
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();
        MY_DB mydb = new MY_DB();   

        private void Button_Add_Click(object sender, EventArgs e)
        {
           int courseID = int.Parse(textBox_CourseID.Text);
           string label = textBox_Label.Text;
           int period =int.Parse(textBox_Period.Text);
           string description = richTextBox_Description.Text;
            if (period < 10)
            {
                MessageBox.Show("Period must be greater 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (verif())
            {
                if (course.checkCourseName(label, courseID))
                if(course.insertCourse(courseID, label, period, description))
                {
                    MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool verif()
        {
            if (textBox_CourseID.Text.Trim() == "" || textBox_Label.Text == "" || textBox_Period.Text == "" || richTextBox_Description.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

       
    }
}
