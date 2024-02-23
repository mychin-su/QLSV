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

namespace QLSV
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../images/user.png");
        }

        private void btt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            
            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE UserName = @User AND PassWord = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0) )
            {
                //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel_NewUser(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
