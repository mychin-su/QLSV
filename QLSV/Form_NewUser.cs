    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Net.Mail;
    using System.Net;
    using System.Drawing.Text;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    namespace QLSV
    {
        public partial class Form_NewUser : Form
        {

            private int rowsAffected = 0;
            public string code_otp;
       
       
            public Form_NewUser()
            {
                InitializeComponent();

            }
     

            private void button_Register_Click(object sender, EventArgs e)
            {
               string userName = textBox_UserName.Text;
               string gmail = textBox_gmail.Text;
               string passWord = textBox_PassWord.Text;
                if (userName.Length == 0)
                {
                    MessageBox.Show("Bạn vui lòng nhập tên tài khoản");
                    return;
                }

                if(check_LengthUser(userName) == false)
                {
                    MessageBox.Show("Tên User tối đa có 6 kí tự!");
                    return;
                }

       
                if(passWord.Length == 0)
                {
                    MessageBox.Show("Bạn vui lòng nhập mật khẩu!");
                    return;
                }

                if(CheckPasswordValidity(passWord) == false) {
                    MessageBox.Show("Password bao gồm ít 1 kí tự đặc biệt, 1 kí tự số, 1 kí tự viết hoa, 1 kí tự viết thường và không được 2 kí tự liền kề giống nhau!!!");
                   return;
                }
                string confirmPassword = textBox_ConfirmPassWord.Text;
                if (confirmPassword.Length == 0)
                {
                    MessageBox.Show("Bạn vui lòng nhập mật khẩu nhập lại!");
                    return;
                }
                if (CheckUserNameExists(userName)){
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                    return;
                }

                if(passWord != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                    return;
                }

                // Kiểm tra xem truy vấn có thành công không
                OTP Otp = new OTP(this, userName, passWord, gmail);
                code_otp = Otp.GenarateOTP();
                SendOtpEmail(gmail, code_otp);
                Otp.Show();
            }



            public void AddUserAccount(string userName, string passWord, string gmail)
            {
                // Chuỗi kết nối tới cơ sở dữ liệu
                string connectionString = @"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";

                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo truy vấn SQL để kiểm tra tên người dùng
                        string query = "INSERT INTO log_in (UserName, PassWord, Email) VALUES  (@userName, @passWord, @gmail)";

                        // Tạo đối tượng SqlCommand để thực thi truy vấn
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm các tham số
                            command.Parameters.AddWithValue("@userName", userName);
                            command.Parameters.AddWithValue("@passWord", passWord);
                            command.Parameters.AddWithValue("@gmail", gmail);

                            rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                               // MessageBox.Show("Register add succseccfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else
                            {
                                MessageBox.Show("Register add uncuessfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có lỗi xảy ra
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }
            }

            // Di chuyển phương thức CheckUserNameExists vào trong lớp Form_NewUser
            private bool CheckUserNameExists(string userName)
            {
                bool exists = false; // Biến để lưu trạng thái kiểm tra

                // Chuỗi kết nối tới cơ sở dữ liệu
                string connectionString = @"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";

                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo truy vấn SQL để kiểm tra tên người dùng
                        string query = "SELECT COUNT(*) FROM log_in WHERE UserName = @userName";

                        // Tạo đối tượng SqlCommand để thực thi truy vấn
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số cho truy vấn
                            command.Parameters.AddWithValue("@userName", userName);

                            // Thực thi truy vấn và kiểm tra kết quả
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count > 0)
                            {
                                // Tên người dùng đã tồn tại trong cơ sở dữ liệu
                                exists = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có lỗi xảy ra
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }

                // Trả về kết quả kiểm tra
                return exists;
            }

            private bool check_LengthUser(String nameUser)
            {
                if(nameUser.Length >= 6)
                {
                    return true;
                }
                return false;
            }

            private bool CheckPasswordValidity(string password)
            {
                bool hasSpecial = false;
                bool hasDigit = false;
                bool hasLower = false;
                bool hasUpper = false;
                char previousChar = '\0'; // Sử dụng ký tự null để đảm bảo so sánh đầu tiên không bị sai

                foreach (char currentChar in password)
                {
                    // Kiểm tra xem có ký tự trùng lặp liên tiếp không
                    if (currentChar == previousChar)
                    {
                        return false;
                    }
                    previousChar = currentChar;

                    if (char.IsUpper(currentChar))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(currentChar))
                    {
                        hasLower = true;
                    }
                    else if (char.IsDigit(currentChar))
                    {
                        hasDigit = true;
                    }
                    else if (!char.IsLetterOrDigit(currentChar))
                    {
                        hasSpecial = true;
                    }
                }
                // Kiểm tra xem mật khẩu có đáp ứng tất cả các yêu cầu không
                return hasSpecial && hasDigit && hasLower && hasUpper;
            }

            private void SendOtpEmail(string recipientEmail, string otp)
            {
                string send_from = "thoai12309@gmail.com";
                string send_password = "kpkezuucdizxlcaq"; // Đảm bảo sử dụng mật khẩu đúng hoặc Mật khẩu ứng dụng
                MailMessage mail = new MailMessage();
                mail.To.Add(recipientEmail);
                mail.From = new MailAddress(send_from);
                mail.Subject = "Mã Xác Thực OTP";
                // Cải thiện nội dung email
                mail.Body = $"Mã OTP của bạn là: {otp}. Vui lòng sử dụng mã này để hoàn tất quá trình đăng ký.";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true; // Bật mã hóa SSL
                smtp.Port = 587; // Sử dụng cổng cho TLS/STARTTLS
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(send_from, send_password);

                try
                {
                    MessageBox.Show("Vui lòng xác thực mã OTP gửi tới gmail của bạn");
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi email: " + ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
