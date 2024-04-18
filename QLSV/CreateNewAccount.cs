using QLSV.User;
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

namespace QLSV
{
    public partial class CreateNewAccount : Form
    {
        USER user = new USER();
        public CreateNewAccount()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string fname = textBoxFname.Text;
                string lname = textBoxLName.Text;
                string uname = textBoxUname.Text;
                string pword = textBoxPword.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxAccount.Image.Save(pic, pictureBoxAccount.Image.RawFormat);
                if (verifieds())
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
    }
}
