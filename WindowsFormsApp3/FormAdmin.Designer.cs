namespace WindowsFormsApp3
{
    partial class FormAdmin
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
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.Label_Password = new System.Windows.Forms.Label();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.TxtBoxt_UserName = new System.Windows.Forms.TextBox();
            this.RegisterAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(392, 346);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(128, 44);
            this.register_button.TabIndex = 14;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(573, 343);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(167, 51);
            this.login_button.TabIndex = 13;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(427, 189);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(71, 16);
            this.Label_Password.TabIndex = 12;
            this.Label_Password.Text = "PassWord";
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Location = new System.Drawing.Point(430, 221);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.Size = new System.Drawing.Size(246, 22);
            this.TxtBox_Password.TabIndex = 11;
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Location = new System.Drawing.Point(427, 92);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(76, 16);
            this.Label_UserName.TabIndex = 10;
            this.Label_UserName.Text = "User Name";
            // 
            // TxtBoxt_UserName
            // 
            this.TxtBoxt_UserName.Location = new System.Drawing.Point(430, 124);
            this.TxtBoxt_UserName.Name = "TxtBoxt_UserName";
            this.TxtBoxt_UserName.Size = new System.Drawing.Size(246, 22);
            this.TxtBoxt_UserName.TabIndex = 9;
            // 
            // RegisterAdmin
            // 
            this.RegisterAdmin.AutoSize = true;
            this.RegisterAdmin.Location = new System.Drawing.Point(237, 57);
            this.RegisterAdmin.Name = "RegisterAdmin";
            this.RegisterAdmin.Size = new System.Drawing.Size(99, 16);
            this.RegisterAdmin.TabIndex = 8;
            this.RegisterAdmin.Text = "Register Admin";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TxtBox_Password);
            this.Controls.Add(this.Label_UserName);
            this.Controls.Add(this.TxtBoxt_UserName);
            this.Controls.Add(this.RegisterAdmin);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.TextBox TxtBoxt_UserName;
        private System.Windows.Forms.Label RegisterAdmin;
    }
}