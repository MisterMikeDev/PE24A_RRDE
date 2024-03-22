namespace PE24A_RRDE
{
    partial class DlgSecret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgSecret));
            this.PnlCanvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlCanvas
            // 
            this.PnlCanvas.BackColor = System.Drawing.Color.White;
            this.PnlCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.PnlCanvas.Name = "PnlCanvas";
            this.PnlCanvas.Size = new System.Drawing.Size(1484, 808);
            this.PnlCanvas.TabIndex = 0;
            // 
            // DlgSecret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(9)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1484, 808);
            this.Controls.Add(this.PnlCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgSecret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Secret";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.DlgSecret_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCanvas;
    }
}