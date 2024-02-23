using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        // Initialize student object
        private STUDENT student = new STUDENT();

        // Initialize dataset object
        private LoginFormDbDataSet loginFormDbDataSet = new LoginFormDbDataSet();

        // Declare studentTableAdapter with the correct type
        private LoginFormDbDataSetTableAdapters.studentTableAdapter studentTableAdapter;

        // Declare DataGridView1 as a DataGridView control
        public DataGridView DataGridView1 { get; private set; }

        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
            this.TextBoxId.KeyPress += new KeyPressEventHandler(TextBoxID_KeyPress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBoxId.Text);
                // Sử dụng SqlParameter để tránh SQL Injection
                string query = "SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE id = @id";
                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Thiết lập tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    con.Open();
                    adapter.Fill(table); // Điền dữ liệu vào table

                    if (table.Rows.Count > 0)
                    {
                        TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                        TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                        DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                        if (table.Rows[0]["gender"].ToString() == "Female")
                        {
                            RadioButtonFemale.Checked = true;
                        }
                        else
                        {
                            RadioButtonMale.Checked = true;
                        }
                        TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                        TextBoxAddress.Text = table.Rows[0]["address"].ToString();
                        if (table.Rows[0]["picture"] != DBNull.Value)
                        {
                            byte[] pic = (byte[])table.Rows[0]["picture"];
                            MemoryStream picture = new MemoryStream(pic);
                            PictureBoxStudentImage.Image = Image.FromStream(picture);
                        }
                        else
                        {
                            PictureBoxStudentImage.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
