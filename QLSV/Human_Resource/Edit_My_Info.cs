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

namespace QLSV.Human_Resource
{
    public partial class Edit_My_Info : Form
    {
        public Edit_My_Info()
        {
            InitializeComponent();
        }

        USER user = new USER();

        private void Edit_My_Info_Load(object sender, EventArgs e)
        {

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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int UserId = int.Parse(textBoxId.Text);
                string fname = textBoxFname.Text;
                string lname = textBoxLName.Text;
                string uname = textBoxUname.Text;
                string pword = textBoxPword.Text;
                string rePword = textBoxRePassword.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxAccount.Image.Save(pic, pictureBoxAccount.Image.RawFormat);
                if (pword != rePword)
                {
                    MessageBox.Show("Password and re-entered password do not matchPassword and re-entered password do not match", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user.updateUser(UserId, fname, lname, uname, pword, pic))
                {
                    MessageBox.Show("User Editted successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found or update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
