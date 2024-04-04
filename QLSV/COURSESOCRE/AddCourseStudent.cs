using QLSV.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSESOCRE
{
    public partial class AddCourseStudent : Form
    {
        private int studentId;
        public AddCourseStudent(int studentID)
        {
            this.studentId = studentID;
            InitializeComponent();
        }

        Course course = new Course();
        STUDENT student = new STUDENT();

        private void AddCourseFrm_Load(object sender, EventArgs e)
        {
            TextBox_StudentID.Text = studentId.ToString();
            guna2ComboBox_Semester.SelectedIndex = 0;
            int semester = Int32.Parse(guna2ComboBox_Semester.Text);
            guna2DataGridView_Available.DataSource = course.getCourseStudentIdNotRegister(studentId, semester);
            guna2DataGridView_Selected.Columns.Add("Columns", "Course Name");
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView_Available.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView_Available.SelectedRows[0];  // là một collection chứa tất cả các hàng được chọn trong gridView và [0] là chỉ mục của phần tử đầu tiên trong collection "SelectRows"
                string value = selectedRow.Cells[0].Value.ToString();

                //Them gia tri vao DataGridView2
                guna2DataGridView_Selected.Rows.Add(value);

                //Xoa dong da chon tu DataGridView1
                guna2DataGridView_Available.Rows.Remove(selectedRow);
            } else
            {
                MessageBox.Show("Vui lòng chọn một hàng tron Available Course trước khi nhấn nút Add.");
            }
        }

        private void guna2ComboBox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semester = Int32.Parse(guna2ComboBox_Semester.Text);
            guna2DataGridView_Available.DataSource = course.getCourseStudentIdNotRegister(studentId, semester);
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView_Selected.Rows.Count == 0)
            {
                MessageBox.Show("No course selected.", "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow row in guna2DataGridView_Selected.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string value = row.Cells[0].Value.ToString();
                        student.updateStudentCourse(studentId, value);
                    }
                }
                MessageBox.Show("Courses added successfully.", "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
