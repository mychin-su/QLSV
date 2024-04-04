using QLSV.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSESOCRE
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();


        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CourseTable");
            fillGrid(command);

        }


        private void fillGrid(SqlCommand command)
        {
            dataGridView_Course.ReadOnly = true;
            dataGridView_Course.RowTemplate.Height = 40;
            dataGridView_Course.DataSource = course.getAllCourse(command);
            dataGridView_Course.AllowUserToAddRows = false;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\courselist.txt";
            using (var writer = new StreamWriter(path))
            {
                if(!File.Exists(path))// neu file chua ton tai duong dan
                {
                    File.Create(path);
                }
                //Dat ten cho cac cot 
                writer.WriteLine("Course ID\tCourse Name\t\tHours\t\t\tDescription");
                for(int i = 0; i < dataGridView_Course.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridView_Course.Columns.Count; j++)
                    {
                        if(j == dataGridView_Course.Columns.Count - 1) {
                            writer.Write(dataGridView_Course.Rows[i].Cells[j].Value.ToString().PadRight(20));
                            break;
                        }
                     
                        writer.Write(dataGridView_Course.Rows[i].Cells[j].Value.ToString().PadRight(20) + "|");
                    }
                    writer.WriteLine("");
                }
                writer.WriteLine(new String('-', 80));
                MessageBox.Show("Xem kết quả");
            }
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if(printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }

        }
    }
}
