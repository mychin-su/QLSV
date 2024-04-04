namespace QLSV.COURSESOCRE
{
    partial class RemoveScoreForm
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
            this.dataGridView_RemoveScore = new System.Windows.Forms.DataGridView();
            this.Button_RemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RemoveScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_RemoveScore
            // 
            this.dataGridView_RemoveScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RemoveScore.Location = new System.Drawing.Point(34, 30);
            this.dataGridView_RemoveScore.Name = "dataGridView_RemoveScore";
            this.dataGridView_RemoveScore.RowHeadersWidth = 51;
            this.dataGridView_RemoveScore.RowTemplate.Height = 24;
            this.dataGridView_RemoveScore.Size = new System.Drawing.Size(741, 339);
            this.dataGridView_RemoveScore.TabIndex = 0;
            this.dataGridView_RemoveScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RemoveScore_CellClick);
            // 
            // Button_RemoveScore
            // 
            this.Button_RemoveScore.BackColor = System.Drawing.Color.Red;
            this.Button_RemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_RemoveScore.Location = new System.Drawing.Point(294, 390);
            this.Button_RemoveScore.Name = "Button_RemoveScore";
            this.Button_RemoveScore.Size = new System.Drawing.Size(152, 38);
            this.Button_RemoveScore.TabIndex = 1;
            this.Button_RemoveScore.Text = "Remove Score";
            this.Button_RemoveScore.UseVisualStyleBackColor = false;
            this.Button_RemoveScore.Click += new System.EventHandler(this.Button_RemoveScore_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_RemoveScore);
            this.Controls.Add(this.dataGridView_RemoveScore);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RemoveScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_RemoveScore;
        private System.Windows.Forms.Button Button_RemoveScore;
    }
}