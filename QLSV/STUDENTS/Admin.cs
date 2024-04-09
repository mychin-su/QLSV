using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }


        MY_DB mydb = new MY_DB();
        private void Admin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getAdmin(new SqlCommand("SELECT * FROM log_in WHERE Accept is NULL OR Accept = 0"));
            dataGridView1.AllowUserToAddRows = false;

        }

        public DataTable getAdmin(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = mydb.getConnection)
            {
                connection.Open();

                // Start a transaction.
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var userID = row.Cells["UserName"].Value;

                        if (row.Cells["Accept"].Value != null)
                        {
                            bool isAccept = Convert.ToBoolean(row.Cells["Accept"].Value);

                            // Include the WHERE clause to update only the specific row.
                            string query = "UPDATE log_in SET Accept = @accept WHERE UserName = @userName";
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@accept", isAccept);
                                command.Parameters.AddWithValue("@userName", userID);
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    // Commit the transaction if all updates are successful.
                    transaction.Commit();

                    // Refresh the DataGridView after committing the transaction.
                    dataGridView1.DataSource = getAdmin(new SqlCommand("SELECT * FROM log_in WHERE Accept is NULL OR Accept = 0"));
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if any update fails.
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trên DataGridView không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lặp qua từng hàng được chọn và xóa nó
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Lấy giá trị của cột "UserName" từ hàng được chọn
                    string userName = row.Cells["UserName"].Value.ToString();

                    // Tạo câu lệnh SQL để xóa người dùng có tên người dùng tương ứng
                    string sql = "DELETE FROM log_in WHERE UserName = @userName";

                     using (SqlCommand command = new SqlCommand(sql, mydb.getConnection))
                        {
                            // Thêm tham số @userName và gán giá trị
                            command.Parameters.AddWithValue("@userName", userName);

                            // Mở kết nối
                            mydb.openConnection();

                            // Thực thi lệnh DELETE
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có hàng nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                // Nếu có, xóa hàng từ DataGridView
                                dataGridView1.Rows.Remove(row);
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa người dùng: " + userName);
                            }
                        }
                    }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa.");
            }
        }
    }
}
