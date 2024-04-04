namespace QLSV.COURSESOCRE
{
    partial class PrintCourseForm
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
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Location = new System.Drawing.Point(32, 25);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.RowHeadersWidth = 51;
            this.dataGridView_Course.RowTemplate.Height = 24;
            this.dataGridView_Course.Size = new System.Drawing.Size(740, 346);
            this.dataGridView_Course.TabIndex = 0;
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.Blue;
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Save.Location = new System.Drawing.Point(32, 387);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(126, 51);
            this.Button_Save.TabIndex = 1;
            this.Button_Save.Text = "To File";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Print
            // 
            this.Button_Print.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Print.Location = new System.Drawing.Point(187, 387);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(137, 51);
            this.Button_Print.TabIndex = 2;
            this.Button_Print.Text = "Print";
            this.Button_Print.UseVisualStyleBackColor = false;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.dataGridView_Course);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Print;
    }
}