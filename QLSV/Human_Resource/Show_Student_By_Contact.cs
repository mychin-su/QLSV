using QLSV.COURSE;
using QLSV.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Human_Resource
{
    public partial class Show_Student_By_Contact : Form
    {
        private int idContact;

        public Show_Student_By_Contact(int idContact)
        {
            InitializeComponent();
            this.idContact = idContact;
        }

        CONTACT contact = new CONTACT();
        Course course = new Course();

        private void Show_Student_By_Contact_Load(object sender, EventArgs e)
        {
            listBoxCourse.DataSource = contact.getCourseByContact(idContact);
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.ValueMember = "label";
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = course.getCourseStudentRegister(listBoxCourse.SelectedValue.ToString());
        }
    }
}
