using System;
using System.Windows.Forms;

namespace QLSV
{
    partial class studentListForm
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginFormDbDataSet = new QLSV.LoginFormDbDataSet();
            this.studentTableAdapter = new QLSV.LoginFormDbDataSetTableAdapters.studentTableAdapter();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.loginFormDbDataSet4 = new QLSV.LoginFormDbDataSet4();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new QLSV.LoginFormDbDataSet4TableAdapters.studentTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.SelectedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.lname,
            this.bdate,
            this.gender,
            this.phone,
            this.address,
            this.picture,
            this.SelectedCourse});
            this.DataGridView1.DataSource = this.studentBindingSource1;
            this.DataGridView1.Location = new System.Drawing.Point(49, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 40;
            this.DataGridView1.RowTemplate.Height = 80;
            this.DataGridView1.Size = new System.Drawing.Size(1248, 280);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.loginFormDbDataSet;
            // 
            // loginFormDbDataSet
            // 
            this.loginFormDbDataSet.DataSetName = "LoginFormDbDataSet";
            this.loginFormDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.Location = new System.Drawing.Point(385, 330);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(164, 43);
            this.ButtonRefresh.TabIndex = 1;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonImport
            // 
            this.ButtonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImport.Location = new System.Drawing.Point(714, 331);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(182, 42);
            this.ButtonImport.TabIndex = 2;
            this.ButtonImport.Text = "IMPORT";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // loginFormDbDataSet4
            // 
            this.loginFormDbDataSet4.DataSetName = "LoginFormDbDataSet4";
            this.loginFormDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.loginFormDbDataSet4;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "StudentId";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fname";
            this.Column2.HeaderText = "FirstName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "LastName";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            // 
            // bdate
            // 
            this.bdate.DataPropertyName = "bdate";
            this.bdate.HeaderText = "BirthDate";
            this.bdate.MinimumWidth = 6;
            this.bdate.Name = "bdate";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // picture
            // 
            this.picture.DataPropertyName = "picture";
            this.picture.HeaderText = "Picture";
            this.picture.MinimumWidth = 6;
            this.picture.Name = "picture";
            // 
            // SelectedCourse
            // 
            this.SelectedCourse.DataPropertyName = "SelectedCourse";
            this.SelectedCourse.HeaderText = "SelectedCourse";
            this.SelectedCourse.MinimumWidth = 6;
            this.SelectedCourse.Name = "SelectedCourse";
            // 
            // studentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 422);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.DataGridView1);
            this.Name = "studentListForm";
            this.Text = "studentListForm";
            this.Load += new System.EventHandler(this.studentListForm_Load);
            this.DoubleClick += new System.EventHandler(this.studentListForm_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private void studentListForm_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private LoginFormDbDataSet loginFormDbDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LoginFormDbDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button ButtonRefresh;
        private Button ButtonImport;
        private LoginFormDbDataSet4 loginFormDbDataSet4;
        private BindingSource studentBindingSource1;
        private LoginFormDbDataSet4TableAdapters.studentTableAdapter studentTableAdapter1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn lname;
        private DataGridViewTextBoxColumn bdate;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private DataGridViewImageColumn picture;
        private DataGridViewTextBoxColumn SelectedCourse;
    }
}