namespace PBO_B1.Views
{
    partial class V_HalProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalProfile));
            Fotoprofile = new PictureBox();
            panelprofile = new Panel();
            LabelPassword = new Label();
            LabelEmail = new Label();
            LabelJabatan = new Label();
            LabelNoHP = new Label();
            LabelUsername = new Label();
            LabelNama = new Label();
            btnEdit = new Button();
            panelmain = new Panel();
            lblnama = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Fotoprofile).BeginInit();
            panelprofile.SuspendLayout();
            panelmain.SuspendLayout();
            SuspendLayout();
            // 
            // Fotoprofile
            // 
          
            Fotoprofile.BackColor = Color.White;
            Fotoprofile.BackgroundImage = (Image)resources.GetObject("Fotoprofile.BackgroundImage");
            Fotoprofile.BackgroundImageLayout = ImageLayout.Zoom;
            Fotoprofile.BorderStyle = BorderStyle.FixedSingle;
            Fotoprofile.Location = new Point(146, 171);
            Fotoprofile.Name = "Fotoprofile";
            Fotoprofile.Size = new Size(150, 200);
            Fotoprofile.SizeMode = PictureBoxSizeMode.Zoom;
            Fotoprofile.TabIndex = 0;
            Fotoprofile.TabStop = false;
            // 
            // panelprofile
            // 
            panelprofile.BackgroundImage = (Image)resources.GetObject("panelprofile.BackgroundImage");
            panelprofile.BackgroundImageLayout = ImageLayout.Zoom;
            panelprofile.Controls.Add(LabelPassword);
            panelprofile.Controls.Add(LabelEmail);
            panelprofile.Controls.Add(LabelJabatan);
            panelprofile.Controls.Add(LabelNoHP);
            panelprofile.Controls.Add(LabelUsername);
            panelprofile.Controls.Add(LabelNama);
            panelprofile.Location = new Point(446, 171);
            panelprofile.Name = "panelprofile";
            panelprofile.Size = new Size(603, 373);
            panelprofile.TabIndex = 1;
            // 
            // LabelPassword
            // 
            LabelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPassword.ForeColor = Color.Black;
            LabelPassword.Location = new Point(334, 276);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(236, 36);
            LabelPassword.TabIndex = 5;
            LabelPassword.Text = "Nama";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            LabelPassword.Click += LabelPassword_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEmail.ForeColor = Color.Black;
            LabelEmail.Location = new Point(334, 177);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(236, 36);
            LabelEmail.TabIndex = 4;
            LabelEmail.Text = "Nama";
            LabelEmail.TextAlign = ContentAlignment.MiddleLeft;
            LabelEmail.Click += LabelEmail_Click;
            // 
            // LabelJabatan
            // 
            LabelJabatan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelJabatan.ForeColor = Color.Black;
            LabelJabatan.Location = new Point(334, 76);
            LabelJabatan.Name = "LabelJabatan";
            LabelJabatan.Size = new Size(236, 36);
            LabelJabatan.TabIndex = 3;
            LabelJabatan.Text = "Nama";
            LabelJabatan.TextAlign = ContentAlignment.MiddleLeft;
            LabelJabatan.Click += LabelJabatan_Click;
            // 
            // LabelNoHP
            // 
            LabelNoHP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNoHP.ForeColor = Color.Black;
            LabelNoHP.Location = new Point(36, 276);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(236, 36);
            LabelNoHP.TabIndex = 2;
            LabelNoHP.Text = "Nama";
            LabelNoHP.TextAlign = ContentAlignment.MiddleLeft;
            LabelNoHP.Click += LabelNoHP_Click;
            // 
            // LabelUsername
            // 
            LabelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsername.ForeColor = Color.Black;
            LabelUsername.Location = new Point(36, 177);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(236, 36);
            LabelUsername.TabIndex = 1;
            LabelUsername.Text = "Nama";
            LabelUsername.TextAlign = ContentAlignment.MiddleLeft;
            LabelUsername.Click += LabelUsername_Click;
            // 
            // LabelNama
            // 
            LabelNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNama.ForeColor = Color.Black;
            LabelNama.Location = new Point(36, 76);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(236, 36);
            LabelNama.TabIndex = 0;
            LabelNama.Text = "Nama";
            LabelNama.TextAlign = ContentAlignment.MiddleLeft;
            LabelNama.Click += LabelNama_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 128, 0);
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(165, 498);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 46);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panelmain
            // 
            panelmain.Controls.Add(lblnama);
            panelmain.Controls.Add(label1);
            panelmain.Controls.Add(btnEdit);
            panelmain.Controls.Add(panelprofile);
            panelmain.Controls.Add(Fotoprofile);
            panelmain.Location = new Point(0, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1152, 810);
            panelmain.TabIndex = 3;
            panelmain.Paint += panelmain_Paint;
            // 
            // lblnama
            // 
            lblnama.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnama.ForeColor = Color.Black;
            lblnama.Location = new Point(359, 69);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(283, 52);
            lblnama.TabIndex = 4;
            lblnama.Text = "Selamat datang";
            lblnama.Click += lblnama_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(95, 69);
            label1.Name = "label1";
            label1.Size = new Size(283, 52);
            label1.TabIndex = 3;
            label1.Text = "Selamat Datang";
            // 
            // V_HalProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panelmain);
            DoubleBuffered = true;
            Name = "V_HalProfile";
            Size = new Size(1152, 810);
            ((System.ComponentModel.ISupportInitialize)Fotoprofile).EndInit();
            panelprofile.ResumeLayout(false);
            panelmain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Fotoprofile;
        private Panel panelprofile;
        private Label LabelNama;
        private Label LabelUsername;
        private Label LabelJabatan;
        private Label LabelNoHP;
        private Label LabelPassword;
        private Label LabelEmail;
        private Button btnEdit;
        private Panel panelmain;
        private Label label1;
        private Label lblnama;
    }
}
