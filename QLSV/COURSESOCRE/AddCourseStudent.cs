using QLSV.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSESOCRE
{
    public partial class AddCourseStudent : Form
    {
        private int studentId;
        Course course = new Course();
        Score score = new Score();
        public AddCourseStudent(int studentID)
        {
            this.studentId = studentID;
            InitializeComponent();
        }

        private void AddCourseStudent_Load(object sender, EventArgs e)
        {
            TextBox_StudentID.Text = studentId.ToString();
            guna2ComboBox_Semester.SelectedIndex = 0;
            guna2DataGridView_Selected.Columns.Add("Columns", "Course Name");
            guna2DataGridView_Available.DataSource = course.getCourseStudentIdNotRegister(studentId, int.Parse(guna2ComboBox_Semester.Text));
        }

        private void guna2ComboBox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2DataGridView_Available.DataSource = course.getCourseStudentIdNotRegister(studentId, int.Parse(guna2ComboBox_Semester.Text));
            guna2DataGridView_Selected.Rows.Clear();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
           try
            {
                if (guna2DataGridView_Available.Rows.Count > 0)
                {
                    DataGridViewRow selectedRow = guna2DataGridView_Available.SelectedRows[0]; // là 1 collection chứa tất cả các hàng được chọn trong gridView và [0] là chỉ mục của phần tử đầu tiên trong collestion "SelectRows"
                    string value = selectedRow.Cells[0].Value.ToString();

                    guna2DataGridView_Selected.Rows.Add(value);
                    guna2DataGridView_Available.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng tron Available Course trước khi nhấn nút Add.");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
           try
            {
                if (guna2DataGridView_Selected.Rows.Count > 0)
                {
                  //  List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in guna2DataGridView_Selected.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string courseName = row.Cells[0].Value.ToString().Trim();
                            int courseId = course.getIdBaseOnCourseName(courseName);
                            if (courseId != -1)
                            {
                                score.insertCourseStudent(studentId, courseId);
                            }
                            else
                            {
                                MessageBox.Show("Courses added Failed.", "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    guna2DataGridView_Selected.Rows.Clear();
                    MessageBox.Show("Courses added successfully.", "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Course selected", "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
       
}