namespace PBO_B1.Views
{
    partial class V_HalTambahBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalTambahBarang));
            Panelbarangbaru = new Panel();
            BtnHapus = new Button();
            btnBatal = new Button();
            daftraMerk = new ComboBox();
            daftarKategori = new ComboBox();
            TanggalPembelian = new DateTimePicker();
            TBStok = new TextBox();
            TBHarga = new TextBox();
            TbNamaBarang = new TextBox();
            Buttonsimpan = new Button();
            Fotobarang = new PictureBox();
            Panelbarangbaru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Fotobarang).BeginInit();
            SuspendLayout();
            // 
            // Panelbarangbaru
            // 
            Panelbarangbaru.BackColor = Color.Transparent;
            Panelbarangbaru.BackgroundImage = Properties.Resources.Base_Form_Barang;
            Panelbarangbaru.BackgroundImageLayout = ImageLayout.Zoom;
            Panelbarangbaru.Controls.Add(BtnHapus);
            Panelbarangbaru.Controls.Add(btnBatal);
            Panelbarangbaru.Controls.Add(daftraMerk);
            Panelbarangbaru.Controls.Add(daftarKategori);
            Panelbarangbaru.Controls.Add(TanggalPembelian);
            Panelbarangbaru.Controls.Add(TBStok);
            Panelbarangbaru.Controls.Add(TBHarga);
            Panelbarangbaru.Controls.Add(TbNamaBarang);
            Panelbarangbaru.Controls.Add(Buttonsimpan);
            Panelbarangbaru.Controls.Add(Fotobarang);
            Panelbarangbaru.Location = new Point(152, 107);
            Panelbarangbaru.Name = "Panelbarangbaru";
            Panelbarangbaru.Size = new Size(833, 587);
            Panelbarangbaru.TabIndex = 0;
            // 
            // BtnHapus
            // 
            BtnHapus.BackgroundImage = (Image)resources.GetObject("BtnHapus.BackgroundImage");
            BtnHapus.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHapus.Enabled = false;
            BtnHapus.FlatAppearance.BorderSize = 0;
            BtnHapus.FlatStyle = FlatStyle.Flat;
            BtnHapus.Location = new Point(46, 24);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(42, 49);
            BtnHapus.TabIndex = 10;
            BtnHapus.UseVisualStyleBackColor = true;
            BtnHapus.Visible = false;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.Black;
            btnBatal.Image = Properties.Resources.BG_Button_tambah;
            btnBatal.Location = new Point(46, 364);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(123, 46);
            btnBatal.TabIndex = 9;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // daftraMerk
            // 
            daftraMerk.FlatStyle = FlatStyle.Flat;
            daftraMerk.FormattingEnabled = true;
            daftraMerk.Items.AddRange(new object[] { "Bangunan", "Gatau Lanutannya apa" });
            daftraMerk.Location = new Point(365, 154);
            daftraMerk.Name = "daftraMerk";
            daftraMerk.Size = new Size(394, 28);
            daftraMerk.TabIndex = 8;
            // 
            // daftarKategori
            // 
            daftarKategori.FlatStyle = FlatStyle.Flat;
            daftarKategori.FormattingEnabled = true;
            daftarKategori.Items.AddRange(new object[] { "Bangunan", "Gatau Lanutannya apa" });
            daftarKategori.Location = new Point(365, 244);
            daftarKategori.Name = "daftarKategori";
            daftarKategori.Size = new Size(394, 28);
            daftarKategori.TabIndex = 7;
            // 
            // TanggalPembelian
            // 
            TanggalPembelian.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TanggalPembelian.Location = new Point(365, 519);
            TanggalPembelian.Name = "TanggalPembelian";
            TanggalPembelian.Size = new Size(303, 31);
            TanggalPembelian.TabIndex = 1;
            // 
            // TBStok
            // 
            TBStok.BorderStyle = BorderStyle.None;
            TBStok.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBStok.Location = new Point(365, 433);
            TBStok.Name = "TBStok";
            TBStok.Size = new Size(394, 24);
            TBStok.TabIndex = 6;
            TBStok.KeyPress += TBHarga_KeyPress;
            // 
            // TBHarga
            // 
            TBHarga.BorderStyle = BorderStyle.None;
            TBHarga.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBHarga.Location = new Point(365, 340);
            TBHarga.Name = "TBHarga";
            TBHarga.Size = new Size(394, 24);
            TBHarga.TabIndex = 5;
            TBHarga.TextChanged += TBHarga_TextChanged;
            TBHarga.KeyPress += TBHarga_KeyPress;
            // 
            // TbNamaBarang
            // 
            TbNamaBarang.BorderStyle = BorderStyle.None;
            TbNamaBarang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbNamaBarang.Location = new Point(365, 66);
            TbNamaBarang.Name = "TbNamaBarang";
            TbNamaBarang.Size = new Size(394, 24);
            TbNamaBarang.TabIndex = 2;
            // 
            // Buttonsimpan
            // 
            Buttonsimpan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Buttonsimpan.ForeColor = Color.Black;
            Buttonsimpan.Image = Properties.Resources.BG_Button_tambah;
            Buttonsimpan.Location = new Point(190, 364);
            Buttonsimpan.Name = "Buttonsimpan";
            Buttonsimpan.Size = new Size(123, 46);
            Buttonsimpan.TabIndex = 1;
            Buttonsimpan.Text = "Simpan";
            Buttonsimpan.UseVisualStyleBackColor = true;
            Buttonsimpan.Click += Buttonsimpan_Click;
            // 
            // Fotobarang
            // 
            Fotobarang.Image = Properties.Resources.DeafultImageBarang;
            Fotobarang.Location = new Point(99, 176);
            Fotobarang.Name = "Fotobarang";
            Fotobarang.Size = new Size(163, 163);
            Fotobarang.SizeMode = PictureBoxSizeMode.Zoom;
            Fotobarang.TabIndex = 0;
            Fotobarang.TabStop = false;
            Fotobarang.Click += Fotobarang_Click;
            // 
            // V_HalTambahBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panelbarangbaru);
            Name = "V_HalTambahBarang";
            Size = new Size(1152, 810);
            Load += V_HalTambahBarang_Load;
            Panelbarangbaru.ResumeLayout(false);
            Panelbarangbaru.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Fotobarang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panelbarangbaru;
        private PictureBox Fotobarang;
        private Button Buttonsimpan;
        private TextBox TbNamaBarang;
        private ComboBox daftarKategori;
        private DateTimePicker TanggalPembelian;
        private TextBox TBStok;
        private TextBox TBHarga;
        private ComboBox daftraMerk;
        private Button btnBatal;
        private Button BtnHapus;
    }
}
