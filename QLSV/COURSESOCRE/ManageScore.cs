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

        private void Button_ShowStudent_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_Show.DataSource = student.getStudent(new SqlCommand("SELECT student.id as StudentId, fname FirstName, lname LastName, bdate as BirthDate, email as Email, gender as Gender, phone as Phone, address as Address, picture as Picture FROM student"));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_Show.Rows[e.RowIndex];
                    if (dataGridView_Show.Columns.Contains("StudentId"))
                    {
                        object cellValue = row.Cells["StudentId"].Value;
                        if (cellValue != null)
                        {
                            textBox_StudentID.Text = cellValue.ToString();

                            var dataSource = score.getCourseBaseStudentIdRegister(textBox_StudentID.Text);
                            comboBox_SelectScore.DataSource = dataSource;
                            comboBox_SelectScore.ValueMember = "CourseID";
                            comboBox_SelectScore.DisplayMember = "CourseName";

                            if (dataSource.Rows.Count > 0)
                            {
                                comboBox_SelectScore.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void Button_ShowScores_Click(object sender, EventArgs e)
        {
            string studentId = textBox_StudentID.Text;
            dataGridView_Show.DataSource =  score.getCourseNameScoreStudentRegister(studentId);
            dataGridView_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBox_StudentID.Text);
                int courseId = Convert.ToInt32(comboBox_SelectScore.SelectedValue);
                float scoreValue = Convert.ToInt32(textBox_Score.Text);
                string description = richTextBox_description.Text;
            if (score.updateScoreStudent(studentId, courseId, scoreValue, description))
            {
                MessageBox.Show("Student Score Update", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student Score Not Update", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (MessageBox.Show("Are You Sure You Want To Delete This Score?", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentId, courseId))
                    {
                        textBox_StudentID.Text = "";
                        comboBox_SelectScore.DataSource = null;
                        textBox_Score.Text = "";
                        richTextBox_description.Text = "";
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
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

        private void comboBox_SelectScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int courseId = Convert.ToInt32(comboBox_SelectScore.SelectedValue);
                string studentId = textBox_StudentID.Text;
                DataTable table = score.getScoreDescriptionBaseCourseId(studentId, courseId);

                if (table.Rows.Count > 0)
                {
                    textBox_Score.Text = table.Rows[0]["student_score"].ToString(); 
                    richTextBox_description.Text = table.Rows[0]["description"].ToString(); 
                }
                else
                {
                    MessageBox.Show("No data found.");
                    textBox_Score.Clear();
                    richTextBox_description.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Avg_Click(object sender, EventArgs e)
        {

        }
    }
}
