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
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            this.label_Semester = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseName.Location = new System.Drawing.Point(243, 51);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(203, 30);
            this.textBox_CourseName.TabIndex = 1;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 238);
            this.dataGridView1.TabIndex = 3;
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
            // 
            // CourseStdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Semester);
            this.Controls.Add(this.textBox_CourseName);
            this.Controls.Add(this.label1);
            this.Name = "CourseStdList";
            this.Text = "CourseStdList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CourseName;
        private System.Windows.Forms.Label label_Semester;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_Print;
    }
}