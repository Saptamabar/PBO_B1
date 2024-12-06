namespace PBO_B1.Views
{
    partial class V_HalLaporan
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panelbasebarang = new FlowLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            flowpanelkeranjang = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1134, 759);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panelbasebarang, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(901, 753);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panelbasebarang
            // 
            panelbasebarang.AutoScroll = true;
            panelbasebarang.BackColor = Color.White;
            panelbasebarang.Dock = DockStyle.Fill;
            panelbasebarang.Location = new Point(3, 153);
            panelbasebarang.Name = "panelbasebarang";
            panelbasebarang.Size = new Size(895, 597);
            panelbasebarang.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 144);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(button1, 0, 1);
            tableLayoutPanel3.Controls.Add(flowpanelkeranjang, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(910, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(221, 753);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 605);
            button1.Name = "button1";
            button1.Size = new Size(215, 145);
            button1.TabIndex = 0;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowpanelkeranjang
            // 
            flowpanelkeranjang.AutoScroll = true;
            flowpanelkeranjang.BackColor = Color.FromArgb(255, 128, 0);
            flowpanelkeranjang.Dock = DockStyle.Fill;
            flowpanelkeranjang.Location = new Point(3, 3);
            flowpanelkeranjang.Name = "flowpanelkeranjang";
            flowpanelkeranjang.Size = new Size(215, 596);
            flowpanelkeranjang.TabIndex = 1;
            // 
            // V_HalLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "V_HalLaporan";
            Size = new Size(1134, 759);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Label Harga;
        private static FlowLayoutPanel panelbasebarang;
        public static FlowLayoutPanel flowpanelkeranjang;
    }
}
