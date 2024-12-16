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
            panelprofile = new Panel();
            LabelPassword = new Label();
            LabelEmail = new Label();
            LabelJabatan = new Label();
            LabelNoHP = new Label();
            LabelUsername = new Label();
            LabelNama = new Label();
            Fotoprofile = new PictureBox();
            btnEdit = new Button();
            label1 = new Label();
            lblnama = new Label();
            panelprofile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Fotoprofile).BeginInit();
            SuspendLayout();
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
            panelprofile.Margin = new Padding(2);
            panelprofile.Name = "panelprofile";
            panelprofile.Size = new Size(603, 373);
            panelprofile.TabIndex = 1;
            // 
            // LabelPassword
            // 
            LabelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPassword.ForeColor = Color.Black;
            LabelPassword.Location = new Point(336, 279);
            LabelPassword.Margin = new Padding(2, 0, 2, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(189, 29);
            LabelPassword.TabIndex = 5;
            LabelPassword.Text = "Nama";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            LabelPassword.Click += LabelPassword_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEmail.ForeColor = Color.Black;
            LabelEmail.Location = new Point(336, 181);
            LabelEmail.Margin = new Padding(2, 0, 2, 0);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(189, 29);
            LabelEmail.TabIndex = 4;
            LabelEmail.Text = "Nama";
            LabelEmail.TextAlign = ContentAlignment.MiddleLeft;
            LabelEmail.Click += LabelEmail_Click;
            // 
            // LabelJabatan
            // 
            LabelJabatan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelJabatan.ForeColor = Color.Black;
            LabelJabatan.Location = new Point(336, 79);
            LabelJabatan.Margin = new Padding(2, 0, 2, 0);
            LabelJabatan.Name = "LabelJabatan";
            LabelJabatan.Size = new Size(189, 29);
            LabelJabatan.TabIndex = 3;
            LabelJabatan.Text = "Nama";
            LabelJabatan.TextAlign = ContentAlignment.MiddleLeft;
            LabelJabatan.Click += LabelJabatan_Click;
            // 
            // LabelNoHP
            // 
            LabelNoHP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNoHP.ForeColor = Color.Black;
            LabelNoHP.Location = new Point(38, 280);
            LabelNoHP.Margin = new Padding(2, 0, 2, 0);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(189, 29);
            LabelNoHP.TabIndex = 2;
            LabelNoHP.Text = "Nama";
            LabelNoHP.TextAlign = ContentAlignment.MiddleLeft;
            LabelNoHP.Click += LabelNoHP_Click;
            // 
            // LabelUsername
            // 
            LabelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsername.ForeColor = Color.Black;
            LabelUsername.Location = new Point(38, 181);
            LabelUsername.Margin = new Padding(2, 0, 2, 0);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(189, 29);
            LabelUsername.TabIndex = 1;
            LabelUsername.Text = "Nama";
            LabelUsername.TextAlign = ContentAlignment.MiddleLeft;
            LabelUsername.Click += LabelUsername_Click;
            // 
            // LabelNama
            // 
            LabelNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNama.ForeColor = Color.Black;
            LabelNama.Location = new Point(38, 79);
            LabelNama.Margin = new Padding(2, 0, 2, 0);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(189, 29);
            LabelNama.TabIndex = 0;
            LabelNama.Text = "Nama";
            LabelNama.TextAlign = ContentAlignment.MiddleLeft;
            LabelNama.Click += LabelNama_Click;
            // 
            // Fotoprofile
            // 
            Fotoprofile.BackColor = Color.White;
            Fotoprofile.BackgroundImage = (Image)resources.GetObject("Fotoprofile.BackgroundImage");
            Fotoprofile.BackgroundImageLayout = ImageLayout.Zoom;
            Fotoprofile.BorderStyle = BorderStyle.FixedSingle;
            Fotoprofile.Location = new Point(146, 171);
            Fotoprofile.Margin = new Padding(2);
            Fotoprofile.Name = "Fotoprofile";
            Fotoprofile.Size = new Size(150, 200);
            Fotoprofile.SizeMode = PictureBoxSizeMode.Zoom;
            Fotoprofile.TabIndex = 0;
            Fotoprofile.TabStop = false;
            Fotoprofile.Click += Fotoprofile_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 128, 0);
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(174, 420);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 37);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(95, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 52);
            label1.TabIndex = 3;
            label1.Text = "Selamat Datang";
            // 
            // lblnama
            // 
            lblnama.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnama.ForeColor = Color.Black;
            lblnama.Location = new Point(359, 69);
            lblnama.Margin = new Padding(2, 0, 2, 0);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(283, 52);
            lblnama.TabIndex = 4;
            lblnama.Text = "Selamat datang";
            lblnama.Click += lblnama_Click;
            // 
            // V_HalProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(lblnama);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(Fotoprofile);
            Controls.Add(panelprofile);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "V_HalProfile";
            Size = new Size(1152, 810);
            panelprofile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Fotoprofile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprofile;
        private Label LabelPassword;
        private Label LabelEmail;
        private Label LabelJabatan;
        private Label LabelNoHP;
        private Label LabelUsername;
        private Label LabelNama;
        private PictureBox Fotoprofile;
        private Button btnEdit;
        private Label label1;
        private Label lblnama;
    }
}
