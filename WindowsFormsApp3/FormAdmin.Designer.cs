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
            this.register_button.Location = new System.Drawing.Point(392, 328);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(129, 46);
            this.register_button.TabIndex = 21;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(573, 325);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(160, 49);
            this.login_button.TabIndex = 20;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(427, 171);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(71, 16);
            this.Label_Password.TabIndex = 19;
            this.Label_Password.Text = "PassWord";
            this.Label_Password.Click += new System.EventHandler(this.Label_Password_Click);
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Location = new System.Drawing.Point(430, 203);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.Size = new System.Drawing.Size(247, 22);
            this.TxtBox_Password.TabIndex = 18;
            this.TxtBox_Password.TextChanged += new System.EventHandler(this.TxtBox_Password_TextChanged);
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Location = new System.Drawing.Point(427, 74);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(76, 16);
            this.Label_UserName.TabIndex = 17;
            this.Label_UserName.Text = "User Name";
            this.Label_UserName.Click += new System.EventHandler(this.Label_UserName_Click);
            // 
            // TxtBoxt_UserName
            // 
            this.TxtBoxt_UserName.Location = new System.Drawing.Point(430, 106);
            this.TxtBoxt_UserName.Name = "TxtBoxt_UserName";
            this.TxtBoxt_UserName.Size = new System.Drawing.Size(247, 22);
            this.TxtBoxt_UserName.TabIndex = 16;
            this.TxtBoxt_UserName.TextChanged += new System.EventHandler(this.TxtBoxt_UserName_TextChanged);
            // 
            // RegisterAdmin
            // 
            this.RegisterAdmin.AutoSize = true;
            this.RegisterAdmin.Location = new System.Drawing.Point(237, 39);
            this.RegisterAdmin.Name = "RegisterAdmin";
            this.RegisterAdmin.Size = new System.Drawing.Size(99, 16);
            this.RegisterAdmin.TabIndex = 15;
            this.RegisterAdmin.Text = "Register Admin";
            this.RegisterAdmin.Click += new System.EventHandler(this.RegisterAdmin_Click);
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