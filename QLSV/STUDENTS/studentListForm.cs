using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Globalization;

namespace QLSV
{
    public partial class studentListForm : Form
    {
        public studentListForm()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataReader dr;
        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        private void studentListForm_Load(object sender, EventArgs e)
        {
           
            LoadData();
        }
        System.Data.DataTable dt = new System.Data.DataTable();

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
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY student.lname) as STT ,id StudentId, fname FirstName, lname LastName, bdate BirthDate, email as Email, gender Gender, phone as Phone, address as Address, picture as Picture FROM student";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            mydb.closeConnection();
            DataGridView1.Columns["BirthDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
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
                updateForm.TextBoxId.Text = row.Cells["StudentId"].Value.ToString();
                updateForm.TextBoxFname.Text = row.Cells["FirstName"].Value.ToString();
                updateForm.TextBoxLname.Text = row.Cells["LastName"].Value.ToString();
                try
                {
                    updateForm.DateTimePicker1.Value = DateTime.ParseExact(row.Cells["BirthDate"].Value.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                }
                catch (FormatException ex)
                {
                    // Handle the case where the date string is not in the expected format
                    MessageBox.Show("Error: Invalid date format for BirthDate: " + row.Cells["BirthDate"].Value.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to set a default value or take other appropriate action here
                }

                updateForm.textBox_email.Text = row.Cells["Email"].Value.ToString();

                // Giới tính
                if (row.Cells["Gender"].Value.ToString().ToLower() == "female")
                {
                    updateForm.RadioButtonFemale.Checked = true;
                }
                else
                {
                    updateForm.RadioButtonMale.Checked = true;
                }

                updateForm.TextBoxPhone.Text = row.Cells["Phone"].Value.ToString();
                updateForm.TextBoxAddress.Text = row.Cells["Address"].Value.ToString();

                // Hiển thị hình ảnh
                if (row.Cells["Picture"].Value != DBNull.Value && row.Cells["Picture"].Value != null)
                {
                    byte[] pic = (byte[])row.Cells["Picture"].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    updateForm.PictureBoxStudentImage.Image = Image.FromStream(picture);
                }


                // Hiển thị form UpdateDeleteStudentForm
                updateForm.ShowDialog();
            }
        }
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Workbook xlWorkbook = null;
            Worksheet xlWorksheet = null;
            Range xlRange = null;

            string strFilename;
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            openFD.ShowDialog();
            strFilename = openFD.FileName;

            if (strFilename != "")
            {
                try
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strFilename);
                    xlWorksheet = xlWorkbook.Worksheets[1]; // Assuming the first sheet, change if needed
                    xlRange = xlWorksheet.UsedRange;

                    // Create a DataTable to hold the imported data
                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    // Add columns to the DataTable
                    dataTable.Columns.Add("STT");
                    dataTable.Columns.Add("StudentID");
                    dataTable.Columns.Add("FirstName");
                    dataTable.Columns.Add("LastName");
                    dataTable.Columns.Add("BirthDate", typeof(DateTime)); // Specify the data type for the BirthDate column
                    dataTable.Columns.Add("Email");
                    dataTable.Columns.Add("Gender");
                    dataTable.Columns.Add("Phone");
                    dataTable.Columns.Add("Address");
                    dataTable.Columns.Add("Picture", typeof(byte[])); // Specify the data type for the Picture column

                    // Loop through Excel data and populate DataTable
                    for (int row = 2; row <= xlRange.Rows.Count; row++)
                    {
                        DataRow newRow = dataTable.NewRow();
                        for (int col = 1; col <= 8; col++) // Assuming 8 columns in Excel file
                        {
                            if (col == 5) // Handling BirthDate column
                            {
                                string dateFormat = "dd/MM/yyyy";
                                DateTime dateValue = DateTime.MinValue;
                                if (xlRange.Cells[row, col].Value != null && DateTime.TryParseExact(xlRange.Cells[row, col].Value.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                                {
                                    newRow[col - 1] = dateValue; // Assign DateTime value directly
                                }
                            } else if(col == 6)
                            {
                                string studentId = xlRange.Cells[row, 2].Value != null ? xlRange.Cells[row, 2].Value.ToString() : "";
                                newRow[col - 1] = studentId + "@student.hcmute.edu.vn";
                            }
                            else if (col == 10) // Handling Picture column
                            {
                                // You need to handle the image data here.
                                // If the Excel contains paths to image files, load the images and convert them to byte arrays.
                                // If the Excel contains byte array data for images, convert them accordingly.
                                // For now, let's assume the Picture column contains null values.
                                newRow[col - 1] = DBNull.Value;
                            }
                            else
                            {
                                newRow[col - 1] = xlRange.Cells[row, col].Value != null ? xlRange.Cells[row, col].Value.ToString() : "";
                            }
                        }
                        dataTable.Rows.Add(newRow);
                    }

                    // Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if(DataGridView1.Rows.Count > 0)
                    {
                        foreach (DataRow row in ((System.Data.DataTable)DataGridView1.DataSource).Rows)
                        {
                            using (MemoryStream pic = new MemoryStream())
                            {
                                // Load picture data into MemoryStream
                                byte[] imageData = null;
                                if (row["Picture"] != DBNull.Value)
                                {
                                    imageData = (byte[])row["Picture"];
                                    pic.Write(imageData, 0, imageData.Length);
                                }

                                // Reset the position of the MemoryStream to the beginning
                                pic.Seek(0, SeekOrigin.Begin);

                                // Insert command
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO student (id, fname, lname, bdate, email, gender, phone, address)" +
                                                                        "VALUES (@id, @fname, @lname, @bdate, @email, @gender, @phone, @address)", connection))
                                {
                                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(row["StudentID"]));
                                    cmd.Parameters.AddWithValue("@fname", row["FirstName"].ToString());
                                    cmd.Parameters.AddWithValue("@lname", row["LastName"].ToString());
                                    if (row["BirthDate"] != DBNull.Value)
                                    {
                                        cmd.Parameters.AddWithValue("@bdate", row["BirthDate"]);
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@bdate", DBNull.Value);
                                    }

                                    cmd.Parameters.AddWithValue("@email", row["Email"].ToString());
                                    cmd.Parameters.AddWithValue("@gender", row["Gender"].ToString());
                                    cmd.Parameters.AddWithValue("@phone", row["Phone"].ToString());
                                    cmd.Parameters.AddWithValue("@address", row["Address"].ToString());
                                    if (imageData != null)
                                    {
                                        cmd.Parameters.Add("@picture", SqlDbType.VarBinary, -1).Value = pic.ToArray();
                                    }
                                    else
                                    {
                                        // If imageData is null, set picture parameter value to DBNull
                                        cmd.Parameters.AddWithValue("@picture", DBNull.Value);
                                    }

                                    // Execute the command
                                    cmd.ExecuteNonQuery();
                                   
                                }
                            }
                        }
                        MessageBox.Show("Save Successfully", "SaveDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("No data to Save database" , "Save Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                  
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SaveDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}