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
            panel1 = new Panel();
            btnSimpan = new Button();
            tbNama = new TextBox();
            tbUsername = new TextBox();
            tbNohp = new TextBox();
            tbJabatan = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fotoprofile).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fotoprofile
            // 
            fotoprofile.BackgroundImage = (Image)resources.GetObject("fotoprofile.BackgroundImage");
            fotoprofile.BackgroundImageLayout = ImageLayout.Zoom;
            fotoprofile.Location = new Point(119, 92);
            fotoprofile.Name = "fotoprofile";
            fotoprofile.Size = new Size(150, 200);
            fotoprofile.TabIndex = 0;
            fotoprofile.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbJabatan);
            panel1.Controls.Add(tbNohp);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(tbNama);
            panel1.Location = new Point(428, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 373);
            panel1.TabIndex = 1;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(538, 593);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
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
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(38, 180);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(229, 27);
            tbUsername.TabIndex = 1;
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
            // tbJabatan
            // 
            tbJabatan.BorderStyle = BorderStyle.None;
            tbJabatan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbJabatan.Location = new Point(337, 79);
            tbJabatan.Name = "tbJabatan";
            tbJabatan.Size = new Size(229, 27);
            tbJabatan.TabIndex = 3;
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
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(337, 277);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(229, 27);
            tbPassword.TabIndex = 5;
            // 
            // V_HalProfileUbah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSimpan);
            Controls.Add(panel1);
            Controls.Add(fotoprofile);
            Name = "V_HalProfileUbah";
            Size = new Size(1152, 810);
            ((System.ComponentModel.ISupportInitialize)fotoprofile).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox fotoprofile;
        private Panel panel1;
        private Button btnSimpan;
        private TextBox tbNama;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbJabatan;
        private TextBox tbNohp;
        private TextBox tbUsername;
    }
}
