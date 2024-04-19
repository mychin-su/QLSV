using QLSV.Human_Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QLSV
{
    public partial class Progress : Form
    {


        public object ProgressResult { get; internal set; }


        bool flag;
        public Progress(bool flag)
        {
            InitializeComponent();
             this.flag = flag;
        }   

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //cong viec chinh mat thoi gian 
            int sum = 0;
            for (int i = 0; i  <= 100; i ++){
                Thread.Sleep(10); // cho nó ngủ 100ms sau đó nó mới cộng tiếp cho i
                sum += i;
                //goi su kiện progressChanged
                backgroundWorker1.ReportProgress(i); // nó sẽ chạy thanh progress từ 0 đến 100
                if (backgroundWorker1.CancellationPending == true) // nhấn nut hủy 
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0); // cho phần trăm chạy về 0
                    return;
                }
            }
            e.Result = sum;
        }

        //update tiến trình
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //update % lên value 3
            progressBar1.Value = e.ProgressPercentage;
            //upadte % lên label
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            if (e.Cancelled)
            {
                label2.Text = "Process was cancelled";
                this.Hide();
                login_Form.Show();
            }
            else if (e.Error != null)
            {
                label2.Text = "Error: " + e.Error.Message;
            }
            else
            {
                if (flag) // Nếu flag == true
                {
                    MainForm01 mainForm = new MainForm01(); // Form Student
                    mainForm.FormClosed += (s, args) => this.Close(); // Close progress form when main form closes
                    mainForm.Show();
                }
                else
                {
                    Main_Form form = new Main_Form();   // Form HR 
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                }
                this.Hide(); // Hide progress form
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // nếu worker đang chạy thì cancel để dừng
            if(backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            } else
            {
                label2.Text = "Tiến trình đã bị ngừng";
            }
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(e);
        }
    }
}
