namespace QLSV.COURSE
{
    partial class EditCoureseForm
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
            this.comboBox_SelectCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Label = new System.Windows.Forms.TextBox();
            this.numericUpDown_Period = new System.Windows.Forms.NumericUpDown();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ComboBox_Semester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Period)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_SelectCourse
            // 
            this.comboBox_SelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectCourse.FormattingEnabled = true;
            this.comboBox_SelectCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_SelectCourse.Location = new System.Drawing.Point(278, 27);
            this.comboBox_SelectCourse.Name = "comboBox_SelectCourse";
            this.comboBox_SelectCourse.Size = new System.Drawing.Size(278, 33);
            this.comboBox_SelectCourse.TabIndex = 0;
            this.comboBox_SelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Course:";
            // 
            // textBox_Label
            // 
            this.textBox_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Label.Location = new System.Drawing.Point(278, 88);
            this.textBox_Label.Name = "textBox_Label";
            this.textBox_Label.Size = new System.Drawing.Size(278, 30);
            this.textBox_Label.TabIndex = 2;
            // 
            // numericUpDown_Period
            // 
            this.numericUpDown_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Period.Location = new System.Drawing.Point(278, 141);
            this.numericUpDown_Period.Name = "numericUpDown_Period";
            this.numericUpDown_Period.Size = new System.Drawing.Size(278, 30);
            this.numericUpDown_Period.TabIndex = 3;
            this.numericUpDown_Period.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_description.Location = new System.Drawing.Point(278, 185);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(278, 89);
            this.richTextBox_description.TabIndex = 4;
            this.richTextBox_description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // Button_Edit
            // 
            this.Button_Edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Edit.Location = new System.Drawing.Point(316, 395);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(187, 43);
            this.Button_Edit.TabIndex = 8;
            this.Button_Edit.Text = "Edit";
            this.Button_Edit.UseVisualStyleBackColor = false;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Semester:";
            // 
            // guna2ComboBox_Semester
            // 
            this.guna2ComboBox_Semester.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox_Semester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox_Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox_Semester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox_Semester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox_Semester.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox_Semester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox_Semester.ItemHeight = 30;
            this.guna2ComboBox_Semester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.guna2ComboBox_Semester.Location = new System.Drawing.Point(278, 293);
            this.guna2ComboBox_Semester.Name = "guna2ComboBox_Semester";
            this.guna2ComboBox_Semester.Size = new System.Drawing.Size(85, 36);
            this.guna2ComboBox_Semester.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(134, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Teacher:";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTeacher.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxTeacher.ItemHeight = 30;
            this.comboBoxTeacher.Location = new System.Drawing.Point(278, 341);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(263, 36);
            this.comboBoxTeacher.TabIndex = 12;
            // 
            // EditCoureseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2ComboBox_Semester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.numericUpDown_Period);
            this.Controls.Add(this.textBox_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_SelectCourse);
            this.Name = "EditCoureseForm";
            this.Text = "EditCoureseForm";
            this.Load += new System.EventHandler(this.EditCoureseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SelectCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown_Period;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox_Semester;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTeacher;
    }
}