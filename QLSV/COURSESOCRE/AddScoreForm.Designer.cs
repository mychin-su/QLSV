namespace QLSV.COURSESOCRE
{
    partial class AddScoreForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_StudentID = new System.Windows.Forms.TextBox();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.comboBox_SelectCourse = new System.Windows.Forms.ComboBox();
            this.Button_AddCourse = new System.Windows.Forms.Button();
            this.DataGridViewStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(92, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(52, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // TextBox_StudentID
            // 
            this.TextBox_StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_StudentID.Location = new System.Drawing.Point(251, 49);
            this.TextBox_StudentID.Name = "TextBox_StudentID";
            this.TextBox_StudentID.ReadOnly = true;
            this.TextBox_StudentID.Size = new System.Drawing.Size(160, 30);
            this.TextBox_StudentID.TabIndex = 4;
            // 
            // textBox_Score
            // 
            this.textBox_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Score.Location = new System.Drawing.Point(252, 205);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(168, 30);
            this.textBox_Score.TabIndex = 6;
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Description.Location = new System.Drawing.Point(251, 279);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(211, 104);
            this.richTextBox_Description.TabIndex = 7;
            this.richTextBox_Description.Text = "";
            // 
            // comboBox_SelectCourse
            // 
            this.comboBox_SelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectCourse.FormattingEnabled = true;
            this.comboBox_SelectCourse.Location = new System.Drawing.Point(251, 113);
            this.comboBox_SelectCourse.Name = "comboBox_SelectCourse";
            this.comboBox_SelectCourse.Size = new System.Drawing.Size(234, 33);
            this.comboBox_SelectCourse.TabIndex = 8;
            this.comboBox_SelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectCourse_SelectedIndexChanged);
            // 
            // Button_AddCourse
            // 
            this.Button_AddCourse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_AddCourse.Location = new System.Drawing.Point(57, 405);
            this.Button_AddCourse.Name = "Button_AddCourse";
            this.Button_AddCourse.Size = new System.Drawing.Size(428, 41);
            this.Button_AddCourse.TabIndex = 9;
            this.Button_AddCourse.Text = "Add Score";
            this.Button_AddCourse.UseVisualStyleBackColor = false;
            this.Button_AddCourse.Click += new System.EventHandler(this.Button_AddCourse_Click);
            // 
            // DataGridViewStudents
            // 
            this.DataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudents.Location = new System.Drawing.Point(513, 49);
            this.DataGridViewStudents.Name = "DataGridViewStudents";
            this.DataGridViewStudents.RowHeadersWidth = 51;
            this.DataGridViewStudents.RowTemplate.Height = 24;
            this.DataGridViewStudents.Size = new System.Drawing.Size(443, 346);
            this.DataGridViewStudents.TabIndex = 10;
            this.DataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudents_CellClick);
            this.DataGridViewStudents.Click += new System.EventHandler(this.DataGridViewStudents_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(986, 484);
            this.Controls.Add(this.DataGridViewStudents);
            this.Controls.Add(this.Button_AddCourse);
            this.Controls.Add(this.comboBox_SelectCourse);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.textBox_Score);
            this.Controls.Add(this.TextBox_StudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_StudentID;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.ComboBox comboBox_SelectCourse;
        private System.Windows.Forms.Button Button_AddCourse;
        private System.Windows.Forms.DataGridView DataGridViewStudents;
    }
}