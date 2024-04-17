namespace QLSV.COURSESOCRE
{
    partial class AvgScoreByCourseFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2DataGridView_AvgCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_AvgCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DataGridView_AvgCourse
            // 
            this.guna2DataGridView_AvgCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView_AvgCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView_AvgCourse.Location = new System.Drawing.Point(37, 22);
            this.guna2DataGridView_AvgCourse.Name = "guna2DataGridView_AvgCourse";
            this.guna2DataGridView_AvgCourse.RowHeadersWidth = 51;
            this.guna2DataGridView_AvgCourse.RowTemplate.Height = 24;
            this.guna2DataGridView_AvgCourse.Size = new System.Drawing.Size(739, 413);
            this.guna2DataGridView_AvgCourse.TabIndex = 0;
            // 
            // AvgScoreByCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2DataGridView_AvgCourse);
            this.Name = "AvgScoreByCourseFrm";
            this.Text = "AvgScoreByCourseFrm";
            this.Load += new System.EventHandler(this.AvgScoreByCourseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_AvgCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.DataGridView guna2DataGridView_AvgCourse;
    }
}