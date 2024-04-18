using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.User
{
    internal class USER
    {
        MY_DB mydb = new MY_DB();

        // get User By Id 

        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();


            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM hr  WHERE Id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        // insert User 
        public bool insertUser(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO hr(Id, f_name, l_name, uname, pwd, fig)" +
                " VALUES (@id, @fn, @ln, @un, @pass, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
         
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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



        //Update User 
        public bool updateUser(int userId, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE hr SET f_name = @fn, l_name = @ln, uname = @un, pwd = @pass, fig = @pic WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;

            mydb.openConnection();

            if(command.ExecuteNonQuery()==1)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }


        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM hr WHERE uname = @un";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM hr WHERE uname = @un AND id <> @uid";
            }
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
