using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.COURSESOCRE
{
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        DataGridViewCell selectedCell;
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView_RemoveScore.DataSource = score.getStudentScore();
        }

        private void dataGridView_RemoveScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedCell = dataGridView_RemoveScore.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void Button_RemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCell != null)
                {
                    DataGridViewRow row = selectedCell.OwningRow;
                    int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                    int courseId = Convert.ToInt32(row.Cells["CourseId"].Value);

                    if (MessageBox.Show("Are You Sure You Want To Delete This Score?", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (score.deleteScore(studentId, courseId))
                        {
                            dataGridView_RemoveScore.Rows.Remove(row);
                            MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                } else
                    {
                    MessageBox.Show("Please select a cell before removing.", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

 
    }
}
