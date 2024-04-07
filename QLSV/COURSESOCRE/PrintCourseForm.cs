using iTextSharp.text;
using iTextSharp.text.pdf;
using QLSV.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingFont = System.Drawing.Font;
using ITextSharpFont = iTextSharp.text.Font;

namespace QLSV.COURSESOCRE
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();


        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id CourseId, label CourseName, period Period, description as Description, Semester FROM CourseTable");
            fillGrid(command);

        }


        private void fillGrid(SqlCommand command)
        {
            dataGridView_Course.ReadOnly = true;
            dataGridView_Course.RowTemplate.Height = 40;
            dataGridView_Course.DataSource = course.getAllCourse(command);
            dataGridView_Course.AllowUserToAddRows = false;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\courselist.txt";
            using (var writer = new StreamWriter(path))
            {
                if(!File.Exists(path))// neu file chua ton tai duong dan
                {
                    File.Create(path);
                }
                //Dat ten cho cac cot 
                writer.WriteLine("Course ID\tCourse Name\t\tHours\t\t\tDescription");
                for(int i = 0; i < dataGridView_Course.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridView_Course.Columns.Count; j++)
                    {
                        if(j == dataGridView_Course.Columns.Count - 1) {
                            writer.Write(dataGridView_Course.Rows[i].Cells[j].Value.ToString().PadRight(20));
                            break;
                        }
                     
                        writer.Write(dataGridView_Course.Rows[i].Cells[j].Value.ToString().PadRight(20) + "|");
                    }
                    writer.WriteLine("");
                }
                writer.WriteLine(new String('-', 80));
                MessageBox.Show("Xem kết quả");
            }
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
           if(dataGridView_Course.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "courseList";

                if(saveFileDialog.ShowDialog() == DialogResult.OK) { 
                    try
                    {
                        using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter.GetInstance(document, fileStream);
                            document.Open();

                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100;

                            float[] columnWidth = { 1f, 3f };
                            table.SetWidths(columnWidth);

                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("D:\\LapTrinhWinDowns\\QLSV (1)\\QLSV\\QLSV\\images\\logo-hcmute-inkythuatso-17-13-52-06.jpg");
                            logo.ScaleAbsolute(100f, 100f);

                            PdfPCell imageCell = new PdfPCell(logo);
                            imageCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            table.AddCell(imageCell);

                            Paragraph title1 = new Paragraph();
                            ITextSharpFont font2 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 30f, ITextSharpFont.BOLD, BaseColor.RED);
                            title1.Add(new Phrase("Ho Chi Minh University of Technology and Education", font2));


                            PdfPCell textCell = new PdfPCell(title1);
                            textCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            textCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(textCell);

                            // Add spacing before and after
                            title1.SpacingBefore = 10f;
                            title1.SpacingAfter = 20;

                            document.Add(table);


                            ITextSharpFont font3 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 20f, ITextSharpFont.BOLD);
                            //Add title to the PDF document 
                            Paragraph title = new Paragraph("DANH SÁCH CAC KHOA HOC", font3);
                            title.Alignment = Element.ALIGN_CENTER;

                            //Thiet lap khoang cach le tren va le duoi
                            title.SpacingBefore = 20f;
                            title.SpacingAfter = 40f;

                            document.Add(title);

                            PdfPTable pTable = new PdfPTable(dataGridView_Course.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 80;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            float[] columnWidths = new float[dataGridView_Course.Columns.Count];
                            float equalWidth = 100f / dataGridView_Course.Columns.Count; // Calculate equal width for each column
                            for (int i = 0; i < dataGridView_Course.Columns.Count; i++)
                            {
                                columnWidths[i] = equalWidth; // Set equal width for each column
                            }
                            pTable.SetWidths(columnWidths);

                            ITextSharpFont font1 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 10, ITextSharpFont.BOLD, BaseColor.BLUE);
                            // Add column headers to the PDF table
                            foreach (DataGridViewColumn col in dataGridView_Course.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, font1));
                                pCell.BackgroundColor = new BaseColor(System.Drawing.Color.LightGray);
                                pCell.Padding = 5;
                                pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pTable.AddCell(pCell);
                            }

                            ITextSharpFont font11 = new ITextSharpFont(
                            BaseFont.CreateFont(@"C:\Users\ASUS\AppData\Local\Microsoft\Windows\Fonts\RobotoMono-VariableFont_wght.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED),
                           10f,
                         iTextSharp.text.Font.NORMAL,
                            BaseColor.BLACK
                            );
                            foreach (DataGridViewRow viewRow in dataGridView_Course.Rows)
                            {
                                foreach(DataGridViewCell cell in viewRow.Cells)
                                {
                                    PdfPCell contentCell = new PdfPCell(new Phrase(cell.Value?.ToString(),font11));
                                    contentCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    pTable.AddCell(contentCell);
                                }
                            }
                            document.Add(pTable);

                            //set Font
                            ITextSharpFont font = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 10f);
                            font.SetStyle(ITextSharpFont.NORMAL);

                            //Add title to the PDF document 
                            Paragraph ending = new Paragraph("Tp.HCM, day...month...year 2024", font);
                            ending.Alignment = Element.ALIGN_RIGHT;

                            //Thiet lap khoang cach le tren va le duoi
                            ending.SpacingBefore = 20f;

                            document.Add(ending);

                            ITextSharpFont font5 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 25f, ITextSharpFont.BOLDITALIC, BaseColor.RED);
                            Paragraph sign = new Paragraph("THOAI      ", font5);
                            sign.Alignment = Element.ALIGN_RIGHT;
                            sign.SpacingBefore = 15f;
                            document.Add(sign);

                            ITextSharpFont font4 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 20f, ITextSharpFont.BOLDITALIC, BaseColor.DARK_GRAY);
                            Paragraph hoTen = new Paragraph("Vuong Duc Thoai", font4);
                            hoTen.Alignment = Element.ALIGN_RIGHT;

                            hoTen.SpacingBefore = 15f;

                            document.Add(hoTen);

                            document.Close();
                        }
                        MessageBox.Show("Data Printed Successfully", "Info");
                    } catch(Exception ex)
                    {
                        MessageBox.Show("Error While Exporting Data: " + ex.Message, "Error");
                    }

                }

            }else
            {
                MessageBox.Show("No Record Found", "Info");
            }

        }
    }
}
