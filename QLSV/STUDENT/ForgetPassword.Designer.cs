namespace QLSV
{
    partial class ForgetPassword
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
            this.textBox_Gmail = new System.Windows.Forms.TextBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.button_SendCode = new System.Windows.Forms.Button();
            this.button_VerifyCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forget PassWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code";
            // 
            // textBox_Gmail
            // 
            this.textBox_Gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Gmail.Location = new System.Drawing.Point(224, 163);
            this.textBox_Gmail.Name = "textBox_Gmail";
            this.textBox_Gmail.Size = new System.Drawing.Size(333, 30);
            this.textBox_Gmail.TabIndex = 3;
            // 
            // textBox_Code
            // 
            this.textBox_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Code.Location = new System.Drawing.Point(224, 248);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(333, 30);
            this.textBox_Code.TabIndex = 4;
            // 
            // button_SendCode
            // 
            this.button_SendCode.BackColor = System.Drawing.Color.Lime;
            this.button_SendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SendCode.Location = new System.Drawing.Point(603, 156);
            this.button_SendCode.Name = "button_SendCode";
            this.button_SendCode.Size = new System.Drawing.Size(151, 43);
            this.button_SendCode.TabIndex = 5;
            this.button_SendCode.Text = "SendCode";
            this.button_SendCode.UseVisualStyleBackColor = false;
            this.button_SendCode.Click += new System.EventHandler(this.button_SendCode_Click);
            // 
            // button_VerifyCode
            // 
            this.button_VerifyCode.BackColor = System.Drawing.Color.Blue;
            this.button_VerifyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VerifyCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_VerifyCode.Location = new System.Drawing.Point(297, 324);
            this.button_VerifyCode.Name = "button_VerifyCode";
            this.button_VerifyCode.Size = new System.Drawing.Size(160, 47);
            this.button_VerifyCode.TabIndex = 6;
            this.button_VerifyCode.Text = "Verify Code";
            this.button_VerifyCode.UseVisualStyleBackColor = false;
            this.button_VerifyCode.Click += new System.EventHandler(this.button_VerifyCode_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_VerifyCode);
            this.Controls.Add(this.button_SendCode);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.textBox_Gmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Gmail;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Button button_SendCode;
        private System.Windows.Forms.Button button_VerifyCode;
    }
}