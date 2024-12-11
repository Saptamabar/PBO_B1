namespace PBO_B1.Views
{
    partial class V_Struk
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Struk));
            Batal = new Button();
            pictureBox1 = new PictureBox();
            Tanggal = new Label();
            Admin = new Label();
            Datastruk = new DataGridView();
            LabelTotal = new Label();
            LabelBayar = new Label();
            label1 = new Label();
            Total = new Label();
            Bayar = new TextBox();
            Kembali = new Label();
            btnBayar = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Datastruk).BeginInit();
            SuspendLayout();
            // 
            // Batal
            // 
            Batal.Location = new Point(22, 861);
            Batal.Name = "Batal";
            Batal.Size = new Size(98, 35);
            Batal.TabIndex = 0;
            Batal.Text = "Batal";
            Batal.UseVisualStyleBackColor = true;
            Batal.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Struk;
            pictureBox1.Location = new Point(22, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Tanggal
            // 
            Tanggal.ForeColor = Color.Black;
            Tanggal.Location = new Point(800, 34);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(226, 26);
            Tanggal.TabIndex = 2;
            Tanggal.Text = "Tanggal : ";
            // 
            // Admin
            // 
            Admin.ForeColor = Color.Black;
            Admin.Location = new Point(800, 60);
            Admin.Name = "Admin";
            Admin.Size = new Size(226, 26);
            Admin.TabIndex = 3;
            Admin.Text = "Tanggal : ";
            // 
            // Datastruk
            // 
            Datastruk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datastruk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Datastruk.BackgroundColor = Color.White;
            Datastruk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Datastruk.DefaultCellStyle = dataGridViewCellStyle1;
            Datastruk.GridColor = Color.White;
            Datastruk.Location = new Point(22, 299);
            Datastruk.Name = "Datastruk";
            Datastruk.RowHeadersVisible = false;
            Datastruk.RowHeadersWidth = 51;
            Datastruk.ScrollBars = ScrollBars.Vertical;
            Datastruk.Size = new Size(944, 364);
            Datastruk.TabIndex = 4;
            // 
            // LabelTotal
            // 
            LabelTotal.Location = new Point(771, 706);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(64, 24);
            LabelTotal.TabIndex = 5;
            LabelTotal.Text = "Total  :";
            // 
            // LabelBayar
            // 
            LabelBayar.Location = new Point(771, 730);
            LabelBayar.Name = "LabelBayar";
            LabelBayar.Size = new Size(64, 24);
            LabelBayar.TabIndex = 6;
            LabelBayar.Text = "Bayar : ";
            // 
            // label1
            // 
            label1.Location = new Point(753, 754);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 7;
            label1.Text = "Kembali : ";
            // 
            // Total
            // 
            Total.BorderStyle = BorderStyle.FixedSingle;
            Total.Location = new Point(841, 707);
            Total.Name = "Total";
            Total.Size = new Size(125, 24);
            Total.TabIndex = 8;
            Total.Text = "Total  :";
            // 
            // Bayar
            // 
            Bayar.BorderStyle = BorderStyle.FixedSingle;
            Bayar.Location = new Point(841, 730);
            Bayar.Name = "Bayar";
            Bayar.Size = new Size(125, 27);
            Bayar.TabIndex = 9;
            Bayar.KeyPress += Bayar_KeyPress;
            // 
            // Kembali
            // 
            Kembali.BorderStyle = BorderStyle.FixedSingle;
            Kembali.Location = new Point(841, 754);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(125, 24);
            Kembali.TabIndex = 10;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(868, 861);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(98, 35);
            btnBayar.TabIndex = 11;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // V_Struk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 990);
            Controls.Add(btnBayar);
            Controls.Add(Kembali);
            Controls.Add(Bayar);
            Controls.Add(Total);
            Controls.Add(label1);
            Controls.Add(LabelBayar);
            Controls.Add(LabelTotal);
            Controls.Add(Datastruk);
            Controls.Add(Admin);
            Controls.Add(Tanggal);
            Controls.Add(pictureBox1);
            Controls.Add(Batal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_Struk";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Struk";
            Load += V_Struk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Datastruk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Batal;
        private PictureBox pictureBox1;
        private Label Tanggal;
        private Label Admin;
        private DataGridView Datastruk;
        private Label LabelTotal;
        private Label LabelBayar;
        private Label label1;
        private Label Total;
        private TextBox Bayar;
        private Label Kembali;
        private Button btnBayar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}