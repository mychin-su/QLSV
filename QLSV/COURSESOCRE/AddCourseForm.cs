using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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


        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            this.comboBox_Semester.SelectedIndex = 0;
        }


        private void Button_Add_Click(object sender, EventArgs e)
        {
            //check if the name is not empty 
            //check if this course already exists 
            //the course hourse number be > 10, we can do it from the numericDropDown Tool, or by using the if condition the description is optional 
             
           int courseID = int.Parse(textBox_CourseID.Text);
           string name = textBox_Label.Text;
           int hrs =int.Parse(textBox_Period.Text);
           string desc = richTextBox_Description.Text;
            string semester = comboBox_Semester.Text;

           if(name.Trim() == "")  // lam viec voi string xoa het cac khoang trang truoc sau chi lay ten
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else  if (verif()){
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!course.checkCourseName(name)) // nếu couseName chưa tồn tại
            {
                if (course.insertCourse(courseID, name, hrs, desc, semester))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (hrs <= 10)
            {
                MessageBox.Show("Period must be greater 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("This Course Name Already Exits", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool verif()
        {
            if (textBox_CourseID.Text.Trim() == "" || textBox_Label.Text == "" || textBox_Period.Text == "" || richTextBox_Description.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        
    }
}
