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
using System.Web.Profile;
using System.Windows.Forms;

namespace QLSV.Human_Resource
{
    public partial class Show_Full_List : Form
    {
        public Show_Full_List()
        {
            InitializeComponent();
        }

        GROUP group = new GROUP();
        CONTACT contact = new CONTACT();

        private void Show_Full_List_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();

            dataGridView_ShowAll.RowTemplate.Height = 80;
            dataGridView_ShowAll.DataSource = contact.fullContactList(GlobalIdUser.GlobalUserId);
            piCol = (DataGridViewImageColumn)dataGridView_ShowAll.Columns[7];

            piCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for(int i = 0; i < dataGridView_ShowAll.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView_ShowAll.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }

                listBoxGroup.DataSource = group.getGroup(GlobalIdUser.GlobalUserId);
                listBoxGroup.DisplayMember = "name";
                listBoxGroup.ValueMember = "id";

                listBoxGroup.SelectedItem = null;
                dataGridView_ShowAll.ClearSelection();
            }

        }

        public static bool IsOdd(int val)
        {
            return val % 2 != 0;
        }

        private void dataGridView_ShowAll_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for(int i = 0; i < dataGridView_ShowAll.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView_ShowAll.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void listBoxGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId = Convert.ToInt32(listBoxGroup.SelectedValue);
                int userId = GlobalIdUser.GlobalUserId;
                dataGridView_ShowAll.DataSource = contact.getFullContactByGroupIdAndUserId(userId, groupId);
                for(int i = 0; i < dataGridView_ShowAll.Rows.Count; i++)
                {
                    if (IsOdd(i))
                    {
                        dataGridView_ShowAll.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView_ShowAll.ClearSelection();
        }

        private void dataGridView_ShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxAddress.Text = dataGridView_ShowAll.CurrentRow.Cells[6].Value.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Show_Full_List_Load(null, null);
        }

  

        private void dataGridView_ShowAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          try
            {
                int idContat = int.Parse(dataGridView_ShowAll.CurrentRow.Cells[0].Value.ToString());
                Show_Student_By_Contact show_Student_By_Contact = new Show_Student_By_Contact(idContat);
                show_Student_By_Contact.Show();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
