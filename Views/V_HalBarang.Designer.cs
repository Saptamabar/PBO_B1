﻿namespace PBO_B1.Views
{
    partial class V_HalBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalBarang));
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelBarang = new FlowLayoutPanel();
            panel1 = new Panel();
            kategori = new Label();
            ComboBoxKategori = new ComboBox();
            BtnTambahBarang = new Button();
            Panelseacrhbar = new Panel();
            TBSearchbar = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            Panelseacrhbar.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PanelBarang, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1134, 759);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelBarang
            // 
            PanelBarang.AutoScroll = true;
            PanelBarang.BackColor = Color.White;
            PanelBarang.Dock = DockStyle.Fill;
            PanelBarang.Location = new Point(2, 153);
            PanelBarang.Margin = new Padding(2);
            PanelBarang.Name = "PanelBarang";
            PanelBarang.Padding = new Padding(8);
            PanelBarang.Size = new Size(1130, 604);
            PanelBarang.TabIndex = 0;
            PanelBarang.Paint += PanelBarang_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(kategori);
            panel1.Controls.Add(ComboBoxKategori);
            panel1.Controls.Add(BtnTambahBarang);
            panel1.Controls.Add(Panelseacrhbar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 151);
            panel1.TabIndex = 1;
            // 
            // kategori
            // 
            kategori.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kategori.ForeColor = Color.White;
            kategori.Location = new Point(53, 74);
            kategori.Margin = new Padding(2, 0, 2, 0);
            kategori.Name = "kategori";
            kategori.Size = new Size(109, 26);
            kategori.TabIndex = 3;
            kategori.Text = "Kategori :";
            // 
            // ComboBoxKategori
            // 
            ComboBoxKategori.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBoxKategori.ForeColor = Color.Black;
            ComboBoxKategori.FormattingEnabled = true;
            ComboBoxKategori.Items.AddRange(new object[] { "Bangunan", "Air", "Api", "Udara" });
            ComboBoxKategori.Location = new Point(53, 102);
            ComboBoxKategori.Margin = new Padding(2);
            ComboBoxKategori.Name = "ComboBoxKategori";
            ComboBoxKategori.Size = new Size(122, 31);
            ComboBoxKategori.TabIndex = 2;
            ComboBoxKategori.SelectedIndexChanged += ComboBoxKategori_SelectedIndexChanged;
            // 
            // BtnTambahBarang
            // 
            BtnTambahBarang.BackColor = Color.Transparent;
            BtnTambahBarang.BackgroundImageLayout = ImageLayout.Zoom;
            BtnTambahBarang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTambahBarang.ForeColor = Color.Black;
            BtnTambahBarang.Location = new Point(954, 79);
            BtnTambahBarang.Margin = new Padding(2);
            BtnTambahBarang.Name = "BtnTambahBarang";
            BtnTambahBarang.Size = new Size(141, 47);
            BtnTambahBarang.TabIndex = 1;
            BtnTambahBarang.Text = "Tambah";
            BtnTambahBarang.UseVisualStyleBackColor = false;
            BtnTambahBarang.Click += BtnTambahBarang_Click;
            // 
            // Panelseacrhbar
            // 
            Panelseacrhbar.BackgroundImage = (Image)resources.GetObject("Panelseacrhbar.BackgroundImage");
            Panelseacrhbar.BackgroundImageLayout = ImageLayout.Zoom;
            Panelseacrhbar.Controls.Add(TBSearchbar);
            Panelseacrhbar.Location = new Point(356, 65);
            Panelseacrhbar.Margin = new Padding(2);
            Panelseacrhbar.Name = "Panelseacrhbar";
            Panelseacrhbar.Size = new Size(447, 68);
            Panelseacrhbar.TabIndex = 0;
            // 
            // TBSearchbar
            // 
            TBSearchbar.BackColor = Color.White;
            TBSearchbar.BorderStyle = BorderStyle.None;
            TBSearchbar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBSearchbar.ForeColor = Color.Black;
            TBSearchbar.Location = new Point(64, 21);
            TBSearchbar.Margin = new Padding(2);
            TBSearchbar.Name = "TBSearchbar";
            TBSearchbar.Size = new Size(334, 27);
            TBSearchbar.TabIndex = 0;
            TBSearchbar.Text = "Cari disini..";
            TBSearchbar.Click += TBSearchbar_Click;
            TBSearchbar.TextChanged += TBSearchbar_TextChanged;
            TBSearchbar.KeyPress += TbSeacrhbar_KeyPress;
            // 
            // V_HalBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "V_HalBarang";
            Size = new Size(1134, 759);
            Load += V_HalBarang_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            Panelseacrhbar.ResumeLayout(false);
            Panelseacrhbar.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel Panelseacrhbar;
        private TextBox TBSearchbar;
        private Button BtnTambahBarang;
        private ComboBox ComboBoxKategori;
        private FlowLayoutPanel PanelBarang;
        private Label kategori;
    }
}
