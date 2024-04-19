using QLSV.Human_Resource;
using QLSV.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Contact
{
    public partial class Add_Contact_Form : Form
    {
        public Add_Contact_Form()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();

        private void Add_Contact_Form_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = group.getGroup(GlobalIdUser.GlobalUserId);
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";
        }

        private void guna2ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxContact.Image = Image.FromFile(opf.FileName);
            }
        }

    

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Add_Contact_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string address = richTextBoxAddress.Text;
            string email = textBoxEmail.Text;
            int userid = GlobalIdUser.GlobalUserId;


            try
            {
                //get the group id 
                int groupid =  (Int32)comboBoxGroup.SelectedValue;

                //get the image 
                MemoryStream pic = new MemoryStream();

                pictureBoxContact.Image.Save(pic, pictureBoxContact.Image.RawFormat);

                if(!contact.checkId(id))
                {
                    if(contact.insertContact(id, fname, lname, phone,  address,  email, userid, groupid, pic))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("This ID Already Exits, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            //    MessageBox.Show("One Or More Fields Are Empty", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
