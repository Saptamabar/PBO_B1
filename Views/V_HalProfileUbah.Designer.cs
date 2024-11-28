namespace PBO_B1.Views
{
    partial class V_HalProfileUbah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalProfileUbah));
            fotoprofile = new PictureBox();
            panelprofileubah = new Panel();
            labeljabatan = new Label();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbNohp = new TextBox();
            tbUsername = new TextBox();
            tbNama = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            panelmain = new Panel();
            lblnama = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fotoprofile).BeginInit();
            panelprofileubah.SuspendLayout();
            panelmain.SuspendLayout();
            SuspendLayout();
            // 
            // fotoprofile
            // 
            fotoprofile.BackColor = Color.White;
            fotoprofile.BackgroundImage = (Image)resources.GetObject("fotoprofile.BackgroundImage");
            fotoprofile.BackgroundImageLayout = ImageLayout.Zoom;
            fotoprofile.BorderStyle = BorderStyle.FixedSingle;
            fotoprofile.Location = new Point(146, 171);
            fotoprofile.Name = "fotoprofile";
            fotoprofile.Size = new Size(150, 200);
            fotoprofile.SizeMode = PictureBoxSizeMode.Zoom;
            fotoprofile.TabIndex = 0;
            fotoprofile.TabStop = false;
            fotoprofile.Click += fotoprofile_Click;
            // 
            // panelprofileubah
            // 
            panelprofileubah.BackgroundImage = (Image)resources.GetObject("panelprofileubah.BackgroundImage");
            panelprofileubah.BackgroundImageLayout = ImageLayout.Zoom;
            panelprofileubah.Controls.Add(labeljabatan);
            panelprofileubah.Controls.Add(tbPassword);
            panelprofileubah.Controls.Add(tbEmail);
            panelprofileubah.Controls.Add(tbNohp);
            panelprofileubah.Controls.Add(tbUsername);
            panelprofileubah.Controls.Add(tbNama);
            panelprofileubah.Location = new Point(446, 171);
            panelprofileubah.Name = "panelprofileubah";
            panelprofileubah.Size = new Size(603, 373);
            panelprofileubah.TabIndex = 1;
            // 
            // labeljabatan
            // 
            labeljabatan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeljabatan.ForeColor = Color.Black;
            labeljabatan.Location = new Point(337, 79);
            labeljabatan.Name = "labeljabatan";
            labeljabatan.Size = new Size(229, 27);
            labeljabatan.TabIndex = 6;
            labeljabatan.Text = "label2";
            labeljabatan.Click += labeljabatan_Click;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(337, 277);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(229, 27);
            tbPassword.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(337, 180);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(229, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbNohp
            // 
            tbNohp.BorderStyle = BorderStyle.None;
            tbNohp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNohp.Location = new Point(38, 277);
            tbNohp.Name = "tbNohp";
            tbNohp.Size = new Size(229, 27);
            tbNohp.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(38, 180);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(229, 27);
            tbUsername.TabIndex = 1;
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.None;
            tbNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(38, 79);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(229, 27);
            tbNama.TabIndex = 0;
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(255, 128, 0);
            btnSimpan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(625, 626);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(140, 49);
            btnSimpan.TabIndex = 1;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(255, 128, 0);
            btnBatal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.Black;
            btnBatal.Location = new Point(316, 626);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(140, 49);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // panelmain
            // 
            panelmain.BackColor = Color.White;
            panelmain.Controls.Add(lblnama);
            panelmain.Controls.Add(label1);
            panelmain.Controls.Add(btnBatal);
            panelmain.Controls.Add(fotoprofile);
            panelmain.Controls.Add(btnSimpan);
            panelmain.Controls.Add(panelprofileubah);
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1152, 810);
            panelmain.TabIndex = 4;
            // 
            // lblnama
            // 
            lblnama.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnama.ForeColor = Color.Black;
            lblnama.Location = new Point(359, 69);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(283, 52);
            lblnama.TabIndex = 5;
            lblnama.Text = "Selamat Datang";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(95, 69);
            label1.Name = "label1";
            label1.Size = new Size(283, 52);
            label1.TabIndex = 4;
            label1.Text = "Selamat Datang";
            // 
            // V_HalProfileUbah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelmain);
            Name = "V_HalProfileUbah";
            Size = new Size(1152, 810);
            Load += V_HalProfileUbah_Load;
            ((System.ComponentModel.ISupportInitialize)fotoprofile).EndInit();
            panelprofileubah.ResumeLayout(false);
            panelprofileubah.PerformLayout();
            panelmain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox fotoprofile;
        private Panel panelprofileubah;
        private Button btnSimpan;
        private TextBox tbNama;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbNohp;
        private TextBox tbUsername;
        private Button btnBatal;
        private Panel panelmain;
        private Label label1;
        private Label lblnama;
        private Label labeljabatan;
    }
}
