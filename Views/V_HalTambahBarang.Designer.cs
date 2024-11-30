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
            Panelbarangbaru = new Panel();
            comboBox1 = new ComboBox();
            TanggalPembelian = new DateTimePicker();
            TBStok = new TextBox();
            TBHarga = new TextBox();
            TBMerk = new TextBox();
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
            Panelbarangbaru.Controls.Add(comboBox1);
            Panelbarangbaru.Controls.Add(TanggalPembelian);
            Panelbarangbaru.Controls.Add(TBStok);
            Panelbarangbaru.Controls.Add(TBHarga);
            Panelbarangbaru.Controls.Add(TBMerk);
            Panelbarangbaru.Controls.Add(TbNamaBarang);
            Panelbarangbaru.Controls.Add(Buttonsimpan);
            Panelbarangbaru.Controls.Add(Fotobarang);
            Panelbarangbaru.Location = new Point(152, 107);
            Panelbarangbaru.Name = "Panelbarangbaru";
            Panelbarangbaru.Size = new Size(833, 587);
            Panelbarangbaru.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bangunan", "Gatau Lanutannya apa" });
            comboBox1.Location = new Point(365, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(394, 28);
            comboBox1.TabIndex = 7;
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
            // 
            // TBHarga
            // 
            TBHarga.BorderStyle = BorderStyle.None;
            TBHarga.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBHarga.Location = new Point(365, 340);
            TBHarga.Name = "TBHarga";
            TBHarga.Size = new Size(394, 24);
            TBHarga.TabIndex = 5;
            // 
            // TBMerk
            // 
            TBMerk.BorderStyle = BorderStyle.None;
            TBMerk.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBMerk.Location = new Point(365, 156);
            TBMerk.Name = "TBMerk";
            TBMerk.Size = new Size(394, 24);
            TBMerk.TabIndex = 3;
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
            Buttonsimpan.Location = new Point(120, 361);
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
        private ComboBox comboBox1;
        private DateTimePicker TanggalPembelian;
        private TextBox TBStok;
        private TextBox TBHarga;
        private TextBox TBMerk;
    }
}
