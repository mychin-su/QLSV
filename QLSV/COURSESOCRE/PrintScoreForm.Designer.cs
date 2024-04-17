namespace QLSV.COURSESOCRE
{
    partial class PrintScoreForm
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
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.dataGridViewStudentScore = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Print = new Guna.UI2.WinForms.Guna2Button();
            this.labelReset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course List";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 31;
            this.listBoxCourse.Location = new System.Drawing.Point(36, 133);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(223, 314);
            this.listBoxCourse.TabIndex = 1;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // dataGridViewStudentScore
            // 
            this.dataGridViewStudentScore.AllowUserToAddRows = false;
            this.dataGridViewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentScore.Location = new System.Drawing.Point(275, 120);
            this.dataGridViewStudentScore.Name = "dataGridViewStudentScore";
            this.dataGridViewStudentScore.RowHeadersWidth = 51;
            this.dataGridViewStudentScore.RowTemplate.Height = 24;
            this.dataGridViewStudentScore.Size = new System.Drawing.Size(541, 327);
            this.dataGridViewStudentScore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(294, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score List";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(842, 158);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(366, 279);
            this.dataGridViewStudent.TabIndex = 4;
            this.dataGridViewStudent.Click += new System.EventHandler(this.dataGridViewStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(833, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Students List";
            // 
            // Button_Print
            // 
            this.Button_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Print.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Print.ForeColor = System.Drawing.Color.White;
            this.Button_Print.Location = new System.Drawing.Point(275, 495);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(541, 45);
            this.Button_Print.TabIndex = 6;
            this.Button_Print.Text = "Print To Text File";
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelReset.Location = new System.Drawing.Point(646, 63);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(93, 32);
            this.labelReset.TabIndex = 7;
            this.labelReset.Text = "Reset";
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1220, 569);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewStudentScore);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.label1);
            this.Name = "PrintScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.DataGridView dataGridViewStudentScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Button_Print;
        private System.Windows.Forms.Label labelReset;
    }
}