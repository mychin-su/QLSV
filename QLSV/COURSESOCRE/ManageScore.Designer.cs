namespace QLSV.COURSESOCRE
{
    partial class ManageScore
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
            this.textBox_StudentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_SelectScore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox_Score = new Guna.UI2.WinForms.Guna2TextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.Button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Avg = new Guna.UI2.WinForms.Guna2Button();
            this.Button_ShowStudent = new Guna.UI2.WinForms.Guna2Button();
            this.Button_ShowScores = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(86, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(51, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_StudentID.DefaultText = "";
            this.textBox_StudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_StudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_StudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_StudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_StudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_StudentID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_StudentID.Location = new System.Drawing.Point(209, 26);
            this.textBox_StudentID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.PasswordChar = '\0';
            this.textBox_StudentID.PlaceholderText = "";
            this.textBox_StudentID.SelectedText = "";
            this.textBox_StudentID.Size = new System.Drawing.Size(190, 35);
            this.textBox_StudentID.TabIndex = 4;
            // 
            // comboBox_SelectScore
            // 
            this.comboBox_SelectScore.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_SelectScore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_SelectScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectScore.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_SelectScore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_SelectScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_SelectScore.ItemHeight = 30;
            this.comboBox_SelectScore.Location = new System.Drawing.Point(209, 102);
            this.comboBox_SelectScore.Name = "comboBox_SelectScore";
            this.comboBox_SelectScore.Size = new System.Drawing.Size(190, 36);
            this.comboBox_SelectScore.TabIndex = 5;
            // 
            // textBox_Score
            // 
            this.textBox_Score.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Score.DefaultText = "";
            this.textBox_Score.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Score.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Score.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Score.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Score.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Score.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Score.Location = new System.Drawing.Point(209, 183);
            this.textBox_Score.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.PasswordChar = '\0';
            this.textBox_Score.PlaceholderText = "";
            this.textBox_Score.SelectedText = "";
            this.textBox_Score.Size = new System.Drawing.Size(190, 35);
            this.textBox_Score.TabIndex = 6;
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(208, 255);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(191, 87);
            this.richTextBox_description.TabIndex = 7;
            this.richTextBox_description.Text = "";
            // 
            // Button_Add
            // 
            this.Button_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Add.FillColor = System.Drawing.Color.Yellow;
            this.Button_Add.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.Color.DimGray;
            this.Button_Add.Location = new System.Drawing.Point(38, 365);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(180, 45);
            this.Button_Add.TabIndex = 8;
            this.Button_Add.Text = "Add";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Remove.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.ForeColor = System.Drawing.Color.White;
            this.Button_Remove.Location = new System.Drawing.Point(259, 365);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(180, 45);
            this.Button_Remove.TabIndex = 9;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Avg
            // 
            this.Button_Avg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Avg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Avg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Avg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Avg.FillColor = System.Drawing.Color.DeepPink;
            this.Button_Avg.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Avg.ForeColor = System.Drawing.Color.White;
            this.Button_Avg.Location = new System.Drawing.Point(57, 428);
            this.Button_Avg.Name = "Button_Avg";
            this.Button_Avg.Size = new System.Drawing.Size(356, 45);
            this.Button_Avg.TabIndex = 10;
            this.Button_Avg.Text = "Average Score By Course";
            this.Button_Avg.Click += new System.EventHandler(this.Button_Avg_Click);
            // 
            // Button_ShowStudent
            // 
            this.Button_ShowStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_ShowStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_ShowStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_ShowStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_ShowStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ShowStudent.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ShowStudent.ForeColor = System.Drawing.Color.White;
            this.Button_ShowStudent.Location = new System.Drawing.Point(678, 26);
            this.Button_ShowStudent.Name = "Button_ShowStudent";
            this.Button_ShowStudent.Size = new System.Drawing.Size(227, 45);
            this.Button_ShowStudent.TabIndex = 11;
            this.Button_ShowStudent.Text = "Show Students ";
            this.Button_ShowStudent.Click += new System.EventHandler(this.Button_ShowStudent_Click);
            // 
            // Button_ShowScores
            // 
            this.Button_ShowScores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_ShowScores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_ShowScores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_ShowScores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_ShowScores.FillColor = System.Drawing.Color.DarkOrchid;
            this.Button_ShowScores.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ShowScores.ForeColor = System.Drawing.Color.White;
            this.Button_ShowScores.Location = new System.Drawing.Point(1083, 26);
            this.Button_ShowScores.Name = "Button_ShowScores";
            this.Button_ShowScores.Size = new System.Drawing.Size(180, 45);
            this.Button_ShowScores.TabIndex = 12;
            this.Button_ShowScores.Text = "Show Scores";
            this.Button_ShowScores.Click += new System.EventHandler(this.Button_ShowScores_Click_1);
            // 
            // dataGridView_Show
            // 
            this.dataGridView_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Show.Location = new System.Drawing.Point(478, 99);
            this.dataGridView_Show.Name = "dataGridView_Show";
            this.dataGridView_Show.RowHeadersWidth = 51;
            this.dataGridView_Show.RowTemplate.Height = 24;
            this.dataGridView_Show.Size = new System.Drawing.Size(1026, 383);
            this.dataGridView_Show.TabIndex = 13;
            this.dataGridView_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Show_CellClick_1);
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1543, 514);
            this.Controls.Add(this.dataGridView_Show);
            this.Controls.Add(this.Button_ShowScores);
            this.Controls.Add(this.Button_ShowStudent);
            this.Controls.Add(this.Button_Avg);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.textBox_Score);
            this.Controls.Add(this.comboBox_SelectScore);
            this.Controls.Add(this.textBox_StudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBox_StudentID;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_SelectScore;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Score;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private Guna.UI2.WinForms.Guna2Button Button_Add;
        private Guna.UI2.WinForms.Guna2Button Button_Remove;
        private Guna.UI2.WinForms.Guna2Button Button_Avg;
        private Guna.UI2.WinForms.Guna2Button Button_ShowStudent;
        private Guna.UI2.WinForms.Guna2Button Button_ShowScores;
        private System.Windows.Forms.DataGridView dataGridView_Show;
    }
}