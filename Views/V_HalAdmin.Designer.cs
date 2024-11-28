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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnTambahAdmin = new Button();
            dataGridAdmin = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridAdmin).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTambahAdmin
            // 
            btnTambahAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTambahAdmin.ForeColor = Color.Black;
            btnTambahAdmin.Location = new Point(980, 78);
            btnTambahAdmin.Name = "btnTambahAdmin";
            btnTambahAdmin.Size = new Size(110, 56);
            btnTambahAdmin.TabIndex = 0;
            btnTambahAdmin.Text = "Tambah";
            btnTambahAdmin.UseVisualStyleBackColor = true;
            // 
            // dataGridAdmin
            // 
            dataGridAdmin.AllowUserToResizeColumns = false;
            dataGridAdmin.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAdmin.BackgroundColor = Color.White;
            dataGridAdmin.BorderStyle = BorderStyle.None;
            dataGridAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAdmin.Dock = DockStyle.Fill;
            dataGridAdmin.GridColor = Color.Black;
            dataGridAdmin.Location = new Point(3, 165);
            dataGridAdmin.Name = "dataGridAdmin";
            dataGridAdmin.RowHeadersWidth = 51;
            dataGridAdmin.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridAdmin.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAdmin.Size = new Size(1146, 642);
            dataGridAdmin.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 128, 0);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridAdmin, 0, 0);
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
            panel1.Controls.Add(btnTambahAdmin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 156);
            panel1.TabIndex = 2;
            // 
            // V_HalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "V_HalAdmin";
            Size = new Size(1152, 810);
            ((System.ComponentModel.ISupportInitialize)dataGridAdmin).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTambahAdmin;
        private DataGridView dataGridAdmin;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
