using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV.COURSE
{
    internal class Course
    {

        MY_DB mydb = new MY_DB();

        //function to insert a new Course 
        public bool insertCourse(int Id, string label, int period, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CourseTable (id, label, period, description)" + " VALUES (@id, @name, @hrs, @description)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = period;
            command.Parameters.Add("description", SqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if((command.ExecuteNonQuery() == 1))
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

        //Update Student 
        public bool updateCourse(int Id, string lable, int period, string description)
        {
            try
            {
                string query = "UPDATE CourseTable SET label = @label, period = @period, description = @description WHERE id = @id";
                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@label", lable);
                    command.Parameters.AddWithValue("@period", period);
                    command.Parameters.AddWithValue("@description", description);
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
        public bool deleteCourse(int id)
        {
            try
            {

                string query = "DELETE FROM CourseTable WHERE id = @id";

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
                return false;
            }

        }

        //Lay all course 
        public DataTable getAllCourse(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Lay ra 1 course theo id 
        public DataTable getCourseById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CourseTable WHERE id = " + id);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Select Course that the student has not register 
        public DataTable getCourseStudentIdNotRegister(int id, int semester) 
        {
            SqlCommand command = new SqlCommand("SELECT CourseTable.label FROM CourseTable LEFT JOIN student ON CourseTable.label = student.SelectedCourse AND student.id = @stdId WHERE student.SelectedCourse IS NULL AND CourseTable.Semester = @smt");
            command.Connection = mydb.getConnection;    
            command.Parameters.AddWithValue("@stdId", SqlDbType.Int).Value = id;
            command.Parameters.AddWithValue("@smt", SqlDbType.Int).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
           return table;
        }


        //check course follow name 
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CourseTable WHERE label=@cName And id = @cID", mydb.getConnection);
            command.Parameters.AddWithValue("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.AddWithValue("@cID", SqlDbType.VarChar).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //neu phat hien co 1 dong ton tai trung ten
                return true;
            }
            else
            {
                return false;
            }
        }
        //function to excute the count query 

        public string execCount(string query)
        {
            SqlCommand comand = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = comand.ExecuteScalar().ToString();

            mydb.closeConnection();
            return count;
        }

        //function to return the total courses in the database

        public string totalCourse()
        {
            return execCount("SELECT COUNT(*) FROM CourseTable");
        }
    }
}
