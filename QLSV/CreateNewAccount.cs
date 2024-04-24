using Microsoft.Office.Interop.Excel;
using QLSV.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class CreateNewAccount : Form
    {
        USER user = new USER();
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        bool IsValidName(string name)
        {
            // Kiểm tra xem chuỗi có chứa số không (không tính khoảng trắng)
            return !Regex.IsMatch(name, @"\d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidName(textBoxFname.Text) || !IsValidName(textBoxLName.Text))
                {
                    MessageBox.Show("Tên và họ không được chứa số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bool isPassword = false;
                int id = Convert.ToInt32(textBoxId.Text);
                string fname = textBoxFname.Text;
                string lname = textBoxLName.Text;
                string uname = textBoxUname.Text;
                string pword = textBoxPword.Text;
                string repassword = textBoxRePassword.Text;
                if(pword == repassword)
                {
                    isPassword = true;
                } 
                MemoryStream pic = new MemoryStream();
                pictureBoxAccount.Image.Save(pic, pictureBoxAccount.Image.RawFormat);
                if (verifieds() && isPassword == true)
                {
                    if (!user.usernameExist(uname, "register", id))
                    {
                        if (user.insertUser(id, fname, lname, uname, pword, pic))
                        {
                            MessageBox.Show("Registration Completed Successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something Wrong", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This UserName Already Exists", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" * Required Fields - username / password/ ....", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            } catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxAccount.Image = Image.FromFile(opf.FileName);
            }
        }


        public bool verifieds()
        {
            if ((textBoxId.Text.Trim() == "")
                || (textBoxFname.Text.Trim() == "")
                || (textBoxLName.Text.Trim() == "")
                || (textBoxUname.Text.Trim() == "")
                || (textBoxPword.Text.Trim() == "")
                || (pictureBoxAccount.Image == null)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
