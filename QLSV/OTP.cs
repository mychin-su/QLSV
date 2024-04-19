    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace QLSV
    {
        public partial class OTP : Form
        {
            private Form_NewUser parentForm;
            private string userName;
            private string passWord;
            private string gmail;
            public OTP(Form_NewUser form, string userName, string passWord, string gmail)
            {
                InitializeComponent();
                this.parentForm = form;
                this.userName = userName;
                this.passWord = passWord;   
                this.gmail = gmail;
            }


            public string GenarateOTP()
            {
                Random rd = new Random();
                string otp = rd.Next(0, 999999).ToString("D6");
                return otp;
            }

            public void button1_Click(object sender, EventArgs e)
            {
                  Form_NewUser form = new Form_NewUser();
                   string code_otp = parentForm.code_otp;
                   string otp = textBox_OTP.Text;
            if (code_otp.Equals(otp))
            {
                form.AddUserAccount(userName, passWord, gmail);
                MessageBox.Show("User registered successfully");
                this.Close();
                parentForm.Hide();
                bool flag = true;
                Login_Form loginForm = new Login_Form();
                loginForm.Hide();   
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
    }