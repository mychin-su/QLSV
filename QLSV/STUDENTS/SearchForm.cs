using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{

    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginFormDbDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.loginFormDbDataSet1.student);
            dataGridView2.AllowUserToAddRows = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

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
