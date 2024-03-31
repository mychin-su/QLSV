using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSE
{
    public partial class EditCoureseForm : Form
    {
        public EditCoureseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();

        private void EditCoureseForm_Load(object sender, EventArgs e)
        {
            comboBox_SelectCourse.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            comboBox_SelectCourse.DisplayMember = "label";
            comboBox_SelectCourse.ValueMember = "id";
            comboBox_SelectCourse.SelectedItem = null;
        }

        public void fillCombo(int index)
        {
            comboBox_SelectCourse.DataSource = course.getAllCourse(new SqlCommand("SELECT * FROM CourseTable"));
            comboBox_SelectCourse.DisplayMember = "label";
            comboBox_SelectCourse.ValueMember = "id";
            comboBox_SelectCourse.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lable = textBox_Label.Text;
            int period = int.Parse(numericUpDown_Period.Value.ToString());
            string description = richTextBox_description.Text;
            int id = (int)comboBox_SelectCourse.SelectedValue;
            if(course.updateCourse(id, lable, period, description))
            {
                MessageBox.Show("Course updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Course not found or update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_SelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBox_SelectCourse.SelectedItem != null)
                {
                    //Lay du liệu
                    DataRowView selectedRow = (DataRowView)comboBox_SelectCourse.SelectedItem;
                    int id = Convert.ToInt32(selectedRow["id"]);
                    DataTable table = new DataTable();
                    table = course.getCourseById(id);
                    textBox_Label.Text = table.Rows[0]["label"].ToString();
                    numericUpDown_Period.Value = Convert.ToInt32(table.Rows[0]["period"]);
                    richTextBox_description.Text = table.Rows[0]["description"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
