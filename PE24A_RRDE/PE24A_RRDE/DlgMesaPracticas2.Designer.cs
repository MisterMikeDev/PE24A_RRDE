namespace PE24A_RRDE
{
    partial class DlgMesaPracticas2
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
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.PicSpotify = new System.Windows.Forms.PictureBox();
            this.PicBatery = new System.Windows.Forms.PictureBox();
            this.PicWifi = new System.Windows.Forms.PictureBox();
            this.LblCurrentDate = new System.Windows.Forms.Label();
            this.LblCurrentTime = new System.Windows.Forms.Label();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBatery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicWifi)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.Color.Black;
            this.PnlCentral.BackgroundImage = global::PE24A_RRDE.Properties.Resources.bgPractica2;
            this.PnlCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCentral.Controls.Add(this.PicSpotify);
            this.PnlCentral.Controls.Add(this.PicBatery);
            this.PnlCentral.Controls.Add(this.PicWifi);
            this.PnlCentral.Controls.Add(this.LblCurrentDate);
            this.PnlCentral.Controls.Add(this.LblCurrentTime);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(0, 0);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(1484, 808);
            this.PnlCentral.TabIndex = 0;
            // 
            // PicSpotify
            // 
            this.PicSpotify.BackColor = System.Drawing.Color.Transparent;
            this.PicSpotify.Image = global::PE24A_RRDE.Properties.Resources.Spotify;
            this.PicSpotify.Location = new System.Drawing.Point(12, 647);
            this.PicSpotify.Name = "PicSpotify";
            this.PicSpotify.Size = new System.Drawing.Size(323, 149);
            this.PicSpotify.TabIndex = 4;
            this.PicSpotify.TabStop = false;
            // 
            // PicBatery
            // 
            this.PicBatery.BackColor = System.Drawing.Color.Transparent;
            this.PicBatery.BackgroundImage = global::PE24A_RRDE.Properties.Resources.Battery;
            this.PicBatery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBatery.Location = new System.Drawing.Point(1428, 767);
            this.PicBatery.Name = "PicBatery";
            this.PicBatery.Size = new System.Drawing.Size(30, 29);
            this.PicBatery.TabIndex = 3;
            this.PicBatery.TabStop = false;
            // 
            // PicWifi
            // 
            this.PicWifi.BackColor = System.Drawing.Color.Transparent;
            this.PicWifi.BackgroundImage = global::PE24A_RRDE.Properties.Resources.wifi;
            this.PicWifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicWifi.Location = new System.Drawing.Point(1378, 767);
            this.PicWifi.Name = "PicWifi";
            this.PicWifi.Size = new System.Drawing.Size(30, 29);
            this.PicWifi.TabIndex = 2;
            this.PicWifi.TabStop = false;
            // 
            // LblCurrentDate
            // 
            this.LblCurrentDate.AutoSize = true;
            this.LblCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.LblCurrentDate.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentDate.ForeColor = System.Drawing.Color.White;
            this.LblCurrentDate.Location = new System.Drawing.Point(637, 280);
            this.LblCurrentDate.Name = "LblCurrentDate";
            this.LblCurrentDate.Size = new System.Drawing.Size(286, 49);
            this.LblCurrentDate.TabIndex = 1;
            this.LblCurrentDate.Text = "Friday, March 1";
            // 
            // LblCurrentTime
            // 
            this.LblCurrentTime.AutoSize = true;
            this.LblCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.LblCurrentTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.LblCurrentTime.Location = new System.Drawing.Point(635, 136);
            this.LblCurrentTime.Name = "LblCurrentTime";
            this.LblCurrentTime.Size = new System.Drawing.Size(285, 128);
            this.LblCurrentTime.TabIndex = 0;
            this.LblCurrentTime.Text = "12:00";
            // 
            // DlgMesaPracticas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 808);
            this.Controls.Add(this.PnlCentral);
            this.Name = "DlgMesaPracticas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Mesa Practicas 2";
            this.Resize += new System.EventHandler(this.DlgMesaPracticas2_Resize);
            this.PnlCentral.ResumeLayout(false);
            this.PnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBatery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicWifi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.Label LblCurrentTime;
        private System.Windows.Forms.Label LblCurrentDate;
        private System.Windows.Forms.PictureBox PicWifi;
        private System.Windows.Forms.PictureBox PicBatery;
        private System.Windows.Forms.PictureBox PicSpotify;
    }
}