using QLSV.User;
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

namespace QLSV.Human_Resource
{
    public partial class Select_Contact_Form : Form
    {

        public Select_Contact_Form()
        {
            InitializeComponent();
        }
        CONTACT contact = new CONTACT();

        private void Select_Contact_Form_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT  id ,  fname  as'first name',  lname  as 'last name',  group_id  as'group id' FROM  mycontact  WHERE  userid  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GlobalIdUser.GlobalUserId;
            dataGridViewSelectContact.DataSource = contact.SelectContactList(command);
        }

        private void dataGridViewSelectContact_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

    }
}
