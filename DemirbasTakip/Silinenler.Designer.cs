namespace DemirbasTakip
{
    partial class Silinenler
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgSilinenler = new System.Windows.Forms.DataGridView();
            this.cmsSilindi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSilinenler)).BeginInit();
            this.cmsSilindi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgSilinenler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 405);
            this.panel1.TabIndex = 0;
            // 
            // dgSilinenler
            // 
            this.dgSilinenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSilinenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSilinenler.Location = new System.Drawing.Point(0, 0);
            this.dgSilinenler.Name = "dgSilinenler";
            this.dgSilinenler.RowTemplate.Height = 24;
            this.dgSilinenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSilinenler.Size = new System.Drawing.Size(742, 405);
            this.dgSilinenler.TabIndex = 0;
            // 
            // cmsSilindi
            // 
            this.cmsSilindi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSilindi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEkle});
            this.cmsSilindi.Name = "cmsSilindi";
            this.cmsSilindi.Size = new System.Drawing.Size(137, 28);
            // 
            // tsmEkle
            // 
            this.tsmEkle.Name = "tsmEkle";
            this.tsmEkle.Size = new System.Drawing.Size(175, 24);
            this.tsmEkle.Text = "Geri Ekle";
            this.tsmEkle.Click += new System.EventHandler(this.tsmEkle_Click);
            // 
            // Silinenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 405);
            this.ContextMenuStrip = this.cmsSilindi;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Silinenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silinenler";
            this.Load += new System.EventHandler(this.Silinenler_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSilinenler)).EndInit();
            this.cmsSilindi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgSilinenler;
        private System.Windows.Forms.ContextMenuStrip cmsSilindi;
        private System.Windows.Forms.ToolStripMenuItem tsmEkle;
    }
}