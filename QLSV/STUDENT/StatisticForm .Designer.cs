namespace QLSV
{
    partial class Statistic
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
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.LabelMale = new System.Windows.Forms.Label();
            this.LabelFemale = new System.Windows.Forms.Label();
            this.PanelTotal.SuspendLayout();
            this.PanelMale.SuspendLayout();
            this.PanelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTotal
            // 
            this.PanelTotal.BackColor = System.Drawing.Color.Blue;
            this.PanelTotal.Controls.Add(this.LabelTotal);
            this.PanelTotal.Location = new System.Drawing.Point(0, 1);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(590, 164);
            this.PanelTotal.TabIndex = 0;
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.Blue;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTotal.Location = new System.Drawing.Point(-5, -4);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(598, 167);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "Total Student: 100%";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotal.MouseEnter += new System.EventHandler(this.LabelTotal_MouseEnter);
            this.LabelTotal.MouseLeave += new System.EventHandler(this.LabelTotal_MouseLeave);
            // 
            // PanelMale
            // 
            this.PanelMale.BackColor = System.Drawing.Color.Fuchsia;
            this.PanelMale.Controls.Add(this.LabelMale);
            this.PanelMale.Location = new System.Drawing.Point(0, 164);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(300, 165);
            this.PanelMale.TabIndex = 1;
            // 
            // PanelFemale
            // 
            this.PanelFemale.BackColor = System.Drawing.Color.Crimson;
            this.PanelFemale.Controls.Add(this.LabelFemale);
            this.PanelFemale.Location = new System.Drawing.Point(296, 164);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(294, 165);
            this.PanelFemale.TabIndex = 2;
            // 
            // LabelMale
            // 
            this.LabelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelMale.Location = new System.Drawing.Point(0, 0);
            this.LabelMale.Name = "LabelMale";
            this.LabelMale.Size = new System.Drawing.Size(297, 165);
            this.LabelMale.TabIndex = 0;
            this.LabelMale.Text = "Male: 50%";
            this.LabelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMale.MouseEnter += new System.EventHandler(this.LabelMale_MouseEnter);
            this.LabelMale.MouseLeave += new System.EventHandler(this.LabelMale_MouseLeave);
            // 
            // LabelFemale
            // 
            this.LabelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelFemale.Location = new System.Drawing.Point(3, 1);
            this.LabelFemale.Name = "LabelFemale";
            this.LabelFemale.Size = new System.Drawing.Size(288, 164);
            this.LabelFemale.TabIndex = 0;
            this.LabelFemale.Text = "Female: 50%";
            this.LabelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelFemale.MouseEnter += new System.EventHandler(this.LabelFemale_MouseEnter);
            this.LabelFemale.MouseLeave += new System.EventHandler(this.LabelFemale_MouseLeave);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 322);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.PanelMale);
            this.Controls.Add(this.PanelTotal);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.PanelTotal.ResumeLayout(false);
            this.PanelMale.ResumeLayout(false);
            this.PanelFemale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelMale;
        private System.Windows.Forms.Label LabelFemale;
    }
}