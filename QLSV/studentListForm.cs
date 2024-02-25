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

        STUDENT student = new STUDENT();

        private void studentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginFormDbDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.loginFormDbDataSet.student);
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            DataGridView1.ReadOnly = true;
            // Handle image column layout if it exists
            int imageColumnIndex = GetImageColumnIndex(DataGridView1);
            if (imageColumnIndex != -1)
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[imageColumnIndex];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageColumn.Width = 100; // Set width to desired value
                imageColumn.DefaultCellStyle.NullValue = null; // Prevents display of default image when cell value is null

            }
            DataGridView1.AllowUserToAddRows = false;
            foreach (DataGridViewColumn col in DataGridView1.Columns)
            {
                Console.WriteLine(col.Name);
            }
        }

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
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            DataGridView1.ReadOnly = true;
            // Handle image column layout if it exists
            int imageColumnIndex = GetImageColumnIndex(DataGridView1);
            if (imageColumnIndex != -1)
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[imageColumnIndex];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageColumn.Width = 100; // Set width to desired value
                imageColumn.DefaultCellStyle.NullValue = null; // Prevents display of default image when cell value is null

            }
            DataGridView1.AllowUserToAddRows = false;
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

    }
}
