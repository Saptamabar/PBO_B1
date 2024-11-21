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
            panel1 = new Panel();
            LabelPassword = new Label();
            LabelEmail = new Label();
            LabelJabatan = new Label();
            LabelNoHP = new Label();
            LabelUsername = new Label();
            LabelNama = new Label();
            btnEdit = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Fotoprofile).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Fotoprofile
            // 
            Fotoprofile.BackColor = Color.White;
            Fotoprofile.BackgroundImage = (Image)resources.GetObject("Fotoprofile.BackgroundImage");
            Fotoprofile.BackgroundImageLayout = ImageLayout.Zoom;
            Fotoprofile.BorderStyle = BorderStyle.FixedSingle;
            Fotoprofile.Location = new Point(119, 92);
            Fotoprofile.Name = "Fotoprofile";
            Fotoprofile.Size = new Size(150, 200);
            Fotoprofile.SizeMode = PictureBoxSizeMode.Zoom;
            Fotoprofile.TabIndex = 0;
            Fotoprofile.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(LabelPassword);
            panel1.Controls.Add(LabelEmail);
            panel1.Controls.Add(LabelJabatan);
            panel1.Controls.Add(LabelNoHP);
            panel1.Controls.Add(LabelUsername);
            panel1.Controls.Add(LabelNama);
            panel1.Location = new Point(428, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 373);
            panel1.TabIndex = 1;
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
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(134, 368);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 46);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // V_HalProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(btnEdit);
            Controls.Add(panel1);
            Controls.Add(Fotoprofile);
            DoubleBuffered = true;
            Name = "V_HalProfile";
            Size = new Size(1152, 810);
            ((System.ComponentModel.ISupportInitialize)Fotoprofile).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Fotoprofile;
        private Panel panel1;
        private Label LabelNama;
        private Label LabelUsername;
        private Label LabelJabatan;
        private Label LabelNoHP;
        private Label LabelPassword;
        private Label LabelEmail;
        private Button btnEdit;
        private OpenFileDialog openFileDialog1;
    }
}
