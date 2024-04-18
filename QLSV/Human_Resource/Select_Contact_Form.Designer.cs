namespace QLSV.Human_Resource
{
    partial class Select_Contact_Form
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
            this.dataGridViewSelectContact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelectContact
            // 
            this.dataGridViewSelectContact.AllowUserToAddRows = false;
            this.dataGridViewSelectContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectContact.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSelectContact.Name = "dataGridViewSelectContact";
            this.dataGridViewSelectContact.RowHeadersWidth = 51;
            this.dataGridViewSelectContact.RowTemplate.Height = 24;
            this.dataGridViewSelectContact.Size = new System.Drawing.Size(663, 555);
            this.dataGridViewSelectContact.TabIndex = 0;
            // 
            // Select_Contact_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 598);
            this.Controls.Add(this.dataGridViewSelectContact);
            this.Name = "Select_Contact_Form";
            this.Text = "Select_Contact_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSelectContact;
    }
}