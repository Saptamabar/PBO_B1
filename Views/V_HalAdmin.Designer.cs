namespace PBO_B1.Views
{
    partial class V_HalAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridAdmin = new DataGridView();
            btnTambahAdmin = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridAdmin).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridAdmin
            // 
            dataGridAdmin.AllowUserToAddRows = false;
            dataGridAdmin.AllowUserToOrderColumns = true;
            dataGridAdmin.AllowUserToResizeColumns = false;
            dataGridAdmin.AllowUserToResizeRows = false;
            dataGridAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridAdmin.BackgroundColor = Color.White;
            dataGridAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAdmin.Dock = DockStyle.Fill;
            dataGridAdmin.Location = new Point(2, 153);
            dataGridAdmin.Margin = new Padding(2);
            dataGridAdmin.Name = "dataGridAdmin";
            dataGridAdmin.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridAdmin.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAdmin.ScrollBars = ScrollBars.Vertical;
            dataGridAdmin.Size = new Size(1130, 604);
            dataGridAdmin.TabIndex = 0;
            dataGridAdmin.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTambahAdmin
            // 
            btnTambahAdmin.ForeColor = Color.Black;
            btnTambahAdmin.Location = new Point(880, 60);
            btnTambahAdmin.Margin = new Padding(2);
            btnTambahAdmin.Name = "btnTambahAdmin";
            btnTambahAdmin.Size = new Size(195, 42);
            btnTambahAdmin.TabIndex = 1;
            btnTambahAdmin.Text = "Tambah";
            btnTambahAdmin.UseVisualStyleBackColor = true;
            btnTambahAdmin.Click += btnTambahAdmin_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 128, 0);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridAdmin, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1134, 759);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTambahAdmin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 145);
            panel1.TabIndex = 1;
            // 
            // V_HalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "V_HalAdmin";
            Size = new Size(1134, 759);
            Load += V_HalAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAdmin).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridAdmin;
        private Button btnTambahAdmin;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
