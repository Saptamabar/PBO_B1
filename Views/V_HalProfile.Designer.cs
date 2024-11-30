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
            Fotoprofile.Location = new Point(117, 137);
            Fotoprofile.Margin = new Padding(2, 2, 2, 2);
            Fotoprofile.Name = "Fotoprofile";
            Fotoprofile.Size = new Size(120, 160);
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
            panelprofile.Location = new Point(357, 137);
            panelprofile.Margin = new Padding(2, 2, 2, 2);
            panelprofile.Name = "panelprofile";
            panelprofile.Size = new Size(482, 298);
            panelprofile.TabIndex = 1;
            // 
            // LabelPassword
            // 
            LabelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPassword.ForeColor = Color.Black;
            LabelPassword.Location = new Point(267, 221);
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
            LabelEmail.Location = new Point(267, 142);
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
            LabelJabatan.Location = new Point(267, 61);
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
            LabelNoHP.Location = new Point(29, 221);
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
            LabelUsername.Location = new Point(29, 142);
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
            LabelNama.Location = new Point(29, 61);
            LabelNama.Margin = new Padding(2, 0, 2, 0);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(189, 29);
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
            btnEdit.Location = new Point(132, 398);
            btnEdit.Margin = new Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 37);
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
            panelmain.Margin = new Padding(2, 2, 2, 2);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(922, 648);
            panelmain.TabIndex = 3;
            panelmain.Paint += panelmain_Paint;
            // 
            // lblnama
            // 
            lblnama.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnama.ForeColor = Color.Black;
            lblnama.Location = new Point(349, 55);
            lblnama.Margin = new Padding(2, 0, 2, 0);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(226, 42);
            lblnama.TabIndex = 4;
            lblnama.Text = "Selamat datang";
            lblnama.Click += lblnama_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(76, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 42);
            label1.TabIndex = 3;
            label1.Text = "Selamat Datang";
            // 
            // V_HalProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panelmain);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "V_HalProfile";
            Size = new Size(922, 648);
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
