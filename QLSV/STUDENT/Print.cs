using iTextSharp.text;
using iTextSharp.text.pdf;
using QLSV.COURSESOCRE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingFont = System.Drawing.Font;
using ITextSharpFont = iTextSharp.text.Font;



namespace QLSV
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        Score score = new Score();

        private void Print_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY student.lname ASC) as STT, student.id as StudentId, student.fname as FirstName, student.lname as LastName, student.bdate as BirthDate, student.gender as Gender, student.phone as Phone, student.address as Address, student.picture as Picture FROM student");
            fillGrid(command);

            //dieu khien cac radioButton chuyen trang thai 
            if(radioNo.Checked) // hard code
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        public void fillGrid(SqlCommand cmd)
        {
            dataGridView_Print.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView_Print.RowTemplate.Height = 80;
            dataGridView_Print.DataSource = student.getStudent(cmd);
            if (dataGridView_Print.Columns.Contains("BirthDate"))
            {
                dataGridView_Print.Columns["BirthDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            picol = (DataGridViewImageColumn)dataGridView_Print.Columns[8];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Print.AllowUserToAddRows = false;

            //Thêm cột mới "SelectedCourse" 
            DataGridViewTextBoxColumn selectedCourseColumn = new DataGridViewTextBoxColumn();
            selectedCourseColumn.Name = "SelectedCourse";
            selectedCourseColumn.HeaderText = "Selected Course";
            dataGridView_Print.Columns.Add(selectedCourseColumn);
            dataGridView_Print.Columns["SelectedCourse"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (DataGridViewRow row in dataGridView_Print.Rows)
            {
                string stdId = row.Cells["StudentId"].Value.ToString();
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

        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;
            if(radioYes.Checked == true) // Neu theo Date 
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioMale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Male' AND bdate BETWEEN '" + date1 + " 'AND'" + date2 + "'";
                } else if (radioFemale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Female' AND bdate BETWEEN '" + date1 + " 'AND'" + date2 + "'";
                } else
                {
                    query = "SELECT * FROM student WHERE bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }

               
            } else // Neu khong can theo Date 
            {
                if (radioMale.Checked)
                {
                    query = "SELECT  * FROM student WHERE gender = 'Male'";
                } else if (radioFemale.Checked)
                {
                    query = "SELECT * FROM student WHERE gender = 'Female'";
                } else
                {
                    query = "SELECT * FROM student";  //Chon All
                }
            }
            command = new SqlCommand(query);
            fillGrid(command);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\student_list.txt";
            using(var writer = new StreamWriter(path))
            {
                if (!File.Exists(path)) // nếu file chưa tồn tại đường dẫn 
                {
                    File.Create(path); // tạo đường dẫn 
                }
                DateTime bdate;
                for(int i = 0; i < dataGridView_Print.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridView_Print.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView_Print.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" +"|");
                        } else if(j == dataGridView_Print.ColumnCount - 2)
                        {
                            writer.Write("\t" + dataGridView_Print.Rows[i].Cells[j].Value.ToString());
                        } else
                        {
                            writer.Write("\t" + dataGridView_Print.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                   // writer.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Xem kết quả");
            }
        }

        private void buttonPrinter_Click(object sender, EventArgs e)
        {
            if (dataGridView_Print.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "studentList";
                bool errorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter.GetInstance(document, fileStream);
                            document.Open();



                            // Create a table with 2 columns
                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100;

                            float[] columnWidth = { 1f, 3f };
                            table.SetWidths(columnWidth);

                            // Create an image object
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("D:\\LapTrinhWinDowns\\QLSV (1)\\QLSV\\QLSV\\images\\logo-hcmute-inkythuatso-17-13-52-06.jpg");
                            logo.ScaleAbsolute(100f, 100f);

                            // Add image to a cell and add the cell to the table
                            PdfPCell imageCell = new PdfPCell(logo);
                            imageCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            table.AddCell(imageCell);

                            // Create a paragraph for the title
                            Paragraph title1 = new Paragraph();
                            ITextSharpFont font2 = new ITextSharpFont(
                                 BaseFont.CreateFont(@"C:\Users\ASUS\AppData\Local\Microsoft\Windows\Fonts\RobotoMono-VariableFont_wght.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED),
                                25f,
                                iTextSharp.text.Font.BOLD,
                                BaseColor.RED
                            );
                            title1.Add(new Phrase("HO CHI MINH UNIVERSITY OF TECHNOLOGY AND EDUCATION", font2));
                          //  title1.Alignment = Element.ALIGN_LEFT;

                            // Add title paragraph to a cell and add the cell to the table
                            PdfPCell textCell = new PdfPCell(title1);
                            textCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            textCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(textCell);

                            // Add spacing before and after
                            title1.SpacingBefore = 10f;
                            title1.SpacingAfter = 20;

                            // Add table to document
                            document.Add(table);


                            ITextSharpFont font3 = new ITextSharpFont(
                         BaseFont.CreateFont(@"C:\Users\ASUS\AppData\Local\Microsoft\Windows\Fonts\RobotoMono-VariableFont_wght.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED),
                             20f,
                             iTextSharp.text.Font.BOLD,
                         BaseColor.BLACK
                         );
                            //Add title to the PDF document 
                            Paragraph title = new Paragraph("DANH SÁCH SINH VIÊN MÔN LẬP TRÌNH WINDOWS", font3);
                            title.Alignment = Element.ALIGN_CENTER;
                          
                            //Thiet lap khoang cach le tren va le duoi
                            title.SpacingBefore = 20f;
                            title.SpacingAfter = 40f;

                            document.Add(title);

                            PdfPTable pTable = new PdfPTable(dataGridView_Print.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            float[] columnWidths = new float[dataGridView_Print.Columns.Count];
                            float equalWidth = 100f / dataGridView_Print.Columns.Count; // Calculate equal width for each column
                            for (int i = 0; i < dataGridView_Print.Columns.Count; i++)
                            {
                                columnWidths[i] = equalWidth; // Set equal width for each column
                            }
                            pTable.SetWidths(columnWidths);

                            ITextSharpFont  font1 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 9f, ITextSharpFont.BOLD, BaseColor.BLUE);
                            // Add column headers to the PDF table
                            foreach (DataGridViewColumn col in dataGridView_Print.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, font1));
                                pCell.BackgroundColor = new BaseColor(System.Drawing.Color.LightGray);
                                pCell.Padding = 5; 
                                pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pTable.AddCell(pCell);
                            }

                            //set Font
                            ITextSharpFont font = new ITextSharpFont(
                             BaseFont.CreateFont(@"C:\Users\ASUS\AppData\Local\Microsoft\Windows\Fonts\RobotoMono-VariableFont_wght.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED),
                            8f,
                          iTextSharp.text.Font.NORMAL,
                             BaseColor.BLACK
                             );

                            // Add rows and cells to the PDF table
                            foreach (DataGridViewRow viewRow in dataGridView_Print.Rows)
                            {
                                foreach (DataGridViewCell cell in viewRow.Cells)
                                {
                                    if (cell.ColumnIndex == dataGridView_Print.Columns.Count - 2) // Check if last column
                                    {
                                        // Handle image cell
                                        if (cell.Value!= DBNull.Value&&cell.Value != null)
                                        {
                                            // Convert image to iTextSharp Image
                                            byte[] imageData = (byte[])cell.Value;
                                            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageData);
                                            pTable.AddCell(image);
                                        }
                                        else
                                        {
                                            pTable.AddCell(""); // Add empty cell if image is null
                                        }
                                    }
                                    else if (cell.ColumnIndex == 4)
                                    {
                                        PdfPCell contentCell = new PdfPCell(new Phrase(((DateTime)cell.Value).ToString("dd-MM-yyyy"), font));
                                        pTable.AddCell(contentCell);
                                    }
                                    else
                                    {
                                        PdfPCell contentCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                                        contentCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        pTable.AddCell(contentCell); // Handle other cells
                                    }
                                }
                            }

                            document.Add(pTable);

                          

                            //Add title to the PDF document 
                            Paragraph ending = new Paragraph("Tp.HCM, day...month...year 2024", font);
                            ending.Alignment = Element.ALIGN_RIGHT;

                            //Thiet lap khoang cach le tren va le duoi
                            ending.SpacingBefore = 20f;

                            document.Add(ending);

                            ITextSharpFont font5 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 15f, ITextSharpFont.BOLDITALIC, BaseColor.RED);
                            Paragraph sign = new Paragraph("THOAI          ", font5);
                            sign.Alignment = Element.ALIGN_RIGHT;
                            sign.SpacingBefore = 7f;
                            document.Add(sign);

                            ITextSharpFont font4 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA,15f, ITextSharpFont.BOLDITALIC, BaseColor.DARK_GRAY);
                            Paragraph hoTen = new Paragraph("Vuong Duc Thoai", font4);
                            hoTen.Alignment = Element.ALIGN_RIGHT;

                            document.Add(hoTen);

                            document.Close();
                        }
                        MessageBox.Show("Data Printed Successfully", "Info");
                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Error While Exporting Data: " + ex.Message, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
