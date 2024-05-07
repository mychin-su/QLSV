using Org.BouncyCastle.Asn1.X509;
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
using System.Runtime.Remoting.Messaging;
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

        //create a function to checck if a score is already asigned to this student in this course 
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

            command.CommandText = "SELECT CourseTable.label as CourseName, ROUND(AVG(Score.student_score), 2) As AverageGrade FROM CourseTable, Score WHERE CourseTable.ID = " + "  Score.course_id GROUP BY CourseTable.label";

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
            command.CommandText = "SELECT Score.student_id as StudentId, student.fname as FirstName, student.lname as LastName, Score.course_id as CourseId, CourseTable.label as CourseName, Score.student_score as Score " +
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
            SqlCommand commnad = new SqlCommand("SELECT Score.student_id, student.fname, student.lname, score.course_id, CourseTable.label as CourseName" +
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

        public DataTable getStudentReslt()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string cmdText = @"
            DECLARE @columns AS NVARCHAR(MAX), @sql AS NVARCHAR(MAX);

            -- Generate a list of columns for the PIVOT
            SELECT @columns = COALESCE(@columns + ', ', '') + QUOTENAME(label)
            FROM (SELECT DISTINCT label FROM CourseTable) AS Courses;

            -- Create the dynamic SQL query
            SET @sql = '
            SELECT StudentId, FirstName, LastName, ' + @columns + ', AverageScore, Result
            FROM
            (
                SELECT
                    student.id AS StudentId,
                    student.fname as FirstName,
                    student.lname as LastName,
                    CourseTable.label,
                    Score.student_score,  
                    AVG(Score.student_score) OVER (PARTITION BY student.id) AS AverageScore, 
                   CASE 
                    WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) < 5 THEN ''Weak''
                    WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 5 AND 6 THEN ''Medium''
                    WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 7 AND 8 THEN ''Rather''
                    WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) > 8 THEN ''Good''
                    ELSE ''Fail''  -- This handles any edge cases or unexpected values
        END AS Result  -- Determine performance based on average score
                FROM Score
                INNER JOIN CourseTable ON Score.course_id = CourseTable.id
                INNER JOIN student ON Score.student_id = student.id
            ) AS SourceTable
            PIVOT
            (
                AVG(student_score) FOR label IN (' + @columns + ')
            ) AS PivotTable;';

            -- Execute the dynamic SQL query
            EXEC sp_executesql @sql;
        ";

                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }

            return dt;
        }


        public DataTable searchByIdFname(string text)
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    connection.Open();

                    string cmdText = @"
                    DECLARE @input NVARCHAR(100), @columns AS NVARCHAR(MAX), @sql AS NVARCHAR(MAX);
                    SET @input = @text;  

                    SELECT @columns = COALESCE(@columns + ', ', '') + QUOTENAME(label)
                    FROM (SELECT DISTINCT label FROM CourseTable) AS Courses;

                    SET @sql = '
                    DECLARE @studentId INT, @isNumeric BIT;
                    SET @isNumeric = ISNUMERIC(@input);  
                    SET @studentId = CASE WHEN @isNumeric = 1 THEN CAST(@input AS INT) ELSE NULL END;

                    SELECT StudentId, FirstName, LastName, ' + @columns + ', OverallAvg, Result
                    FROM
                    (
                        SELECT
                            student.id AS StudentId,
                            student.fname as FirstName,
                            student.lname as LastName,
                            CourseTable.label,
                            Score.student_score,  
                            AVG(Score.student_score) OVER (PARTITION BY student.id) AS OverallAvg, 
                            CASE 
                                WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) < 5 THEN ''Yếu''
                                WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 5 AND 6 THEN ''Trung Bình''
                                WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 7 AND 8 THEN ''Khá''
                                WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) > 8 THEN ''Giỏi''
                                ELSE ''Fail''  
                            END AS Result
                        FROM Score
                        INNER JOIN CourseTable ON Score.course_id = CourseTable.id
                        INNER JOIN student ON Score.student_id = student.id
                        WHERE (@isNumeric = 1 AND student.id = @studentId) OR
                              (@isNumeric = 0 AND student.lname LIKE ''%' + @input + '%'') 
                    ) AS SourceTable
                    PIVOT
                    (
                        AVG(student_score)
                        FOR label IN (' + @columns + ')
                    ) AS PivotTable;';

                    EXEC sp_executesql @sql, N'@input NVARCHAR(100)', @input;
                ";

                SqlCommand command = new SqlCommand(cmdText, connection);
                command.Parameters.AddWithValue("@text", text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }

            return dt;
        }

        public Dictionary<string, int> GetStudentResultsCount()
        {
            Dictionary<string, int> resultsCount = new Dictionary<string, int>();
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
            string query = @"
                            WITH ResultData AS (
                                SELECT
                                    student.id AS StudentId,
                                    CASE
                                        WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) < 5 THEN 'Weak'
                                        WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 5 AND 6 THEN 'Medium'
                                        WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 7 AND 8 THEN 'Rather'
                                        WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) > 8 THEN 'Good'
                                        ELSE 'Fail'
                                    END AS Result
                                FROM Score
                                INNER JOIN CourseTable ON Score.course_id = CourseTable.id
                                INNER JOIN student ON Score.student_id = student.id
                            )
                            SELECT Result, COUNT(*) AS NumberOfStudents
                            FROM ResultData
                            GROUP BY Result;
                            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string resultType = reader["Result"].ToString();
                        int count = Convert.ToInt32(reader["NumberOfStudents"]);
                        resultsCount[resultType] = count;
                    }
                }
            }

            return resultsCount;
        }


        public Dictionary<string, double> getAvgScoreCourse()
        {
            Dictionary<string, double> resultsCount = new Dictionary<string, double>();
            string connectionString = "Data Source=Vuong-Duc-Thoai\\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;";
            string query = @"
                    SELECT CourseTable.label as CourseName, AVG(Score.student_score) As AverageGrade
                    FROM CourseTable
                    JOIN Score ON CourseTable.ID = Score.course_id
                    GROUP BY CourseTable.label";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string courseName = reader["CourseName"].ToString();
                        double averageGrade = reader.IsDBNull(reader.GetOrdinal("AverageGrade")) ? 0f : (double)reader["AverageGrade"];
                        resultsCount[courseName] = averageGrade;
                    }
                }
            }
            return resultsCount;
        }


        public DataTable getResultStudent()
        {
            SqlCommand command = new SqlCommand("\tDECLARE @sql AS NVARCHAR(MAX);\r\n\r\n-- Create the dynamic SQL query\r\nSET @sql = '\r\nSELECT Result, COUNT(*) AS TotalStudents\r\nFROM\r\n(\r\n    SELECT\r\n        student.id AS StudentId,\r\n        student.fname as FirstName,\r\n        student.lname as LastName,\r\n        CourseTable.label,\r\n        Score.student_score,  \r\n        AVG(Score.student_score) OVER (PARTITION BY student.id) AS AverageScore, \r\n        CASE \r\n            WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) < 5 THEN ''Weak''\r\n            WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 5 AND 6 THEN ''Medium''\r\n            WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) BETWEEN 7 AND 8 THEN ''Rather''\r\n            WHEN AVG(Score.student_score) OVER (PARTITION BY student.id) > 8 THEN ''Good''\r\n            ELSE ''Fail''  -- This handles any edge cases or unexpected values\r\n        END AS Result  -- Determine performance based on average score\r\n    FROM Score\r\n    INNER JOIN CourseTable ON Score.course_id = CourseTable.id\r\n    INNER JOIN student ON Score.student_id = student.id\r\n) AS SourceTable\r\nGROUP BY Result;';\r\n\r\n-- Execute the dynamic SQL query\r\nEXEC sp_executesql @sql;\r\n", mydb.getConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }
    }
}
