using QLSV.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSESOCRE
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        STUDENT student = new STUDENT();
        Course course = new Course();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            //populate datagridview with students data
            dataGridViewStudent.DataSource = student.getStudent(new SqlCommand("SELECT id as StudentId, fname as FirstName, lname as LastName FROM student"));


            //populate datagridview with scores data 
            dataGridViewStudentScore.DataSource = score.getStudentScore();


            //populate listbox with courses data 
            listBoxCourse.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));

            listBoxCourse.DisplayMember = "label";
            listBoxCourse.ValueMember = "id";
        }


        //when you select a course from the listBox 
        //all scores asigned to this course will be displayed in the datagridview 
        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.getCoruseScores(int.Parse(listBoxCourse.SelectedValue.ToString()));
        }

        //display the select student scores 
        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.getStudentScoreBaseOnStudentId(int.Parse(dataGridViewStudent.CurrentRow.Cells[0].Value.ToString()));
        }


        //populate datagridview with all  scores data 
        private void labelReset_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.getStudentScore();
        }


        //print scores data from datagridview to text file 
        private void Button_Print_Click(object sender, EventArgs e)
        {
            //our file path
            //the file name  = scores_list.text;
            //location  = in the desktop 
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\scores_list.txt";

            using(var writer = new StreamWriter(path))
            {
                //check if the file exists 
                if (!File.Exists(path))
                {
                    File.Create(path);
                } 
                //rows 
                for(int i = 0; i < dataGridViewStudentScore.Rows.Count; i++)
                {
                    //columns 
                    for(int j = 0; j < dataGridViewStudentScore.Columns.Count - 1; j++)
                    {
                        writer.Write("\t"+ dataGridViewStudentScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }

                    //make a new line 
                    writer.WriteLine("");
                    //make a separation
                    writer.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }
    }
}
