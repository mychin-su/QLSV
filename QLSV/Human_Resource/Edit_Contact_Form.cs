using QLSV.Human_Resource;
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

namespace QLSV.Contact
{
    public partial class Edit_Contact_Form : Form
    {
        public Edit_Contact_Form()
        {
            InitializeComponent();
        }
        GROUP group = new GROUP();
        CONTACT contact = new CONTACT();
        private void Edit_Contact_Form_Load(object sender, EventArgs e)
        {
           try
            {
                comboBoxGroup.DataSource = group.getGroup(GlobalIdUser.GlobalUserId);
                comboBoxGroup.DisplayMember = "name";
                comboBoxGroup.ValueMember = "id";
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

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

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            Select_Contact_Form SelectContactF = new Select_Contact_Form();
            SelectContactF.ShowDialog();

            try
            {
                if (SelectContactF.dataGridViewSelectContact.CurrentRow != null)
                {
                    int contactId = Convert.ToInt32(SelectContactF.dataGridViewSelectContact.CurrentRow.Cells[0].Value.ToString());
                    DataTable table = contact.GetContactById(contactId);

                    if (table != null && table.Rows.Count > 0)
                    {
                        textBoxId.Text = table.Rows[0]["id"].ToString();
                        textBoxFname.Text = table.Rows[0]["fname"].ToString();
                        textBoxLName.Text = table.Rows[0]["lname"].ToString();
                        comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                        textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                        textBoxEmail.Text = table.Rows[0]["email"].ToString();
                        richTextBoxAddress.Text = table.Rows[0]["address"].ToString();

                        if (table.Rows[0]["pic"] != DBNull.Value)
                        {
                            byte[] pic = (byte[])table.Rows[0]["pic"];
                            MemoryStream picture = new MemoryStream(pic);
                            pictureBoxContact.Image = Image.FromStream(picture);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
           

            try
            {
                int userId = GlobalIdUser.GlobalUserId;
                string fname = textBoxFname.Text;
                string lname = textBoxLName.Text;
                string phone = textBoxPhone.Text;
                string address = richTextBoxAddress.Text;
                string email = textBoxEmail.Text;
                int id = Convert.ToInt32(textBoxId.Text);

                int groupid = (int)comboBoxGroup.SelectedValue;

                MemoryStream pic = new MemoryStream();
                pictureBoxContact.Image.Save(pic, pictureBoxContact.Image.RawFormat);

                if (contact.updateContact(id, fname, lname, groupid, phone, email, address, pic,  userId))
                {
                    MessageBox.Show("Contact Inormation UpDated", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
