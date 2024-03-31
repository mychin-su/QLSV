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

namespace QLSV
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void Print_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            fillGrid(command);

            //dieu khien cac radioButton chuyen trang thai 
            if(radioNo.Checked) // hard code
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        public void fillGrid(SqlCommand cmd)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudent(cmd);
            dataGridView1.Columns["bdate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            picol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;
            if(radioYes.Checked == true) // Neu theo Date 
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioMale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Male' AND bdate BETWEEN '" + date1 + " 'AND'" + date2 + "'";
                } else if (radioFemale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Female' AND bdate BETWEEN '" + date1 + " 'AND'" + date2 + "'";
                } else
                {
                    query = "SELECT * FROM student WHERE bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }

               
            } else // Neu khong can theo Date 
            {
                if (radioMale.Checked)
                {
                    query = "SELECT  * FROM student WHERE gender = 'Male'";
                } else if (radioFemale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Female'";
                } else
                {
                    query = "SELECT * FROM student";  //Chon All
                }
            }
            command = new SqlCommand(query);
            fillGrid(command);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\student_list.txt";
            using(var writer = new StreamWriter(path))
            {
                if (!File.Exists(path)) // nếu file chưa tồn tại đường dẫn 
                {
                    File.Create(path); // tạo đường dẫn 
                }
                DateTime bdate;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" +"|");
                        } else if(j == dataGridView1.ColumnCount - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        } else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                   // writer.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Xem kết quả");
            }
        }

        private void buttonPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages =  true;    
            if(printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}
