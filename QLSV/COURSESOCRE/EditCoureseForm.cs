using QLSV.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSV.COURSE
{
    public partial class EditCoureseForm : Form
    {
        public EditCoureseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();
        CONTACT contact = new CONTACT();

        private void EditCoureseForm_Load(object sender, EventArgs e)
        {
            this.comboBoxTeacher.DataSource = contact.getLastNameContact();
            this.comboBoxTeacher.DisplayMember = "LastName";
            this.comboBoxTeacher.ValueMember = "idContact";
            comboBox_SelectCourse.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            comboBox_SelectCourse.DisplayMember = "label"; // xác định trường dữ liệu nào sẽ hiện thị cho người dùng
            comboBox_SelectCourse.ValueMember = "id"; // Xác định trường dữ liệu nào sẽ được sử dụng như giá trị thực tế khi người dùng chọn.
            comboBox_SelectCourse.SelectedItem = null; // Đặt giá trị được chọn ban đầu ComboBox thành null. Điều này đảm bảo rằng không có mục nào được chọn mặc định khi ComboBox được hiển thị
            clearControls();
        }

        public void fillCombo(int index)
        {
            comboBox_SelectCourse.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            comboBox_SelectCourse.DisplayMember = "label";
            comboBox_SelectCourse.ValueMember = "id";
            comboBox_SelectCourse.SelectedIndex = index;
        }

        private void comboBox_SelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_SelectCourse.SelectedItem != null)
                {
                    //Lay du liệu
                    DataRowView selectedRow = (DataRowView)comboBox_SelectCourse.SelectedItem;
                    int id = Convert.ToInt32(selectedRow["id"]);
                    DataTable table = new DataTable();
                    table = course.getCourseById(id);
                    textBox_Label.Text = table.Rows[0]["label"].ToString();
                    numericUpDown_Period.Value = Convert.ToInt32(table.Rows[0]["period"]);
                    richTextBox_description.Text = table.Rows[0]["description"].ToString();
                    guna2ComboBox_Semester.Text = table.Rows[0]["Semester"].ToString();
                    comboBoxTeacher.Text = table.Rows[0]["idContact"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void clearControls()
        {
            textBox_Label.Text = "";
            numericUpDown_Period.Value = 10;
            richTextBox_description.Text = "";
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox_SelectCourse.SelectedValue;
            string name = textBox_Label.Text;
            int period = int.Parse(numericUpDown_Period.Value.ToString());
            string description = richTextBox_description.Text;
            string semester = guna2ComboBox_Semester.Text;
            int idContact = Convert.ToInt32(comboBoxTeacher.SelectedValue);

            if (course.updateCourse(id, name, period, description, semester, idContact))
            {
                int index = comboBox_SelectCourse.SelectedIndex;
                fillCombo(index);
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The course could not be updated. Please check your input and try again.", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
