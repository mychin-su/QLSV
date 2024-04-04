using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLSV
{
    public partial class studentListForm : Form
    {
        public studentListForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void studentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginFormDbDataSet4.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.loginFormDbDataSet4.student);
            LoadData();

        }
        DataTable dt = new DataTable();
        // Helper method to get the index of the image column
        private int GetImageColumnIndex(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    return column.Index;
                }
            }
            return -1; // Return -1 if no image column is found
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public void LoadData()
        {
           

            mydb.openConnection();

            string query = "SELECT * FROM student";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            mydb.closeConnection();
                DataGridView1.Columns["bdate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            int imageColumnIndex = GetImageColumnIndex(DataGridView1);
            if (imageColumnIndex != -1)
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[imageColumnIndex];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageColumn.Width = 100; // Set width to desired value
                imageColumn.DefaultCellStyle.NullValue = null; // Prevents display of default image when cell value is null

            }
            DataGridView1.AllowUserToAddRows = false; // Ngan them hang moi tu UI 
            DataGridView1.ReadOnly = true;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];

                // Tạo một instance của form UpdateDeleteStudentForm
                UpdateDeleteStudentForm updateForm = new UpdateDeleteStudentForm();

                // Truyền dữ liệu vào form UpdateDeleteStudentForm
                updateForm.TextBoxId.Text = row.Cells[0].Value.ToString();
                updateForm.TextBoxFname.Text = row.Cells[1].Value.ToString();
                updateForm.TextBoxLname.Text = row.Cells[2].Value.ToString();
                updateForm.DateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);

                // Giới tính
                if (row.Cells[4].Value.ToString().ToLower() == "female")
                {
                    updateForm.RadioButtonFemale.Checked = true;
                }
                else
                {
                    updateForm.RadioButtonMale.Checked = true;
                }

                updateForm.TextBoxPhone.Text = row.Cells[5].Value.ToString();
                updateForm.TextBoxAddress.Text = row.Cells[6].Value.ToString();

                // Hiển thị hình ảnh
                if (row.Cells[7] != null && row.Cells[7].Value != DBNull.Value)
                {
                    byte[] pic = (byte[])row.Cells["picture"].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    updateForm.PictureBoxStudentImage.Image = Image.FromStream(picture);
                }

                // Hiển thị form UpdateDeleteStudentForm
                updateForm.ShowDialog();
            }
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Read lines from the selected file 
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    string[] values;

                    dt.Clear();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        values = lines[i].Split('|');
                        DataRow row = dt.NewRow();

                        for(int j = 0; j < values.Length; j++)
                        {
                            row[j] = values[j].Trim();
                        }
                        dt.Rows.Add(row);
                    }
                    MessageBox.Show("Data imported succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch(Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
        }
    }
}
