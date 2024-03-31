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

        private void button1_Click(object sender, EventArgs e)
        {
           int courseId = int.Parse(textBox_CourseID.Text);
            if(course.deleteCourse(courseId))
            {
                MessageBox.Show("Course delete succesfully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Course not found", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
