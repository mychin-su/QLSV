using Org.BouncyCastle.Crypto.Tls;
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
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        Score score = new Score();
        Course course = new Course();
        string data = "Score";

        private void ManageScore_Load(object sender, EventArgs e)
        {
            //populate combobox with courses id and name 
            comboBox_SelectScore.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            comboBox_SelectScore.DisplayMember = "label";
            comboBox_SelectScore.ValueMember = "id";

            //populate datagridview with students scores 
            dataGridView_Show.DataSource = score.getStudentScore();
            dataGridView_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // display students data on datagridview 
        private void Button_ShowStudent_Click(object sender, EventArgs e)
        {
            try
            {
                data = "student";
                dataGridView_Show.DataSource = student.getStudent(new SqlCommand("SELECT student.id as StudentId, fname FirstName, lname LastName, bdate as BirthDate, email as Email, gender as Gender, phone as Phone, address as Address, picture as Picture FROM student"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // display score data on datagricview 
        private void Button_ShowScores_Click_1(object sender, EventArgs e)
        {
            try
            {
                data = "Score";
                dataGridView_Show.DataSource = score.getStudentScore();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to get data from datagridView 
        private void getDataFromDatagridView()
        {
            
            //If the user select to show student data then we will show only the student id 
            if (data == "student")
            {
                textBox_StudentID.Text = dataGridView_Show.CurrentRow.Cells[0].Value.ToString();
            }

            //If the suer select to show student data than we will show only the student id
            // + select the course from the comboBox
            else if (data == "Score")
            {
                textBox_StudentID.Text = dataGridView_Show.CurrentRow.Cells[0].Value.ToString();
                comboBox_SelectScore.SelectedValue = dataGridView_Show.CurrentRow.Cells[3].Value;
                dataGridView_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void dataGridView_Show_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBox_StudentID.Text);
                int courseId = Convert.ToInt32(comboBox_SelectScore.SelectedValue);
                float scoreValue = Convert.ToInt32(textBox_Score.Text);
                string description = richTextBox_description.Text;
                if (!score.studentScoreExists(studentId, courseId))
                {
                    if (score.insertScoreStudent(studentId, courseId, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBox_StudentID.Text);
                int courseId = Convert.ToInt32(comboBox_SelectScore.SelectedValue);

                if (MessageBox.Show("Do Want To Delete This Score?", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentId, courseId))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView_Show.DataSource = score.getStudentScore();
                        textBox_StudentID.Text = "";
                        textBox_Score.Text = "";
                        richTextBox_description.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cell before removing.", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void comboBox_SelectScore_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (comboBox_SelectScore.SelectedItem != null)
        //        {
        //            object selectedItem = comboBox_SelectScore.SelectedItem;
        //            if (selectedItem is DataRowView)
        //            {
        //                DataRowView selectedDataRowView = (DataRowView)selectedItem;
        //                int courseId = Convert.ToInt32(selectedDataRowView["id"]);
        //                int studentId = Convert.ToInt32(textBox_StudentID.Text);
        //                DataTable table = score.getScoreDescriptionBaseCourseId(studentId, courseId);

        //                if (table.Rows.Count > 0)
        //                {
        //                    textBox_Score.Text = table.Rows[0]["student_score"].ToString();
        //                    richTextBox_description.Text = table.Rows[0]["description"].ToString();
        //                }
        //                else
        //                {
        //                    textBox_Score.Clear();
        //                    richTextBox_description.Clear();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid selection");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No Course selected");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void Button_Avg_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseFrm avgScoreByCourseFrm = new AvgScoreByCourseFrm();
            avgScoreByCourseFrm.Show(this);
        }
    }
}
