namespace QLSV
{
    partial class Manage_Student_Form
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.Label7 = new System.Windows.Forms.Label();
            this.ButtonAddStudent = new System.Windows.Forms.Button();
            this.ButtonEditStudent = new System.Windows.Forms.Button();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.buttonDownloadImage = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.loginFormDbDataSet2 = new QLSV.LoginFormDbDataSet2();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new QLSV.LoginFormDbDataSet2TableAdapters.studentTableAdapter();
            this.dataGridView_Search = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButtonFemale);
            this.GroupBox1.Controls.Add(this.RadioButtonMale);
            this.GroupBox1.Location = new System.Drawing.Point(149, 202);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(305, 53);
            this.GroupBox1.TabIndex = 33;
            this.GroupBox1.TabStop = false;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.ForeColor = System.Drawing.Color.White;
            this.RadioButtonFemale.Location = new System.Drawing.Point(149, 16);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(104, 29);
            this.RadioButtonFemale.TabIndex = 1;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.ForeColor = System.Drawing.Color.White;
            this.RadioButtonMale.Location = new System.Drawing.Point(13, 17);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(80, 29);
            this.RadioButtonMale.TabIndex = 0;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(13, 218);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(90, 25);
            this.Label7.TabIndex = 32;
            this.Label7.Text = "Gender:";
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStudent.ForeColor = System.Drawing.Color.White;
            this.ButtonAddStudent.Location = new System.Drawing.Point(55, 686);
            this.ButtonAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(132, 49);
            this.ButtonAddStudent.TabIndex = 31;
            this.ButtonAddStudent.Text = "Add";
            this.ButtonAddStudent.UseVisualStyleBackColor = false;
            // 
            // ButtonEditStudent
            // 
            this.ButtonEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.ButtonEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditStudent.ForeColor = System.Drawing.Color.White;
            this.ButtonEditStudent.Location = new System.Drawing.Point(228, 686);
            this.ButtonEditStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonEditStudent.Name = "ButtonEditStudent";
            this.ButtonEditStudent.Size = new System.Drawing.Size(141, 49);
            this.ButtonEditStudent.TabIndex = 30;
            this.ButtonEditStudent.Text = "Edit";
            this.ButtonEditStudent.UseVisualStyleBackColor = false;
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.Location = new System.Drawing.Point(149, 606);
            this.ButtonUploadImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(161, 28);
            this.ButtonUploadImage.TabIndex = 29;
            this.ButtonUploadImage.Text = "Upload";
            this.ButtonUploadImage.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(19, 432);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 25);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Picture:";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(149, 314);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(303, 99);
            this.TextBoxAddress.TabIndex = 26;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(13, 318);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(99, 25);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Address:";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.Location = new System.Drawing.Point(149, 268);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(304, 30);
            this.TextBoxPhone.TabIndex = 24;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(13, 268);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 25);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Phone:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(152, 170);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(304, 22);
            this.DateTimePicker1.TabIndex = 22;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(13, 171);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(108, 25);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "BirthDate:";
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLname.Location = new System.Drawing.Point(152, 116);
            this.TextBoxLname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(301, 30);
            this.TextBoxLname.TabIndex = 20;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(13, 119);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 25);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Last Name:";
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFname.Location = new System.Drawing.Point(152, 64);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(301, 30);
            this.TextBoxFname.TabIndex = 18;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(13, 68);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(123, 25);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(13, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(157, 25);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(152, 22);
            this.txtStudentID.TabIndex = 35;
            // 
            // buttonDownloadImage
            // 
            this.buttonDownloadImage.Location = new System.Drawing.Point(317, 607);
            this.buttonDownloadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadImage.Name = "buttonDownloadImage";
            this.buttonDownloadImage.Size = new System.Drawing.Size(148, 25);
            this.buttonDownloadImage.TabIndex = 36;
            this.buttonDownloadImage.Text = "Download";
            this.buttonDownloadImage.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.DeepPink;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(408, 686);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(125, 49);
            this.buttonRemove.TabIndex = 38;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(571, 686);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(159, 49);
            this.buttonReset.TabIndex = 39;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(149, 426);
            this.PictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(316, 175);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxStudentImage.TabIndex = 28;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(468, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Search Fname, Lname, Address";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(792, 23);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(345, 30);
            this.textBox_Search.TabIndex = 41;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Chartreuse;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Search.Location = new System.Drawing.Point(1163, 18);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(139, 39);
            this.button_Search.TabIndex = 42;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // loginFormDbDataSet2
            // 
            this.loginFormDbDataSet2.DataSetName = "LoginFormDbDataSet2";
            this.loginFormDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.loginFormDbDataSet2;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_Search
            // 
            this.dataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Search.Location = new System.Drawing.Point(475, 71);
            this.dataGridView_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Search.Name = "dataGridView_Search";
            this.dataGridView_Search.RowHeadersWidth = 51;
            this.dataGridView_Search.RowTemplate.Height = 24;
            this.dataGridView_Search.Size = new System.Drawing.Size(827, 566);
            this.dataGridView_Search.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Moccasin;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1100, 655);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 29);
            this.label10.TabIndex = 44;
            this.label10.Text = "TotalStudent:   ";
            // 
            // Manage_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1329, 816);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonDownloadImage);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.ButtonAddStudent);
            this.Controls.Add(this.ButtonEditStudent);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Manage_Student_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButtonFemale;
        internal System.Windows.Forms.RadioButton RadioButtonMale;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button ButtonAddStudent;
        internal System.Windows.Forms.Button ButtonEditStudent;
        internal System.Windows.Forms.Button ButtonUploadImage;
        internal System.Windows.Forms.PictureBox PictureBoxStudentImage;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBoxAddress;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBoxPhone;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBoxLname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxFname;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button buttonDownloadImage;
        internal System.Windows.Forms.Button buttonRemove;
        internal System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private LoginFormDbDataSet2 loginFormDbDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LoginFormDbDataSet2TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Search;
        private System.Windows.Forms.Label label10;
    }
}
