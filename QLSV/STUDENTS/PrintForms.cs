using Guna.UI2.WinForms;
using QLSV.COURSESOCRE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.STUDENTS
{
    public partial class PrintForms : Form
    {
        Bitmap bmp;
        Score score = new Score();
        public PrintForms(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGridView_isPrint.DataSource = dataGrid.DataSource;

            try
            {
                // Add a new column named "SelectedCourse"
                DataGridViewTextBoxColumn selectedCourseColumn = new DataGridViewTextBoxColumn();
                selectedCourseColumn.Name = "SelectedCourse";
                selectedCourseColumn.HeaderText = "Selected Course";
                dataGridView_isPrint.Columns.Add(selectedCourseColumn);
                dataGridView_isPrint.Columns["SelectedCourse"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                foreach (DataGridViewRow row in dataGridView_isPrint.Rows)
                {
                    string stdId = row.Cells["StudentId"].Value?.ToString(); // Safely access cell value
                    if (!string.IsNullOrEmpty(stdId))
                    {
                        DataTable dataTable = score.getCourseBaseStudentIdRegister(stdId);
                        if (dataTable.Rows.Count > 0)
                        {
                            string courseName = "";
                            int rowCount = 0;
                            foreach (DataRow row1 in dataTable.Rows)
                            {
                                string courseLabel = row1["CourseName"].ToString();
                                courseName += courseLabel;
                                if (rowCount < dataTable.Rows.Count - 1)
                                {
                                    courseName += Environment.NewLine;
                                }
                                rowCount++;
                            }
                            row.Cells["SelectedCourse"].Value = courseName;
                        }
                    }
                }

                DataGridViewImageColumn picol = new DataGridViewImageColumn();
                picol = (DataGridViewImageColumn)dataGridView_isPrint.Columns["Picture"];
                picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picol.DefaultCellStyle.NullValue = null;
                dataGridView_isPrint.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int currentPage = 0; // Biến để theo dõi trang hiện tại
        int heightPrinted = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int remainingHeight = bmp.Height - heightPrinted;

            if (remainingHeight > e.MarginBounds.Height)
            {
                Rectangle sourceRect = new Rectangle(0, heightPrinted, bmp.Width, e.MarginBounds.Height);
                Rectangle destRect = new Rectangle(0, 0, e.MarginBounds.Width, e.MarginBounds.Height);

                // Vẽ phần của Bitmap lên trang
                e.Graphics.DrawImage(bmp, destRect, sourceRect, GraphicsUnit.Pixel);

                // Cập nhật chiều cao đã được in
                heightPrinted += e.MarginBounds.Height;

                // Yêu cầu in trang tiếp theo
                e.HasMorePages = true;
            }
            else
            {
                // In phần còn lại của Bitmap
                Rectangle sourceRect = new Rectangle(0, heightPrinted, bmp.Width, remainingHeight);
                Rectangle destRect = new Rectangle(0, 0, e.MarginBounds.Width, e.MarginBounds.Height);

                // Vẽ phần còn lại của Bitmap lên trang
                e.Graphics.DrawImage(bmp, destRect, sourceRect, GraphicsUnit.Pixel);

                // Không cần in thêm trang nữa
                e.HasMorePages = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int height = panel1.Height;
            int twppanel = height;
            int twpdtg = dataGridView_isPrint.Height;
            panel1.Height = height + 50 * dataGridView_isPrint.RowCount;
            dataGridView_isPrint.Height = dataGridView_isPrint.RowCount * 50;
            bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            printDocument1.DocumentName = "Print Document";
            printDialog1.Document = printDocument1;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                    MessageBox.Show("In Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("In Thất Bại Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                panel1.Height = twppanel;
                dataGridView_isPrint.Height = twpdtg;
            }
        }
    }
}
