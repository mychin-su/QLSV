using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                int courseId = int.Parse(textBox_CourseID.Text);
                if (MessageBox.Show("Are You sure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseId))
                    {
                        MessageBox.Show("Course delete succesfully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course not Delete", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            } catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
