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

namespace QLSV
{
    public partial class Form_NewUser : Form
    {
        public Form_NewUser()
        {
            InitializeComponent();
        }

        MY_DB MY_DB = new MY_DB();

        private void button_Register_Click(object sender, EventArgs e)
        {
            String userName = textBox_UserName.Text;
            if(userName.Length == 0)
            {
                MessageBox.Show("Bạn vui lòng nhập tên tài khoản");
                return;
            }

            if(check_LengthUser(userName) == false)
            {
                MessageBox.Show("Tên User tối đa có 6 kí tự!");
                return;
            }

            String passWord = textBox_PassWord.Text;
            if(passWord.Length == 0)
            {
                MessageBox.Show("Bạn vui lòng nhập mật khẩu!");
                return;
            }

            if(CheckPasswordValidity(passWord) == false) {
                MessageBox.Show("Password bao gồm ít 1 kí tự đặc biệt, 1 kí tự số, 1 kí tự viết hoa, 1 kí tự viết thường và không được 2 kí tự liền kề giống nhau!!!");
                return;
            }
            String confirmPassword = textBox_ConfirmPassWord.Text;
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
                    string query = "INSERT INTO log_in (UserName, PassWord) VALUES  (@userName, @passWord)";

                    // Tạo đối tượng SqlCommand để thực thi truy vấn
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@passWord", passWord);

                        // Thực thi truy vấn INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem truy vấn có thành công không
                        if (rowsAffected > 0)
                        {
                            // Thành công
                            MessageBox.Show("Người dùng đã được đăng ký thành công!");
                        }
                        else
                        {
                            // Không có bản ghi nào được thêm vào cơ sở dữ liệu
                            MessageBox.Show("Đăng ký người dùng không thành công!");
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

    }
}
