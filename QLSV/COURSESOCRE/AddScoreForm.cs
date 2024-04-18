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
        STUDENT student = new STUDENT();


        // on form load 
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            //populate the commbobox with course name 
            comboBox_SelectCourse.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            comboBox_SelectCourse.DisplayMember = "label";
            comboBox_SelectCourse.ValueMember = "id";


            //populate the datagridview with students data(id, first name, last name)
            SqlCommand command = new SqlCommand("SELECT id as StudentId, fname as FirstName, lname as LastName FROM student");
            DataGridViewStudents.DataSource = student.getStudent(command);
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
                int courseID = Convert.ToInt32(comboBox_SelectCourse.SelectedValue.ToString());
                float scoreValue = Convert.ToInt32(textBox_Score.Text);
                string description = richTextBox_Description.Text;

                //check id a score is already asigned to this student in this course 
                if(!score.studentScoreExists(studentID, courseID))
                {
                    if (score.insertScoreStudent(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                   
            } catch(Exception ex)
            {
                MessageBox.Show( ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void DataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //comboBox_SelectCourse.DataSource = null;
            //if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = DataGridViewStudents.Rows[e.RowIndex];
            //    int studentId = Convert.ToInt32(selectedRow.Cells["StudentId"].Value.ToString());
            //    comboBox_SelectCourse.DataSource = score.getCourseBaseStudentIdRegister(studentId);
            //    comboBox_SelectCourse.DisplayMember = "CourseName";
            //    comboBox_SelectCourse.ValueMember = "CourseId";
            //}

        }

        private void comboBox_SelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int studentId;
            //if(!int.TryParse(TextBox_StudentID.Text, out studentId))
            //{
            //    return;
            //}

            //if(comboBox_SelectCourse.SelectedValue != null )
            //{
            //    int courseId;
            //    if (int.TryParse(comboBox_SelectCourse.SelectedValue.ToString(), out courseId))
            //    {
            //        DataTable table = score.getScoreDescriptionByCourseId(studentId, courseId);
            //        if (table != null && table.Rows.Count > 0)
            //        {
            //            string description = table.Rows[0]["description"].ToString();
            //            string student_score = table.Rows[0]["student_score"].ToString();
            //            textBox_Score.Text = student_score;
            //            richTextBox_Description.Text = description;
            //        }
            //        else
            //        {
            //            textBox_Score.Text = string.Empty;
            //            richTextBox_Description.Text += string.Empty;
            //        }
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}  else
            //{
            //    return;
            //}
        }
    }
}
