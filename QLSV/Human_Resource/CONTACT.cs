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

        public bool check_command(SqlCommand command)
        {
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

        public bool insertContact(int id, string fname, string lname, string phone, string address, string email, int userid, int groupid, MemoryStream picture)
        {
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO mycontact (id, fname, lname, group_id, phone, email, address, pic, userid) VALUES (@id, @fn, @ln, @grp, @phn, @email, @adrs, @pic, @uid)", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
                command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
                command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
                
        }


        public bool updateContact(int id, string fname, string lname, int groupId, string phone, string email,string address, MemoryStream picture, int userId)
        {
            SqlCommand command = new SqlCommand("UPDATE mycontact SET fname = @fn, lname = @ln, group_id = @gid, phone = @phn, email = @email, address = @adrs, pic = @pic, userid = @uid WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupId;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            return check_command(command);
        }

        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mycontact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
           return check_command(command);
        }

        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable fullContactList(int userId)
        {
           SqlCommand command = new SqlCommand("SELECT mycontact.fname as FirstName, lname as LastName, mygroups.name as GroupName, phone, email, address, pic as Picture " +
               "\r\nFROM mycontact INNER JOIN mygroups ON  mycontact.group_id = mygroups.id WHERE mycontact.userid  = @uid", mydb.getConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value=userId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getFullContactByGroupIdAndUserId(int userId, int groupId)
        {
            SqlCommand command = new SqlCommand("SELECT mycontact.fname as FirstName, lname as LastName, mygroups.name as GroupName, phone, email, address, pic as Picture \r\nFROM mycontact INNER JOIN mygroups ON  mycontact.group_id = mygroups.id WHERE mycontact.userid  = @userId AND mycontact.group_id = @groupId", mydb.getConnection);
            command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
            command.Parameters.Add("@groupId", SqlDbType.Int).Value = groupId;
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

        public bool checkId(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM mycontact WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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


    }
}
