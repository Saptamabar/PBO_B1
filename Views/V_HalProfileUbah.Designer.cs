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
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbJabatan = new TextBox();
            tbNohp = new TextBox();
            tbUsername = new TextBox();
            tbNama = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            panelmain = new Panel();
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
            fotoprofile.Location = new Point(119, 92);
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
            panelprofileubah.Controls.Add(tbPassword);
            panelprofileubah.Controls.Add(tbEmail);
            panelprofileubah.Controls.Add(tbJabatan);
            panelprofileubah.Controls.Add(tbNohp);
            panelprofileubah.Controls.Add(tbUsername);
            panelprofileubah.Controls.Add(tbNama);
            panelprofileubah.Location = new Point(428, 92);
            panelprofileubah.Name = "panelprofileubah";
            panelprofileubah.Size = new Size(603, 373);
            panelprofileubah.TabIndex = 1;
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
            // tbJabatan
            // 
            tbJabatan.BorderStyle = BorderStyle.None;
            tbJabatan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbJabatan.Location = new Point(337, 79);
            tbJabatan.Name = "tbJabatan";
            tbJabatan.Size = new Size(229, 27);
            tbJabatan.TabIndex = 3;
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
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(584, 577);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.ForeColor = Color.Black;
            btnBatal.Location = new Point(353, 577);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // panelmain
            // 
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
        private TextBox tbJabatan;
        private TextBox tbNohp;
        private TextBox tbUsername;
        private Button btnBatal;
        private Panel panelmain;
    }
}
