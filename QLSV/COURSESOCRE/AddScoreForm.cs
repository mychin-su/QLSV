using QLSV.COURSE;
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

namespace QLSV.COURSESOCRE
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        Course course = new Course();
        STUDENT STUDENT = new STUDENT();


        // on form load 
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            //lay thong tin all couse 
            comboBox_SelectCourse.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            comboBox_SelectCourse.DisplayMember = "label";
            comboBox_SelectCourse.ValueMember = "id";

            //dua no voi student 
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM student");
            DataGridViewStudents.DataSource = STUDENT.getStudent(command);
        }
   
        //on datagridview_students click 
        private void DataGridViewStudents_Click(object sender, EventArgs e)
        {
            //get the id of the selected student 
            TextBox_StudentID.Text = DataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
        }


        //Button Add Score 
        private void Button_AddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(TextBox_StudentID.Text);
                int courseID = Convert.ToInt32(comboBox_SelectCourse.SelectedValue);
                float scoreValue = Convert.ToInt32(textBox_Score.Text);
                string description = richTextBox_Description.Text;
                if(!score.studentScoreExits(studentID, courseID))
                {
                    if(score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(Exception ex)
            {

                MessageBox.Show( ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
