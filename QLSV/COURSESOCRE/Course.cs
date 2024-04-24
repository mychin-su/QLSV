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
using System.Configuration;

namespace QLSV.COURSE
{
    internal class Course
    {

        MY_DB mydb = new MY_DB();

        //function to insert a new Course 
        public bool insertCourse(int Id, string label, int period, string description, string semester, int idContact)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO CourseTable (id, label, period, description, Semester, idContact)" + " VALUES (@id, @name, @hrs, @description, @semester, @idContact)", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = label;
                command.Parameters.Add("@hrs", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
                command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;
                command.Parameters.Add("@idContact", SqlDbType.Int).Value = idContact;

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
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "InsertCourse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        
        }

        //Update Student 
        public bool updateCourse(int Id, string lable, int period, string description, string semester, int idContact)
        {
            try
            {
                string query = "UPDATE CourseTable SET label = @label, period = @period, description = @description, Semester = @semester, idContact = @idContact WHERE id = @id";
                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@label", lable);
                    command.Parameters.AddWithValue("@period", period);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@semester", semester);
                    command.Parameters.AddWithValue("@idContact", idContact);
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
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT c.label FROM CourseTable c WHERE c.id NOT IN (SELECT s.course_id FROM Score s WHERE student_id = @stdId) AND c.Semester = @smt", connection);
                command.Parameters.AddWithValue("@stdId", id);
                command.Parameters.AddWithValue("@smt", semester);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable getCourseStudentRegister(string courseName)
        {
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY s.fname) as STT, s.id as ID, s.fname as FirstName, s.lname as LastName, s.bdate as DOB, sc.student_score as Score FROM student as s  INNER JOIN Score as sc ON s.id = sc.student_id INNER JOIN CourseTable as ct ON sc.course_id = ct.id  WHERE ct.label = @cN", connection);
                command.Parameters.AddWithValue("@cN", courseName);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();  
                adapter.Fill(table);
                return table;

            }
        }


        //get id base on courseName
        public int getIdBaseOnCourseName(string courseName)
            {
                int courseId = -1; 
                try
                {
                string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open(); 

                        // Create and execute the command
                        SqlCommand command = new SqlCommand("SELECT id FROM CourseTable WHERE label = @courseName", connection);

                        command.Parameters.AddWithValue("@courseName", courseName);
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out courseId))
                        {
                            return courseId;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return courseId;
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
