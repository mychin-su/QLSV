namespace QLSV.COURSESOCRE
{
    partial class CourseStdList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Semester = new System.Windows.Forms.Label();
            this.dataGridView_StudentCourse = new System.Windows.Forms.DataGridView();
            this.Button_Print = new System.Windows.Forms.Button();
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            // 
            // label_Semester
            // 
            this.label_Semester.AutoSize = true;
            this.label_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Semester.Location = new System.Drawing.Point(558, 56);
            this.label_Semester.Name = "label_Semester";
            this.label_Semester.Size = new System.Drawing.Size(111, 25);
            this.label_Semester.TabIndex = 2;
            this.label_Semester.Text = "Semester:";
            // 
            // dataGridView_StudentCourse
            // 
            this.dataGridView_StudentCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentCourse.Location = new System.Drawing.Point(48, 125);
            this.dataGridView_StudentCourse.Name = "dataGridView_StudentCourse";
            this.dataGridView_StudentCourse.RowHeadersWidth = 51;
            this.dataGridView_StudentCourse.RowTemplate.Height = 24;
            this.dataGridView_StudentCourse.Size = new System.Drawing.Size(722, 238);
            this.dataGridView_StudentCourse.TabIndex = 3;
            // 
            // Button_Print
            // 
            this.Button_Print.BackColor = System.Drawing.Color.Aqua;
            this.Button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Print.Location = new System.Drawing.Point(323, 388);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(162, 39);
            this.Button_Print.TabIndex = 4;
            this.Button_Print.Text = "Print";
            this.Button_Print.UseVisualStyleBackColor = false;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseName.Location = new System.Drawing.Point(255, 51);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(193, 30);
            this.textBox_CourseName.TabIndex = 5;
            // 
            // CourseStdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_CourseName);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.dataGridView_StudentCourse);
            this.Controls.Add(this.label_Semester);
            this.Controls.Add(this.label1);
            this.Name = "CourseStdList";
            this.Text = "CourseStdList";
            this.Load += new System.EventHandler(this.CourseStdList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Semester;
        private System.Windows.Forms.DataGridView dataGridView_StudentCourse;
        private System.Windows.Forms.Button Button_Print;
        private System.Windows.Forms.TextBox textBox_CourseName;
    }
}