using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{ 
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void MainForm01_Load(object sender, EventArgs e)
        {

        }
        private void rToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            studentListForm StdList = new studentListForm();
            StdList.Show(this);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Student_Form manage_Student_Form = new Manage_Student_Form();
            manage_Student_Form.Show();
        }
    }
 }

