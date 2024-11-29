namespace PBO_B1.Views
{
    partial class V_HalTambahAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbNama = new TextBox();
            tbNohp = new TextBox();
            tbEmail = new TextBox();
            cbJabatan = new ComboBox();
            btnSimpan = new Button();
            btnKembali = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(136, 175);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(136, 239);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(136, 309);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(136, 378);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 3;
            label4.Text = "Jabatan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(580, 175);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 4;
            label5.Text = "Foto profile";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(580, 239);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 5;
            label6.Text = "No. Hp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(580, 309);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(233, 172);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(341, 31);
            tbUsername.TabIndex = 7;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(233, 239);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(341, 31);
            tbPassword.TabIndex = 8;
            tbPassword.TextChanged += textBox2_TextChanged;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(233, 309);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(341, 31);
            tbNama.TabIndex = 9;
            tbNama.TextChanged += textBox3_TextChanged;
            // 
            // tbNohp
            // 
            tbNohp.Location = new Point(691, 239);
            tbNohp.Name = "tbNohp";
            tbNohp.Size = new Size(341, 31);
            tbNohp.TabIndex = 11;
            tbNohp.TextChanged += textBox5_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(691, 309);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(341, 31);
            tbEmail.TabIndex = 12;
            tbEmail.TextChanged += textBox6_TextChanged;
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "Owner", "Admin" });
            cbJabatan.Location = new Point(233, 378);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(182, 33);
            cbJabatan.TabIndex = 13;
            cbJabatan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.White;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(920, 473);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 14;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button1_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.White;
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(802, 473);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 15;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(496, 86);
            label8.Name = "label8";
            label8.Size = new Size(226, 38);
            label8.TabIndex = 16;
            label8.Text = "TAMBAH ADMIN";
            label8.Click += label8_Click;
            // 
            // V_HalTambahAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(cbJabatan);
            Controls.Add(tbEmail);
            Controls.Add(tbNohp);
            Controls.Add(tbNama);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "V_HalTambahAdmin";
            Size = new Size(1176, 673);
            Load += V_HalTambahAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbNama;
        private TextBox tbNohp;
        private TextBox tbEmail;
        private ComboBox cbJabatan;
        private Button btnSimpan;
        private Button btnKembali;
        private Label label8;
    }
}
