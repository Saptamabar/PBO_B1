namespace PBO_B1.Views
{
    partial class V_HalLaporan1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnNext = new Button();
            btnBack = new Button();
            label1 = new Label();
            btnTabelLaporan = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(258, 159);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(606, 462);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // btnNext
            // 
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(903, 333);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(53, 96);
            btnNext.TabIndex = 1;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(165, 333);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 96);
            btnBack.TabIndex = 2;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 40);
            label1.Name = "label1";
            label1.Size = new Size(348, 61);
            label1.TabIndex = 3;
            label1.Text = "Laporan Transaksi";
            // 
            // btnTabelLaporan
            // 
            btnTabelLaporan.ForeColor = Color.Black;
            btnTabelLaporan.Location = new Point(871, 45);
            btnTabelLaporan.Name = "btnTabelLaporan";
            btnTabelLaporan.Size = new Size(134, 51);
            btnTabelLaporan.TabIndex = 4;
            btnTabelLaporan.Text = "Lihat Tabel";
            btnTabelLaporan.UseVisualStyleBackColor = true;
            btnTabelLaporan.Click += btnTabelLaporan_Click;
            // 
            // V_Cobabaru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            Controls.Add(btnTabelLaporan);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(chart1);
            Name = "V_Cobabaru";
            Size = new Size(1134, 759);
            Load += V_Cobabaru_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnNext;
        private Button btnBack;
        private Label label1;
        private Button btnTabelLaporan;
    }
}
