using QLSV.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class Manage_Student_Form : Form
    {
        MY_DB mydb = new MY_DB();

        STUDENT std = new STUDENT();
        Course course = new Course();

        public Manage_Student_Form()
        {
            InitializeComponent();
           // textBox_Search.TextChanged += textBox_Search_TextChanged;   
        }
       
        private void Manage_Student_Form_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM student"));
            fillComboBox(new SqlCommand("SELECT * FROM CourseTable"));
        }

        public void fillGrid(SqlCommand cmd)
        {
            dataGridView_Search.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView_Search.RowTemplate.Height = 80;
            dataGridView_Search.DataSource = std.getStudent(cmd);
            dataGridView_Search.Columns["bdate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            picol = (DataGridViewImageColumn)dataGridView_Search.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Search.AllowUserToAddRows = false;
            dataGridView_Search.ReadOnly = true;


            //Dem sinh vien 
            LabelStudentTotal.Text = ("Total Students: " + dataGridView_Search.Rows.Count);

        }

        public void fillComboBox(SqlCommand cmd)
        {
            ComboBoxCourse.DataSource = course.getAllCourse(cmd);
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedItem = null;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string strSearch = textBox_Search.Text.Trim(); // Trim to remove leading/trailing spaces
                if(strSearch == "")
                {
                    MessageBox.Show("Not found", "Vui lòng nhập TextBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE CONCAT(fname, lname, address) LIKE '%" + strSearch + "%'");
                fillGrid(cmd);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string strSearch = textBox_Search.Text.Trim(); 
                string query = "SELECT * FROM student WHERE fname LIKE @fname OR lname LIKE @lname OR address LIKE @address";

                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@fname", "%" + strSearch + "%");
                    command.Parameters.AddWithValue("@lname", "%" + strSearch + "%");
                    command.Parameters.AddWithValue("@address", "%" + strSearch + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table); 
                    dataGridView_Search.DataSource = table; 
                    dataGridView_Search.AllowUserToAddRows = false;
                    LabelStudentTotal.Text = ("Total Students: " + dataGridView_Search.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonDownloadImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtStudentID.Text);
            if((PictureBoxStudentImage.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            } else if((svf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView_Search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kiem tra xem cos hang naof duoc chon hay khong
            if(e.RowIndex >= 0)
            {
                //Lay hang duoc chon 
                DataGridViewRow row = dataGridView_Search.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells[0].Value.ToString();
                TextBoxFname.Text = row.Cells[1].Value.ToString();
                TextBoxLname.Text  = row.Cells[2].Value.ToString();      
                DateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);


                // Gioi tinh 
                if (row.Cells[4].Value.ToString().ToLower() == "female"){
                    RadioButtonFemale.Checked = true;
                } else
                {
                    RadioButtonMale.Checked = true;
                }
                TextBoxPhone.Text = row.Cells[5].Value.ToString();  
                TextBoxAddress.Text = row.Cells[6].Value.ToString();

                //Hien thi hinh anh 
                if (row.Cells[7] != null && row.Cells[7].Value != DBNull.Value)
                {
                    byte[] pic = (byte[])row.Cells[7].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);
                } else
                {
                    PictureBoxStudentImage.Image = null; 
                }


                //Hien thi Course Name
                string courseName = dataGridView_Search.Rows[e.RowIndex].Cells[8].Value.ToString();

                foreach (var item in ComboBoxCourse.Items)
                {
                    Console.WriteLine("Item in ComboBox: " + item.ToString());
                    Console.WriteLine("CourseName from DataGridView: " + courseName);
                    if (item.ToString() == courseName)
                    {
                        Console.WriteLine("Match found!");
                        ComboBoxCourse.SelectedItem = item;
                        break;
                    }
                }
            }
        }



        private bool CheckUserIdxists(string ID)
        {
            bool exists = false; // Biến để lưu trạng thái kiểm tra

            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = @"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo truy vấn SQL để kiểm tra tên người dùng
                    string query = "SELECT COUNT(*) FROM student WHERE id = @id";

                    // Tạo đối tượng SqlCommand để thực thi truy vấn
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int id;
                        if (int.TryParse(ID, out id))
                        {
                            command.Parameters.AddWithValue("@id", id);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@id", DBNull.Value); // or null, depending on column definition
                        }

                        // Thực thi truy vấn và kiểm tra kết quả
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            // Tên người dùng đã tồn tại trong cơ sở dữ liệu
                            exists = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            // Trả về kết quả kiểm tra
            return exists;
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {

            if (CheckUserIdxists(txtStudentID.Text) == false)
            {
                STUDENT student = new STUDENT();
                int id = Convert.ToInt32(txtStudentID.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxLname.Text;
                DateTime bdate = DateTimePicker1.Value;
                string phone = TextBoxPhone.Text;
                string adrs = TextBoxAddress.Text;
                string gender = "Male";
                string courseName = ComboBoxCourse.Text;

                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                //  sv tu 10-100,  co the thay doi
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic, courseName))
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM student"));
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Student ID already exists ", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                        || (TextBoxLname.Text.Trim() == "")
                        || (TextBoxAddress.Text.Trim() == "")
                        || (TextBoxPhone.Text.Trim() == "")
                        || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            if (CheckUserIdxists(txtStudentID.Text) == true)
            {
                int studentId = int.Parse(txtStudentID.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxLname.Text;
                DateTime bdate = DateTimePicker1.Value;
                string gender = RadioButtonFemale.Checked ? "Female" : "Male";
                string phone = TextBoxPhone.Text;
                string address = TextBoxAddress.Text;
                byte[] picture = null;
                string courseName = ComboBoxCourse.Text;

                if (PictureBoxStudentImage.Image != null)
                {
                    picture = ConvertImageToByteArray(PictureBoxStudentImage.Image);
                }
                    if (std.updateStudent(studentId, fname, lname, bdate, gender, phone, address, picture, courseName))
                {
                    MessageBox.Show("Student updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM student"));
                } else
                {
                    MessageBox.Show("Student not found or update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtStudentID.Text);
            if (std.deleteStudent(id))
            {
                MessageBox.Show("Student deleted successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillGrid(new SqlCommand("SELECT * FROM student"));
                // Clear input fields after successful deletion
                ClearControls();
                // Optional: Clear form or perform other actions after deletion.
               
            } else
            {
                MessageBox.Show("Student not found", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtStudentID.Text = "";
            TextBoxFname.Text = "";
            TextBoxLname.Text = "";
            DateTimePicker1.Value = DateTime.Now;
            RadioButtonFemale.Checked = false;
            RadioButtonMale.Checked = false;
            TextBoxPhone.Text = "";
            TextBoxAddress.Text = "";
            PictureBoxStudentImage.Image = null;
            ComboBoxCourse.SelectedItem = null;
        }
        
    }
}
