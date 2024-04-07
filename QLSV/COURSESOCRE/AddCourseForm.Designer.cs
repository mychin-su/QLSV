namespace QLSV.COURSE
{
    partial class AddCourseForm
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
            this.label_SelectCourse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Label = new System.Windows.Forms.TextBox();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.textBox_Period = new System.Windows.Forms.TextBox();
            this.textBox_CourseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Semester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_SelectCourse
            // 
            this.label_SelectCourse.AutoSize = true;
            this.label_SelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectCourse.Location = new System.Drawing.Point(19, 38);
            this.label_SelectCourse.Name = "label_SelectCourse";
            this.label_SelectCourse.Size = new System.Drawing.Size(116, 25);
            this.label_SelectCourse.TabIndex = 0;
            this.label_SelectCourse.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // textBox_Label
            // 
            this.textBox_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Label.Location = new System.Drawing.Point(217, 108);
            this.textBox_Label.Name = "textBox_Label";
            this.textBox_Label.Size = new System.Drawing.Size(397, 30);
            this.textBox_Label.TabIndex = 5;
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(217, 245);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(397, 123);
            this.richTextBox_Description.TabIndex = 9;
            this.richTextBox_Description.Text = "";
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.GreenYellow;
            this.Button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(217, 391);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(397, 47);
            this.Button_Add.TabIndex = 10;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // textBox_Period
            // 
            this.textBox_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Period.Location = new System.Drawing.Point(217, 178);
            this.textBox_Period.Name = "textBox_Period";
            this.textBox_Period.Size = new System.Drawing.Size(205, 30);
            this.textBox_Period.TabIndex = 11;
            // 
            // textBox_CourseID
            // 
            this.textBox_CourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseID.Location = new System.Drawing.Point(217, 35);
            this.textBox_CourseID.Name = "textBox_CourseID";
            this.textBox_CourseID.Size = new System.Drawing.Size(136, 30);
            this.textBox_CourseID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(414, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Semester:";
            // 
            // comboBox_Semester
            // 
            this.comboBox_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Semester.FormattingEnabled = true;
            this.comboBox_Semester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_Semester.Location = new System.Drawing.Point(548, 38);
            this.comboBox_Semester.Name = "comboBox_Semester";
            this.comboBox_Semester.Size = new System.Drawing.Size(66, 33);
            this.comboBox_Semester.TabIndex = 15;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.comboBox_Semester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CourseID);
            this.Controls.Add(this.textBox_Period);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.textBox_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_SelectCourse);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Label;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.TextBox textBox_Period;
        private System.Windows.Forms.TextBox textBox_CourseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Semester;
    }
}