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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Datastruk).BeginInit();
            SuspendLayout();
            // 
            // Batal
            // 
            Batal.Location = new Point(73, 670);
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
            pictureBox1.Size = new Size(341, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Tanggal
            // 
            Tanggal.ForeColor = Color.Black;
            Tanggal.Location = new Point(440, 24);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(226, 26);
            Tanggal.TabIndex = 2;
            Tanggal.Text = "Tanggal : ";
            // 
            // Admin
            // 
            Admin.ForeColor = Color.Black;
            Admin.Location = new Point(440, 50);
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
            Datastruk.GridColor = Color.White;
            Datastruk.Location = new Point(22, 215);
            Datastruk.Name = "Datastruk";
            Datastruk.RowHeadersVisible = false;
            Datastruk.RowHeadersWidth = 51;
            Datastruk.ScrollBars = ScrollBars.Vertical;
            Datastruk.Size = new Size(684, 318);
            Datastruk.TabIndex = 4;
            // 
            // LabelTotal
            // 
            LabelTotal.Location = new Point(503, 573);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(64, 24);
            LabelTotal.TabIndex = 5;
            LabelTotal.Text = "Total  :";
            // 
            // LabelBayar
            // 
            LabelBayar.Location = new Point(503, 597);
            LabelBayar.Name = "LabelBayar";
            LabelBayar.Size = new Size(64, 24);
            LabelBayar.TabIndex = 6;
            LabelBayar.Text = "Bayar : ";
            // 
            // label1
            // 
            label1.Location = new Point(485, 621);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 7;
            label1.Text = "Kembali : ";
            // 
            // Total
            // 
            Total.BorderStyle = BorderStyle.FixedSingle;
            Total.Location = new Point(573, 574);
            Total.Name = "Total";
            Total.Size = new Size(125, 24);
            Total.TabIndex = 8;
            Total.Text = "Total  :";
            // 
            // Bayar
            // 
            Bayar.BorderStyle = BorderStyle.FixedSingle;
            Bayar.Location = new Point(573, 597);
            Bayar.Name = "Bayar";
            Bayar.Size = new Size(125, 27);
            Bayar.TabIndex = 9;
            Bayar.KeyPress += Bayar_KeyPress;
            // 
            // Kembali
            // 
            Kembali.BorderStyle = BorderStyle.FixedSingle;
            Kembali.Location = new Point(573, 621);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(125, 24);
            Kembali.TabIndex = 10;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(583, 670);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(98, 35);
            btnBayar.TabIndex = 11;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            // 
            // V_Struk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 737);
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
    }
}