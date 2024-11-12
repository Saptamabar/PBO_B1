namespace PBO_B1.Views
{
    partial class V_HalUtama
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(269, 141);
            label1.Name = "label1";
            label1.Size = new Size(195, 114);
            label1.TabIndex = 0;
            label1.Text = "Belum Bikin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // V_HalUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "V_HalUtama";
            Text = "V_HalUtama";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}