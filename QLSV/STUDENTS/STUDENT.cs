using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    class STUDENT
    {

        MY_DB mydb = new MY_DB();


        //  function to insert a new student
        public bool insertStudent(int Id,string fname, string lname, DateTime bdate, string email, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student (id, fname, lname, bdate, email, gender, phone, address, picture)" +
                " VALUES (@id,@fn, @ln, @bdt, @email, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
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

   

        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Update Student 
        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string email, string gender, string phone, string address, byte[] picture)
        {
            try
            {
                string query = "UPDATE student SET fname = @fname, lname = @lname, bdate = @bdate, email = @email ,gender = @gender, phone = @phone, address = @address, picture = @picture WHERE id = @id";
                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@bdate", bdate);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);
                    if(picture != null)
                    {
                        command.Parameters.AddWithValue("@picture", picture);
                    }

                    con.Open();
                    int result = command.ExecuteNonQuery(); // Executes update and returns number of affected rows

                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

 


        //Delete Student 
        public bool deleteStudent(int id)
        {
            try
            {
                
                string query = "DELETE FROM student WHERE id = @id";

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

        public string execCount(string query)
        {
           SqlCommand command = new SqlCommand(query, mydb.getConnection);
           mydb.openConnection();
           string count = command.ExecuteScalar().ToString();  // *ExecuteScalar() được sử dụng để thực thi truy vấn và trả về số lượng bản ghi trong bảng. Gía trị này được
                                                               // trả về dưới dạng một đối tượn 'object' sau đó chúng ta ép kiểu về kiểu dữ liệu String 

                                                               //ExecuteNonQuery() được sử dụng để thực thi các truy vấn không trả về bất kì dòng nào từ từ cơ sở dữ liệu, như các truy vấn INSERT, Update, Delete 
            mydb.closeConnection();
            return count;
        }

        public string totalStudent()
        {

            return execCount("SELECT COUNT(*) FROM student");
        }

        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM student WHERE gender = 'Male'");
        }

        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM student WHERE gender = 'Female'");
        }


    }
}
