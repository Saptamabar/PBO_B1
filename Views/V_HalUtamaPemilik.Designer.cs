
namespace PBO_B1.Views
{
    partial class V_HalUtamaPemilik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalUtamaPemilik));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnLogout = new Button();
            btnAdmin = new Button();
            btnLaporan = new Button();
            btnTransaksi = new Button();
            btnBarang = new Button();
            btnProfile = new Button();
            pictureBox1 = new PictureBox();
            panelmain = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panelmain, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.White;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1422, 763);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnBarang);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 757);
            panel1.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.DarkOrange;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(0, 674);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(278, 83);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.AutoSize = true;
            btnAdmin.BackColor = Color.DarkOrange;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.Location = new Point(0, 426);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(278, 78);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Admin";
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.AutoSize = true;
            btnLaporan.BackColor = Color.DarkOrange;
            btnLaporan.Dock = DockStyle.Top;
            btnLaporan.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaporan.Image = (Image)resources.GetObject("btnLaporan.Image");
            btnLaporan.Location = new Point(0, 348);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(278, 78);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.AutoSize = true;
            btnTransaksi.BackColor = Color.DarkOrange;
            btnTransaksi.Dock = DockStyle.Top;
            btnTransaksi.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.Image = (Image)resources.GetObject("btnTransaksi.Image");
            btnTransaksi.Location = new Point(0, 270);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(278, 78);
            btnTransaksi.TabIndex = 3;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnBarang
            // 
            btnBarang.AutoSize = true;
            btnBarang.BackColor = Color.DarkOrange;
            btnBarang.Dock = DockStyle.Top;
            btnBarang.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarang.Image = (Image)resources.GetObject("btnBarang.Image");
            btnBarang.Location = new Point(0, 192);
            btnBarang.Name = "btnBarang";
            btnBarang.Size = new Size(278, 78);
            btnBarang.TabIndex = 2;
            btnBarang.Text = "Barang";
            btnBarang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBarang.UseVisualStyleBackColor = false;
            btnBarang.Click += btnBarang_Click;
            // 
            // btnProfile
            // 
            btnProfile.AutoSize = true;
            btnProfile.BackColor = Color.DarkOrange;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(0, 114);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(278, 78);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelmain
            // 
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(286, 2);
            panelmain.Margin = new Padding(2);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1134, 759);
            panelmain.TabIndex = 7;
            panelmain.Paint += panelmain_Paint;
            // 
            // V_HalUtamaPemilik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 763);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_HalUtamaPemilik";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patungan";
            Load += V_HalUtamaPemilik_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnLaporan;
        private Button btnTransaksi;
        private Button btnBarang;
        private Button btnProfile;
        private Button btnLogout;
        private Button btnAdmin;
        public static Panel panelmain;
    }
}