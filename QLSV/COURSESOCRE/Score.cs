using QLSV.COURSE;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLSV.COURSESOCRE
{

   
    internal class Score
    {

        MY_DB mydb = new MY_DB();

        public bool updateScoreStudent(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE Score SET student_score = @stdScore, description = @desc WHERE student_id = @stdId AND course_id = @cid ", mydb.getConnection);
            command.Parameters.AddWithValue("@stdScore", scoreValue);
            command.Parameters.AddWithValue("@desc", description);
            command.Parameters.AddWithValue("@stdId", studentID);
            command.Parameters.AddWithValue("@cid", courseID);

            mydb.openConnection();
            if((command.ExecuteNonQuery() == 1))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool insertCourseStudent(int studentID, int courseId)
        {
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Score(student_id, course_id) VALUES(@sid, @cid)", connection);
                command.Parameters.AddWithValue("@sid", studentID);
                command.Parameters.AddWithValue("@cid", courseId);

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool insertScoreStudent(int studentID, int courseId, float scoreValue, string description)
        {
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Score(student_id, course_id, student_score, description) VALUES(@sid, @cid, @stdScore, @description)", connection))
                {
                    command.Parameters.AddWithValue("@sid", studentID);
                    command.Parameters.AddWithValue("@cid", courseId);
                    command.Parameters.AddWithValue("@stdScore", scoreValue);
                    command.Parameters.AddWithValue("@description", description);

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() == 1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }


        public bool studentScoreExists(int studentId, int courseId)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id = @sid AND course_id = @cid", mydb.getConnection))
            {
                command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
                command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table.Rows.Count > 0;
                }
            }
        }


        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "SELECT CourseTable.label as CourseName, AVG(Score.student_score) As AverageGrade FROM CourseTable, Score WHERE CourseTable.ID = " + "  Score.course_id GROUP BY CourseTable.label";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE student_id = @sid AND course_id = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
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


        //function to get students score 
        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Score.student_id, student.fname, student.lname, Score.course_id, CourseTable.label, Score.student_score " +
                "FROM student " +
                "INNER JOIN Score ON student.id = Score.student_id" +
                " INNER JOIN CourseTable ON Score.course_id = CourseTable.id";
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get course's scores by id 
        public DataTable getCourseScorseBaseOnCourseId(int courseId)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Score.student_id, student.fname, student.lname, Score.course_id, CourseTable.label, Score.student_score " +
               "FROM student " +
               "INNER JOIN Score ON student.id = Score.student_id" +
               " INNER JOIN CourseTable ON Score.course_id = CourseTable.id WHERE Score.course_id = " + courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //get student's scores by id 
        public DataTable getStudentScoreBaseOnStudentId(int studentId)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Score.student_id, student.fname, student.lname, Score.course_id, CourseTable.label, Score.student_score " +
               "FROM student " +
               "INNER JOIN Score ON student.id = Score.student_id " +
               "INNER JOIN CourseTable ON Score.course_id = CourseTable.id " +
               "WHERE Score.student_id = @studentId";
            command.Parameters.AddWithValue("@studentId", studentId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseNameScoreStudentRegister(int studentId)
        {
            SqlCommand command = new SqlCommand("SELECT Score.student_id, student.fname, student.lname, score.course_id, CourseTable.label " +
                                                 " FROM student INNER JOIN Score ON student.id = Score.student_id " +
                                                 "INNER JOIN CourseTable ON CourseTable.id = Score.course_id" +
                                                 " WHERE Score.student_id = " + studentId, mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseBaseStudentIdRegister(int studentId)
        {
            SqlCommand commnad = new SqlCommand("SELECT Score.student_id, student.fname, student.lname, score.course_id, CourseTable.label " +
                                              " FROM student INNER JOIN Score ON student.id = Score.student_id " +
                                              "INNER JOIN CourseTable ON CourseTable.id = Score.course_id" +
                                              " WHERE Score.student_id = " + studentId, mydb.getConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commnad);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }

        public DataTable getScoreDescriptionBaseCourseId(int studentId,int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT student_score, description FROM Score WHERE course_id = @courseId and student_id = @studentId", mydb.getConnection);
            command.Parameters.AddWithValue("courseId", courseId);
            command.Parameters.AddWithValue("studentId", studentId);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }

        public DataTable getScoreDescriptionByCourseId(int StudentId, int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT student_score, description FROM Score WHERE student_id = @stdId AND course_id = @cId", mydb.getConnection);
            command.Parameters.AddWithValue("@stdId", StudentId);
            command.Parameters.AddWithValue("@cId", courseId);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);   
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table) ;
            return table;   
        }

        public DataTable avgScoreByCourseForm()
        {
            SqlCommand commnad = new SqlCommand("SELECT CourseTable.label CourseName, AVG(Score.student_score) as AverageGrade " +
                                                "FROM CourseTable INNER JOIN Score" +
                                                "ON CourseTable.id = Score.course_id  GROUP BY CourseTable.label", mydb.getConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commnad);
            DataTable table = new DataTable();  
            sqlDataAdapter.Fill(table) ;
            return table;
        }


        //get course scores 
        public DataTable getCoruseScores(int courseId)
        {
            SqlCommand commnad = new SqlCommand("SELECT Score.student_id, student.fname, student.lname, score.course_id, CourseTable.label " +
                                               " FROM student INNER JOIN Score ON student.id = Score.student_id " +
                                               "INNER JOIN CourseTable ON CourseTable.id = Score.course_id" +
                                               " WHERE Score.course_id = " + courseId, mydb.getConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commnad);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }

   
    }
}
