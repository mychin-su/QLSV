namespace QLSV
{
    partial class Login_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.btt_Login = new System.Windows.Forms.Button();
            this.btt_Cancel = new System.Windows.Forms.Button();
            this.linkLabel_New = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_passWord = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonHr = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(27, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 100;
            this.label2.Text = "User name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(27, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 100;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(227, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 54);
            this.label4.TabIndex = 100;
            this.label4.Text = "LOGIN";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(217, 174);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxUsername.Multiline = true;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(232, 36);
            this.TextBoxUsername.TabIndex = 10;
            this.TextBoxUsername.TabStop = false;
            this.toolTip1.SetToolTip(this.TextBoxUsername, "Vui lòng nhập user");
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(217, 246);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(232, 34);
            this.TextBoxPassword.TabIndex = 12;
            this.toolTip1.SetToolTip(this.TextBoxPassword, "Vui lòng nhập PassWord");
            // 
            // btt_Login
            // 
            this.btt_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btt_Login.Location = new System.Drawing.Point(63, 327);
            this.btt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(137, 45);
            this.btt_Login.TabIndex = 14;
            this.btt_Login.Text = "Login";
            this.btt_Login.UseVisualStyleBackColor = false;
            this.btt_Login.Click += new System.EventHandler(this.btt_Login_Click);
            // 
            // btt_Cancel
            // 
            this.btt_Cancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btt_Cancel.Location = new System.Drawing.Point(292, 327);
            this.btt_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Cancel.Name = "btt_Cancel";
            this.btt_Cancel.Size = new System.Drawing.Size(157, 45);
            this.btt_Cancel.TabIndex = 16;
            this.btt_Cancel.Text = "Cancel";
            this.btt_Cancel.UseVisualStyleBackColor = false;
            // 
            // linkLabel_New
            // 
            this.linkLabel_New.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_New.AutoSize = true;
            this.linkLabel_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_New.LinkColor = System.Drawing.Color.LawnGreen;
            this.linkLabel_New.Location = new System.Drawing.Point(10, 458);
            this.linkLabel_New.Name = "linkLabel_New";
            this.linkLabel_New.Size = new System.Drawing.Size(163, 20);
            this.linkLabel_New.TabIndex = 18;
            this.linkLabel_New.TabStop = true;
            this.linkLabel_New.Text = "Create New User?";
            this.linkLabel_New.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_NewUser);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 500;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Vui lòng nhập user";
            // 
            // checkBox_passWord
            // 
            this.checkBox_passWord.AutoSize = true;
            this.checkBox_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_passWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_passWord.Location = new System.Drawing.Point(217, 294);
            this.checkBox_passWord.Name = "checkBox_passWord";
            this.checkBox_passWord.Size = new System.Drawing.Size(178, 26);
            this.checkBox_passWord.TabIndex = 102;
            this.checkBox_passWord.Text = "Show PassWord";
            this.checkBox_passWord.UseVisualStyleBackColor = true;
            this.checkBox_passWord.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Location = new System.Drawing.Point(314, 458);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 20);
            this.linkLabel1.TabIndex = 103;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ForgetPassWord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonStudent.Location = new System.Drawing.Point(55, 398);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(108, 29);
            this.radioButtonStudent.TabIndex = 104;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonHr
            // 
            this.radioButtonHr.AutoSize = true;
            this.radioButtonHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonHr.Location = new System.Drawing.Point(227, 398);
            this.radioButtonHr.Name = "radioButtonHr";
            this.radioButtonHr.Size = new System.Drawing.Size(194, 29);
            this.radioButtonHr.TabIndex = 105;
            this.radioButtonHr.TabStop = true;
            this.radioButtonHr.Text = "Human Rerource";
            this.radioButtonHr.UseVisualStyleBackColor = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(461, 493);
            this.Controls.Add(this.radioButtonHr);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox_passWord);
            this.Controls.Add(this.linkLabel_New);
            this.Controls.Add(this.btt_Cancel);
            this.Controls.Add(this.btt_Login);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button btt_Login;
        private System.Windows.Forms.Button btt_Cancel;
        private System.Windows.Forms.LinkLabel linkLabel_New;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox_passWord;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonHr;
    }
}

