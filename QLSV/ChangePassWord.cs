using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class ChangePassWord : Form
    {
        private string email;
        public ChangePassWord(string email)
        {
            InitializeComponent();
            this.email = email; 
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text.Equals(textBox_RePassword.Text)){
                try
                {
                    string query = "UPDATE log_in SET PassWord = @password WHERE Email = @email";
                    using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@password", textBox_Password.Text);
                        command.Parameters.AddWithValue("@email", email);
                        con.Open();
                        int result = command.ExecuteNonQuery(); // Executes update and returns number of affected rows

                        if (result > 0)
                        {
                            MessageBox.Show("Account updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Acco not found or update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
            }
           
        }
    }
}
