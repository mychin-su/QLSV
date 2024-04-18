using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace QLSV.Human_Resource
{
    class GROUP
    {
        MY_DB db = new MY_DB();



        public bool insertGroup(int id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroups (id, name. userid)  VALUES (@id, @gn, @uid)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gname;
            command.Parameters.Add("uid", SqlDbType.Int).Value = userid;

            db.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            } else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool updateGroup(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroups SET name @name WHERE id = @id", db.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            } else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool deleteGroup(int id)
        {
            try
            {

                string query = "DELETE FROM mygroups WHERE id = @id";

                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception for debugging and security purposes.
                return false;
            }
        }


        //chuc nang nay quan trong, xac dinh group cho userId nao do
        public DataTable getGroup(int userId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE userid = @uid", db.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool groupExits(string name, string operation, int userid = 0, int groupid = 0)
        {
            string query = "";

            SqlCommand command = new SqlCommand();
            if(operation == "add")
            {
                query = "SELECT * FROM mygroups WHERE name = @name AND userid = @uid";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            } else if(operation == "edit")
            {
                query = "SELECT * FROM mygroups WHERE name =  @name AND userid = @uid AND id <> @gid";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }

            command.Connection = db.getConnection;
            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;

            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
