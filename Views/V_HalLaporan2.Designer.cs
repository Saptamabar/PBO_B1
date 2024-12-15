namespace PBO_B1.Views
{
    partial class V_HalLaporan2
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridTransaksi = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            TanggalAkhir = new DateTimePicker();
            TanggalAwal = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            BarangTerlaris = new Label();
            TotalPenjualan = new Label();
            JumlahTransaksi = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridTransaksi
            // 
            dataGridTransaksi.AllowUserToAddRows = false;
            dataGridTransaksi.AllowUserToDeleteRows = false;
            dataGridTransaksi.AllowUserToResizeColumns = false;
            dataGridTransaksi.AllowUserToResizeRows = false;
            dataGridTransaksi.BackgroundColor = Color.White;
            dataGridTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridTransaksi.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridTransaksi.Location = new Point(3, 165);
            dataGridTransaksi.Name = "dataGridTransaksi";
            dataGridTransaksi.RowHeadersVisible = false;
            dataGridTransaksi.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridTransaksi.Size = new Size(1146, 642);
            dataGridTransaksi.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridTransaksi, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1152, 810);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(TanggalAkhir);
            panel1.Controls.Add(TanggalAwal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BarangTerlaris);
            panel1.Controls.Add(TotalPenjualan);
            panel1.Controls.Add(JumlahTransaksi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 156);
            panel1.TabIndex = 2;
            // 
            // TanggalAkhir
            // 
            TanggalAkhir.Location = new Point(1008, 75);
            TanggalAkhir.Name = "TanggalAkhir";
            TanggalAkhir.Size = new Size(107, 27);
            TanggalAkhir.TabIndex = 9;
            TanggalAkhir.ValueChanged += TanggalAkhir_ValueChanged;
            // 
            // TanggalAwal
            // 
            TanggalAwal.Location = new Point(834, 75);
            TanggalAwal.Name = "TanggalAwal";
            TanggalAwal.Size = new Size(107, 27);
            TanggalAwal.TabIndex = 8;
            TanggalAwal.ValueChanged += TanggalAwal_ValueChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(990, 45);
            label5.Name = "label5";
            label5.Size = new Size(137, 27);
            label5.TabIndex = 7;
            label5.Text = "Tanggal akhir :";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(817, 45);
            label4.Name = "label4";
            label4.Size = new Size(137, 27);
            label4.TabIndex = 6;
            label4.Text = "Tanggal awal :";
            // 
            // BarangTerlaris
            // 
            BarangTerlaris.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BarangTerlaris.ForeColor = Color.White;
            BarangTerlaris.Location = new Point(216, 101);
            BarangTerlaris.Name = "BarangTerlaris";
            BarangTerlaris.Size = new Size(168, 27);
            BarangTerlaris.TabIndex = 5;
            BarangTerlaris.Text = ": ";
            // 
            // TotalPenjualan
            // 
            TotalPenjualan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPenjualan.ForeColor = Color.White;
            TotalPenjualan.Location = new Point(216, 62);
            TotalPenjualan.Name = "TotalPenjualan";
            TotalPenjualan.Size = new Size(168, 27);
            TotalPenjualan.TabIndex = 4;
            TotalPenjualan.Text = ": ";
            // 
            // JumlahTransaksi
            // 
            JumlahTransaksi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JumlahTransaksi.ForeColor = Color.White;
            JumlahTransaksi.Location = new Point(216, 25);
            JumlahTransaksi.Name = "JumlahTransaksi";
            JumlahTransaksi.Size = new Size(168, 27);
            JumlahTransaksi.TabIndex = 3;
            JumlahTransaksi.Text = ": ";
            JumlahTransaksi.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 101);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 2;
            label3.Text = "Barang terlaris";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 62);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 1;
            label2.Text = "Total Penjualan";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 0;
            label1.Text = "Jumlah Transaksi";
            // 
            // V_HalTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "V_HalTransaksi";
            Size = new Size(1152, 810);
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dataGridTransaksi;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label BarangTerlaris;
        private Label TotalPenjualan;
        private Label JumlahTransaksi;
        private Label label3;
        private DateTimePicker TanggalAkhir;
        private DateTimePicker TanggalAwal;
        private Label label5;
        private Label label4;
    }
}