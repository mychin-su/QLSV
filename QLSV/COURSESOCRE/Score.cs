using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.COURSESOCRE
{

   
    internal class Score
    {

        MY_DB mydb = new MY_DB();


        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score(student_id, course_id, student_score, description) VALUES(@sid, @cid, @scr" + ",@desc)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = description;

            mydb.openConnection();
            if((command.ExecuteNonQuery() == 1))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool studentScoreExits(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id = @sid AND course_id = @cid", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if(table.Rows.Count == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "SELECT CourseTable.label, AVG(Score.student_score) As AverageGrade FROM CourseTable, Score WHERE CourseTable.ID = " + "  Score.course_id GROUP BY CourseTable.label";

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
    }
}
