using Org.BouncyCastle.Asn1.Eac;
using QLSV.Contact;
using QLSV.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Human_Resource
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();  
        GROUP group = new GROUP();
        CONTACT contact = new CONTACT();

        private void Main_Form_Load(object sender, EventArgs e)
        {
            getImageAndUserName();
            comboBoxEdit.DataSource = group.getGroup(GlobalIdUser.GlobalUserId);
            comboBoxEdit.DisplayMember = "name";
            comboBoxEdit.ValueMember = "id";
            comboBoxRemove.DataSource = group.getGroup(GlobalIdUser.GlobalUserId);
            comboBoxRemove.DisplayMember = "name";
            comboBoxRemove.ValueMember = "id";
        }


        public void getImageAndUserName()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GlobalIdUser.GlobalUserId; // lay id de up thong tin 
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if(table.Rows.Count > 0 )
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

                labelUserName.Text = "( " + (table.Rows[0]["uname"]).ToString() + " )";
                labelFirstName.Text = table.Rows[0]["f_name"].ToString() + table.Rows[0]["l_name"].ToString();
            }
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login_Form login_Form = new Login_Form();   
            login_Form.ShowDialog();
        }

        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Edit_My_Info edit_My_Info = new Edit_My_Info();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE id = @uid", mydb.getConnection);
                command.Parameters.Add("@uid", SqlDbType.Int).Value = GlobalIdUser.GlobalUserId; // lay id de up thong tin 
                adapter.SelectCommand = command;
                adapter.Fill(table);

                edit_My_Info.textBoxId.Text = table.Rows[0]["Id"].ToString();
                edit_My_Info.textBoxFname.Text = table.Rows[0]["f_name"].ToString();
                edit_My_Info.textBoxLName.Text = table.Rows[0]["l_name"].ToString();
                edit_My_Info.textBoxUname.Text = table.Rows[0]["uname"].ToString();
                edit_My_Info.textBoxPword.Text = table.Rows[0]["pwd"].ToString();
                edit_My_Info.textBoxRePassword.Text = table.Rows[0]["pwd"].ToString();
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                edit_My_Info.pictureBoxAccount.Image = Image.FromStream(picture);
                edit_My_Info.Show();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "linkEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ButtonAddGroup_Click(object sender, EventArgs e)
        {
            try {

                string groupName = textBoxGroupName.Text;
                int groupId = Convert.ToInt32(textBoxIdGroup.Text);
                int userId = GlobalIdUser.GlobalUserId;
                if (!group.groupExits(groupName, "add", userId, groupId))
                {
                    if (group.insertGroup(groupId, groupName, userId))
                    {
                        MessageBox.Show("Add Group Successfully", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Add Group Failed", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("GroupId or GroupName isAlready", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getImageAndUserName();
            comboBoxEdit.DataSource = group.getGroup(GlobalIdUser.GlobalUserId);
            comboBoxEdit.DisplayMember = "name";
            comboBoxEdit.ValueMember = "id";
            comboBoxRemove.DataSource = group.getGroup(GlobalIdUser.GlobalUserId);
            comboBoxRemove.DisplayMember = "name";
            comboBoxRemove.ValueMember = "id";
        }

        private void ButtonEditGroup_Click(object sender, EventArgs e)
        {
           try
            {
                int groupId = Convert.ToInt32(comboBoxEdit.SelectedValue);
                string newGroupName = textBoxNewGroupName.Text;
                if (!group.groupExits(newGroupName, "edit", GlobalIdUser.GlobalUserId, groupId))
                {
                    if (group.updateGroup(groupId, newGroupName))
                    {
                        MessageBox.Show("Edit Group New Name Successfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Edit Group New Name Failed", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Edit Group Name Is Alreasy", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemoveGroup_Click(object sender, EventArgs e)
        {
          try
            {
                int groupId = Convert.ToInt32(comboBoxRemove.SelectedValue);
                if (group.deleteGroup(groupId))
                {
                    comboBoxRemove.Items.Remove(groupId);
                    MessageBox.Show("Group Remove Successfully", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Group Remove Failed", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonAddContact_Click(object sender, EventArgs e)
        {
            Add_Contact_Form add_Contact_Form = new Add_Contact_Form();
            add_Contact_Form.Show();
        }

        private void ButtonEditContact_Click(object sender, EventArgs e)
        {
            Edit_Contact_Form edit_Contact_Form = new Edit_Contact_Form();
            edit_Contact_Form.Show();
        }

        private void ButtonSelectContact_Click(object sender, EventArgs e)
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
                        }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemoveContact_Click(object sender, EventArgs e)
        {
            try
            {
                int contactId = Convert.ToInt32(textBoxId.Text);
                if (contact.deleteContact(contactId)){
                    MessageBox.Show("Contact Id Remove Successfully", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Contact Id Remove Failed", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex)
                { MessageBox.Show(ex.Message); }    
        }

        private void ButtonShowList_Click(object sender, EventArgs e)
        {
            Show_Full_List show_Full_List = new Show_Full_List();
            show_Full_List.Show(this);  
        }
    }
}
