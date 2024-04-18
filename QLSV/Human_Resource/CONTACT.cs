using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSV.User
{
    internal class CONTACT
    {
        MY_DB mydb = new MY_DB();

        public bool insertContact(string fname, string lname, string phone, string address, string email, int userid, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mycontact (fname, lname, group_id, phone, email, address, picture, userid) VALUES (@fn, @ln, @grp, @phn, @email, @adrs, @uid, @pic)", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }



        public bool updateContact(int contactid, string fname, string lname, string phone, string address, string email, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE mycontact SET fname = @fn, lname = @ln, group_id = @gid, phone = @phn, email = @email, address = @adrs, pic = @pic WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mycontact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable GetContactById(int contactId)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, group_id, phone, email, address, pic, userid FROM mycontact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
