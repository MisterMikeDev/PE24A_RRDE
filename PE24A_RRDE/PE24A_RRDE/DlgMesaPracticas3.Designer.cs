namespace PE24A_RRDE
{
    partial class DlgMesaPracticas3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMesaPracticas3));
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.BtnImport = new System.Windows.Forms.Button();
            this.DgvVectors = new System.Windows.Forms.DataGridView();
            this.PnlCanvas = new System.Windows.Forms.Panel();
            this.BtnShowCanvas = new System.Windows.Forms.Button();
            this.LblLoadingText = new System.Windows.Forms.Label();
            this.Vectors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VectorX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VectorY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectors)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackgroundImage = global::PE24A_RRDE.Properties.Resources.bgPractica3;
            this.PnlCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCentral.Controls.Add(this.LblLoadingText);
            this.PnlCentral.Controls.Add(this.BtnImport);
            this.PnlCentral.Controls.Add(this.DgvVectors);
            this.PnlCentral.Controls.Add(this.PnlCanvas);
            this.PnlCentral.Controls.Add(this.BtnShowCanvas);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(0, 0);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(1484, 808);
            this.PnlCentral.TabIndex = 0;
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnImport.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.Color.White;
            this.BtnImport.Location = new System.Drawing.Point(285, 23);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(258, 54);
            this.BtnImport.TabIndex = 9;
            this.BtnImport.Text = "Importar";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // DgvVectors
            // 
            this.DgvVectors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvVectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vectors,
            this.VectorX,
            this.VectorY});
            this.DgvVectors.Location = new System.Drawing.Point(13, 92);
            this.DgvVectors.Name = "DgvVectors";
            this.DgvVectors.Size = new System.Drawing.Size(257, 704);
            this.DgvVectors.TabIndex = 8;
            // 
            // PnlCanvas
            // 
            this.PnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCanvas.BackColor = System.Drawing.Color.White;
            this.PnlCanvas.Location = new System.Drawing.Point(285, 92);
            this.PnlCanvas.Name = "PnlCanvas";
            this.PnlCanvas.Size = new System.Drawing.Size(1187, 704);
            this.PnlCanvas.TabIndex = 7;
            this.PnlCanvas.Visible = false;
            // 
            // BtnShowCanvas
            // 
            this.BtnShowCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnShowCanvas.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowCanvas.ForeColor = System.Drawing.Color.White;
            this.BtnShowCanvas.Location = new System.Drawing.Point(12, 23);
            this.BtnShowCanvas.Name = "BtnShowCanvas";
            this.BtnShowCanvas.Size = new System.Drawing.Size(258, 54);
            this.BtnShowCanvas.TabIndex = 6;
            this.BtnShowCanvas.Text = "Mostrar Canvas";
            this.BtnShowCanvas.UseVisualStyleBackColor = false;
            this.BtnShowCanvas.Click += new System.EventHandler(this.BtnShowCanvas_Click);
            // 
            // LblLoadingText
            // 
            this.LblLoadingText.AutoSize = true;
            this.LblLoadingText.BackColor = System.Drawing.Color.Transparent;
            this.LblLoadingText.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold);
            this.LblLoadingText.ForeColor = System.Drawing.Color.White;
            this.LblLoadingText.Location = new System.Drawing.Point(549, 31);
            this.LblLoadingText.Name = "LblLoadingText";
            this.LblLoadingText.Size = new System.Drawing.Size(175, 38);
            this.LblLoadingText.TabIndex = 10;
            this.LblLoadingText.Text = "Cargando...";
            this.LblLoadingText.Visible = false;
            // 
            // Vectors
            // 
            this.Vectors.HeaderText = "Vectors";
            this.Vectors.Name = "Vectors";
            // 
            // VectorX
            // 
            this.VectorX.HeaderText = "X";
            this.VectorX.Name = "VectorX";
            // 
            // VectorY
            // 
            this.VectorY.HeaderText = "Y";
            this.VectorY.Name = "VectorY";
            // 
            // DlgMesaPracticas3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 808);
            this.Controls.Add(this.PnlCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "DlgMesaPracticas3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Mesa Practicas 3";
            this.Resize += new System.EventHandler(this.DlgMesaPracticas3_Resize);
            this.PnlCentral.ResumeLayout(false);
            this.PnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.Button BtnShowCanvas;
        private System.Windows.Forms.Panel PnlCanvas;
        private System.Windows.Forms.DataGridView DgvVectors;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Label LblLoadingText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vectors;
        private System.Windows.Forms.DataGridViewTextBoxColumn VectorX;
        private System.Windows.Forms.DataGridViewTextBoxColumn VectorY;
    }
}