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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalTambahAdmin));
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbNama = new TextBox();
            tbNohp = new TextBox();
            tbEmail = new TextBox();
            btnSimpan = new Button();
            btnKembali = new Button();
            panel1 = new Panel();
            FotoProfile = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FotoProfile).BeginInit();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(371, 158);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(366, 24);
            tbUsername.TabIndex = 7;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(371, 248);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(366, 24);
            tbPassword.TabIndex = 8;
            tbPassword.TextChanged += textBox2_TextChanged;
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.None;
            tbNama.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(371, 67);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(366, 24);
            tbNama.TabIndex = 9;
            tbNama.TextChanged += textBox3_TextChanged;
            // 
            // tbNohp
            // 
            tbNohp.BorderStyle = BorderStyle.None;
            tbNohp.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNohp.Location = new Point(371, 344);
            tbNohp.Margin = new Padding(2);
            tbNohp.Name = "tbNohp";
            tbNohp.Size = new Size(366, 24);
            tbNohp.TabIndex = 11;
            tbNohp.TextChanged += textBox5_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(371, 439);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(366, 24);
            tbEmail.TabIndex = 12;
            tbEmail.TextChanged += textBox6_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.White;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(210, 357);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 14;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button1_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.White;
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(58, 357);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 15;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Base_Form_Admin;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(FotoProfile);
            panel1.Controls.Add(tbNama);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(tbNohp);
            panel1.Controls.Add(btnKembali);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(tbPassword);
            panel1.Location = new Point(182, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 520);
            panel1.TabIndex = 16;
            // 
            // FotoProfile
            // 
            FotoProfile.BackColor = Color.White;
            FotoProfile.BackgroundImage = (Image)resources.GetObject("FotoProfile.BackgroundImage");
            FotoProfile.BackgroundImageLayout = ImageLayout.Zoom;
            FotoProfile.Location = new Point(102, 130);
            FotoProfile.Name = "FotoProfile";
            FotoProfile.Size = new Size(150, 200);
            FotoProfile.SizeMode = PictureBoxSizeMode.Zoom;
            FotoProfile.TabIndex = 16;
            FotoProfile.TabStop = false;
            FotoProfile.Click += FotoProfile_Click;
            // 
            // V_HalTambahAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "V_HalTambahAdmin";
            Size = new Size(1152, 810);
            Load += V_HalTambahAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FotoProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbNama;
        private TextBox tbNohp;
        private TextBox tbEmail;
        private Button btnSimpan;
        private Button btnKembali;
        private Panel panel1;
        private PictureBox FotoProfile;
    }
}
