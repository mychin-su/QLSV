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

namespace QLSV.COURSE
{
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox_CourseID.Text, out int courseId))
                {
                    MessageBox.Show("Enter a valid numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this course?", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseId))
                    {
                        MessageBox.Show("Course deleted successfully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(dataGridView_Remove.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = dataGridView_Remove.SelectedRows[0];
                            dataGridView_Remove.Rows.Remove(selectedRow);
                        }
                        textBox_CourseID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Course not deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RemoveCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView_Remove.DataSource = course.getAllCourse(new SqlCommand("SELECT id as CourseId, label as CourseName, period as Period, description as Description, Semester, idContact  FROM CourseTable"));
        }

        private void dataGridView_Remove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Remove.Rows[e.RowIndex];
                textBox_CourseID.Text = row.Cells["CourseId"].Value.ToString(); 
            }
        }
    }
}
