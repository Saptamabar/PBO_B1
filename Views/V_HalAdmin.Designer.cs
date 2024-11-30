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
            dataGridView1 = new DataGridView();
            btnTambahAdmin = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(1301, 557);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTambahAdmin
            // 
            btnTambahAdmin.Anchor = AnchorStyles.None;
            btnTambahAdmin.AutoSize = true;
            btnTambahAdmin.ForeColor = Color.Black;
            btnTambahAdmin.Location = new Point(1181, 689);
            btnTambahAdmin.Name = "btnTambahAdmin";
            btnTambahAdmin.Size = new Size(244, 53);
            btnTambahAdmin.TabIndex = 1;
            btnTambahAdmin.Text = "Tambah";
            btnTambahAdmin.UseVisualStyleBackColor = true;
            btnTambahAdmin.Click += btnTambahAdmin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(589, 40);
            label1.Name = "label1";
            label1.Size = new Size(371, 41);
            label1.TabIndex = 2;
            label1.Text = "DATA ADMIN";
            label1.Click += label1_Click;
            // 
            // V_HalAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnTambahAdmin);
            Name = "V_HalAdmin";
            Size = new Size(1512, 849);
            Load += V_HalAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTambahAdmin;
        private Label label1;
    }
}
