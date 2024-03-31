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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{

    public partial class ForgetPassword : Form
    {
        private string codeOtp1;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private string GenarateOTP()
        {
            Random rd = new Random();
            string otp = rd.Next(0, 999999).ToString("D6");
            return otp;
        }

        private void button_SendCode_Click(object sender, EventArgs e)
        {

            string textMail = textBox_Gmail.Text;
            if (checkEmail(textMail))
            {
                Form_NewUser form = new Form_NewUser();
                codeOtp1 = GenarateOTP();
                form.SendOtpEmail(textMail, codeOtp1);
            } else
            {
                MessageBox.Show("Email chưa được đăng kí!", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private bool checkEmail(string email) { 


            int rowCounts = 0;
            try
            {
                // Sử dụng SqlParameter để tránh SQL Injection
                string query = "SELECT * FROM log_in WHERE Email = @email";
                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Thiết lập tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@email", email);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    con.Open();
                    adapter.Fill(table); // Điền dữ liệu vào table

                    rowCounts = table.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowCounts > 0;
        }

        private void button_VerifyCode_Click(object sender, EventArgs e)
        {
            string codeOtp = textBox_Code.Text;
            if (codeOtp.Equals(codeOtp1)){
                ChangePassWord changePassWord = new ChangePassWord(textBox_Gmail.Text);
                changePassWord.Show();
            } else
            {
                MessageBox.Show("Mã OTP không chính xác", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
