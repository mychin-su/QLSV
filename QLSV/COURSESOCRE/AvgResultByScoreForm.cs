using iTextSharp.text.pdf;
using iTextSharp.text;
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
using DrawingFont = System.Drawing.Font;
using ITextSharpFont = iTextSharp.text.Font;

namespace QLSV.COURSESOCRE
{
    public partial class AvgResultByScoreForm : Form
    {
        public AvgResultByScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        private void AvgResultByScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView_result.DataSource = score.getStudentReslt();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string text = textBox_Search.Text;
            // Check if the text is not just whitespace
            if (!string.IsNullOrWhiteSpace(text))
            {
                dataGridView_result.DataSource = score.searchByIdFname(text.Trim());
            }
            else
            {
                dataGridView_result.DataSource = score.getStudentReslt();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            dataGridView_result.DataSource = score.getStudentReslt();
        }

        private void dataGridView_result_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_result.Rows[e.RowIndex];
                textBox_StudentID.Text = row.Cells["StudentId"].Value.ToString();
                textBox_FirstName.Text = row.Cells["FirstName"].Value.ToString();
                textBox_LastName.Text = row.Cells["LastName"].Value.ToString();
            }
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            if (dataGridView_result.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "StudentScore";
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
                            ITextSharpFont font2 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 30f, ITextSharpFont.BOLD, BaseColor.RED);
                            title1.Add(new Phrase("Ho Chi Minh University of Technology and Education", font2));
                            //  title1.Alignment = Element.ALIGN_LEFT;

                            // Add title paragraph to a cell and add the cell to the table
                            PdfPCell textCell = new PdfPCell(title1);
                            textCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            textCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(textCell);

                            // Add spacing before and after
                            title1.SpacingBefore = 10f;
                            title1.SpacingAfter = 20f;

                            // Add table to document
                            document.Add(table);


                            ITextSharpFont font3 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 20f, ITextSharpFont.BOLD);
                            //Add title to the PDF document 
                            Paragraph title = new Paragraph("DANH SÁCH DIEM SINH VIÊN", font3);
                            title.Alignment = Element.ALIGN_CENTER;

                            //Thiet lap khoang cach le tren va le duoi
                            title.SpacingBefore = 20f;
                            title.SpacingAfter = 20f;

                            document.Add(title);

                            ITextSharpFont font7 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 20f, ITextSharpFont.BOLD);
                            //Add title to the PDF document 
                           // Paragraph title2 = new Paragraph("DANG KI KHOA HOC " + courseName.ToUpper() + " HOC KI " + semester, font3);
                           // title2.Alignment = Element.ALIGN_CENTER;

                            //Thiet lap khoang cach le tren va le duoi
                          //  title2.SpacingAfter = 40f;

                         //   document.Add(title2);



                            PdfPTable pTable = new PdfPTable(dataGridView_result.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 80;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            float[] columnWidths = new float[dataGridView_result.Columns.Count];
                            float equalWidth = 100f / dataGridView_result.Columns.Count; // Calculate equal width for each column
                            for (int i = 0; i < dataGridView_result.Columns.Count; i++)
                            {
                                columnWidths[i] = equalWidth; // Set equal width for each column
                            }
                            pTable.SetWidths(columnWidths);

                            ITextSharpFont font1 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 10, ITextSharpFont.BOLD, BaseColor.BLUE);
                            // Add column headers to the PDF table
                            foreach (DataGridViewColumn col in dataGridView_result.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, font1));
                                pCell.BackgroundColor = new BaseColor(System.Drawing.Color.LightGray);
                                pCell.Padding = 5;
                                pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pTable.AddCell(pCell);
                            }


                            ITextSharpFont font10 = new ITextSharpFont(
                             BaseFont.CreateFont(@"C:\Users\ASUS\AppData\Local\Microsoft\Windows\Fonts\RobotoMono-VariableFont_wght.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED),
                            9f,
                            iTextSharp.text.Font.NORMAL,
                             BaseColor.BLACK
                             );
                            // Add rows and cells to the PDF table
                            foreach (DataGridViewRow viewRow in dataGridView_result.Rows)
                            {
                                foreach (DataGridViewCell cell in viewRow.Cells)
                                {
                                        PdfPCell contentCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font10));
                                        contentCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        pTable.AddCell(contentCell); // Handle other cells
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

                            ITextSharpFont font5 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 15f, ITextSharpFont.BOLDITALIC, BaseColor.RED);
                            Paragraph sign = new Paragraph("THOAI          ", font5);
                            sign.Alignment = Element.ALIGN_RIGHT;
                            sign.SpacingBefore = 7f;
                            document.Add(sign);

                            ITextSharpFont font4 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 15f, ITextSharpFont.BOLDITALIC, BaseColor.DARK_GRAY);
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
