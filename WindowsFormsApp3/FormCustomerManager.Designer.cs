namespace WindowsFormsApp3
{
    partial class FormCustomerManager
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
            this.login_tabelDataSet = new WindowsFormsApp3.login_tabelDataSet();
            this.logintabelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Hapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.login_tabelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logintabelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_tabelDataSet
            // 
            this.login_tabelDataSet.DataSetName = "login_tabelDataSet";
            this.login_tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logintabelDataSetBindingSource
            // 
            this.logintabelDataSetBindingSource.DataSource = this.login_tabelDataSet;
            this.logintabelDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 56;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "BarangPinjaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status Peminjaman";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(123, 222);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(135, 47);
            this.btn_Simpan.TabIndex = 5;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(277, 222);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(135, 47);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.Location = new System.Drawing.Point(433, 222);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(135, 47);
            this.btn_Hapus.TabIndex = 7;
            this.btn_Hapus.Text = "Hapus";
            this.btn_Hapus.UseVisualStyleBackColor = true;
            this.btn_Hapus.Click += new System.EventHandler(this.btn_Hapus_Click);
            // 
            // FormCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 615);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCustomerManager";
            this.Text = "FormCustomerManager";
            this.Load += new System.EventHandler(this.FormCustomerManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_tabelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logintabelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private login_tabelDataSet login_tabelDataSet;
        private System.Windows.Forms.BindingSource logintabelDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Hapus;
    }
}