namespace PBO_B1.Views
{
    partial class V_HalTransaksi
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridViewTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaksi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOrange;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1688, 166);
            label1.TabIndex = 0;
            label1.Text = "Transaksi ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dataGridViewTransaksi
            // 
            dataGridViewTransaksi.AllowUserToOrderColumns = true;
            dataGridViewTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaksi.Dock = DockStyle.Fill;
            dataGridViewTransaksi.Location = new Point(0, 166);
            dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            dataGridViewTransaksi.RowHeadersWidth = 82;
            dataGridViewTransaksi.Size = new Size(1688, 658);
            dataGridViewTransaksi.TabIndex = 2;
            dataGridViewTransaksi.CellContentClick += dataGridViewTransaksi_CellContentClick; // Perbaiki nama event handler
            // 
            // V_HalTransaksi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewTransaksi);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "V_HalTransaksi";
            Size = new Size(1688, 824);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaksi).EndInit();
            ResumeLayout(false);
        }

        private Label label1;
        private DataGridView dataGridViewTransaksi;

    }
}