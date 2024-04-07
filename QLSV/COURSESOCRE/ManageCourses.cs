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
    public partial class Button_Next : Form
    {
        public Button_Next()
        {
            InitializeComponent();
        }

        Course course = new Course();
        int pos;

        private void ManageCourses_Load(object sender, EventArgs e)
        {
            reloadListBoxData(0);
        }

        private void reloadListBoxData(int index)
        {
            ListBoxCourses.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            ListBoxCourses.ValueMember = "id";
            ListBoxCourses.DisplayMember = "label"; // hiển thị danh sách các label trong listBox
            ListBoxCourses.SelectedItem = null;
            LabelTotalCourses.Text = ("Total Courses: " + course.totalCourse());
            guna2ComboBox_Semester.SelectedIndex = index;
        }

        //dung lay data theo chi muc index, dung datarow de lay du lieu hang cua table
        private void showData(int index)
        {
            DataRow dr = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable")).Rows[index];

            ListBoxCourses.SelectedIndex = index;

            TextBoxID.Text = dr.ItemArray[0].ToString();

            TextBoxCourseName.Text = dr.ItemArray[1].ToString();

            NumericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());  
            
            richTextBoxDescription.Text = dr.ItemArray[3].ToString();

            guna2ComboBox_Semester.Text = dr.ItemArray[4].ToString();
        }

        private void ListBoxCourses_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListBoxCourses.SelectedItem;
            pos = ListBoxCourses.SelectedIndex; // gán position current hiện tại để showData
            showData(pos); 
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            int courseID = int.Parse(TextBoxID.Text);
            string name = TextBoxCourseName.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string desc = richTextBoxDescription.Text;
            string semester = guna2ComboBox_Semester.Text;

            if (name.Trim() == "")  // lam viec voi string xoa het cac khoang trang truoc sau chi lay ten
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (verif())
            {
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.checkCourseName(name) == false)
            {
                if (course.insertCourse(courseID, name, hrs, desc, semester))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int index = guna2ComboBox_Semester.SelectedIndex;
                    reloadListBoxData(index);

                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (hrs <= 10)
            {
                MessageBox.Show("Period must be greater 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("This Course Name Already Exits", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool verif()
        {
            if (TextBoxID.Text.Trim() == "" || TextBoxCourseName.Text == "" || NumericUpDownHours.Text == "" || richTextBoxDescription.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            string name = TextBoxCourseName.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string desc = richTextBoxDescription.Text;
            string semester = guna2ComboBox_Semester.Text;

            if(course.updateCourse(id, name, hrs, desc, semester))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int index = guna2ComboBox_Semester.SelectedIndex;
                reloadListBoxData(index);
            } else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }


        //button remove course bang id 
        private void Button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(TextBoxID.Text);

                if ((MessageBox.Show("Are You Sure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Cours Delete", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields 
                        TextBoxID.Text = "";
                        TextBoxCourseName.Text = "";
                        NumericUpDownHours.Value = 10;
                        richTextBoxDescription.Text = "";
                        reloadListBoxData(0);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            } catch
            {
                MessageBox.Show("Enter A Valid Numerix ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void Button_First_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void Bt_Next_Click(object sender, EventArgs e)
        {
            if(pos < (course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable")).Rows.Count - 1)){
                pos = pos + 1;
                showData(pos);
            }
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if(pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void Button_Last_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable")).Rows.Count - 1;
            showData(pos);
        }

        private void ListBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            ListBoxCourses.ValueMember = "label";
            DataRowView selectedRow = (DataRowView)ListBoxCourses.SelectedItem;
            int semester = Convert.ToInt32(selectedRow["Semester"]);
            string courseName = ListBoxCourses.SelectedValue.ToString();
            CourseStdList courseStdList = new CourseStdList(courseName, semester);
            courseStdList.Show(this);
        }
    }
}
