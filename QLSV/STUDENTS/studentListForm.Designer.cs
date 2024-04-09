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
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginFormDbDataSet4 = new QLSV.LoginFormDbDataSet4();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginFormDbDataSet = new QLSV.LoginFormDbDataSet();
            this.studentTableAdapter = new QLSV.LoginFormDbDataSetTableAdapters.studentTableAdapter();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.studentTableAdapter1 = new QLSV.LoginFormDbDataSet4TableAdapters.studentTableAdapter();
            this.studentTableAdapter2 = new QLSV.LoginFormDbDataSet5TableAdapters.studentTableAdapter();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.Button_Save = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.loginFormDbDataSet4;
            // 
            // loginFormDbDataSet4
            // 
            this.loginFormDbDataSet4.DataSetName = "LoginFormDbDataSet4";
            this.loginFormDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.ButtonRefresh.BackColor = System.Drawing.Color.DarkBlue;
            this.ButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonRefresh.Location = new System.Drawing.Point(215, 382);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(164, 48);
            this.ButtonRefresh.TabIndex = 1;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonImport
            // 
            this.ButtonImport.BackColor = System.Drawing.Color.Fuchsia;
            this.ButtonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonImport.Location = new System.Drawing.Point(566, 388);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(182, 42);
            this.ButtonImport.TabIndex = 2;
            this.ButtonImport.Text = "IMPORT";
            this.ButtonImport.UseVisualStyleBackColor = false;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableAdapter2
            // 
            this.studentTableAdapter2.ClearBeforeFill = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 80;
            this.DataGridView1.Size = new System.Drawing.Size(1276, 350);
            this.DataGridView1.TabIndex = 3;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // Button_Save
            // 
            this.Button_Save.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Button_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Save.FillColor = System.Drawing.Color.Blue;
            this.Button_Save.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.ForeColor = System.Drawing.Color.White;
            this.Button_Save.Location = new System.Drawing.Point(951, 388);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(165, 42);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "Save_DB";
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // studentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 454);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.ButtonRefresh);
            this.Name = "studentListForm";
            this.Text = "studentListForm";
            this.Load += new System.EventHandler(this.studentListForm_Load);
            this.DoubleClick += new System.EventHandler(this.studentListForm_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void studentListForm_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion
        private LoginFormDbDataSet loginFormDbDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LoginFormDbDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button ButtonRefresh;
        private Button ButtonImport;
        private LoginFormDbDataSet4 loginFormDbDataSet4;
        private BindingSource studentBindingSource1;
        private LoginFormDbDataSet4TableAdapters.studentTableAdapter studentTableAdapter1;
        private BindingSource studentBindingSource2;
        private LoginFormDbDataSet5TableAdapters.studentTableAdapter studentTableAdapter2;
        private DataGridView DataGridView1;
        private OpenFileDialog openFD;
        private Guna.UI2.WinForms.Guna2Button Button_Save;
    }
}