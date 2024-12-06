namespace PBO_B1.Views
{
    partial class V_DetailTransaksi
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tabelkiri = new TableLayoutPanel();
            Flowlayoutbarang = new FlowLayoutPanel();
            panel1 = new Panel();
            Bayar = new Button();
            Totalharga = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tabelkiri.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.92769F));
            tableLayoutPanel1.Controls.Add(tabelkiri, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1134, 759);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabelkiri
            // 
            tabelkiri.ColumnCount = 1;
            tabelkiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tabelkiri.Controls.Add(Flowlayoutbarang, 0, 1);
            tabelkiri.Controls.Add(panel1, 0, 0);
            tabelkiri.Dock = DockStyle.Fill;
            tabelkiri.Location = new Point(3, 3);
            tabelkiri.Name = "tabelkiri";
            tabelkiri.RowCount = 2;
            tabelkiri.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelkiri.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tabelkiri.Size = new Size(1128, 753);
            tabelkiri.TabIndex = 0;
            // 
            // Flowlayoutbarang
            // 
            Flowlayoutbarang.AutoScroll = true;
            Flowlayoutbarang.BackColor = Color.FromArgb(255, 128, 0);
            Flowlayoutbarang.Dock = DockStyle.Fill;
            Flowlayoutbarang.Location = new Point(3, 78);
            Flowlayoutbarang.Name = "Flowlayoutbarang";
            Flowlayoutbarang.Size = new Size(1122, 672);
            Flowlayoutbarang.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(Bayar);
            panel1.Controls.Add(Totalharga);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 69);
            panel1.TabIndex = 1;
            // 
            // Bayar
            // 
            Bayar.ForeColor = Color.Black;
            Bayar.Location = new Point(968, 3);
            Bayar.Name = "Bayar";
            Bayar.Size = new Size(143, 63);
            Bayar.TabIndex = 2;
            Bayar.Text = "Bayar";
            Bayar.UseVisualStyleBackColor = true;
            Bayar.Click += Bayar_Click;
            // 
            // Totalharga
            // 
            Totalharga.BackColor = Color.Transparent;
            Totalharga.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Totalharga.ForeColor = Color.White;
            Totalharga.Location = new Point(789, 21);
            Totalharga.Name = "Totalharga";
            Totalharga.Size = new Size(163, 25);
            Totalharga.TabIndex = 1;
            Totalharga.Text = "Total : Rp. 50000";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 0;
            label1.Text = "Detail Transaksi";
            // 
            // V_DetailTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "V_DetailTransaksi";
            Size = new Size(1134, 759);
            tableLayoutPanel1.ResumeLayout(false);
            tabelkiri.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tabelkiri;
        private Panel panel1;
        private Label label1;
        private static Label Totalharga;
        public static FlowLayoutPanel Flowlayoutbarang;
        private Button Bayar;
    }
}
