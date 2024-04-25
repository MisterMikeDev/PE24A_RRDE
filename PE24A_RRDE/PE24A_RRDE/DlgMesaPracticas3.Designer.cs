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
            this.PnlSidebar = new System.Windows.Forms.Panel();
            this.LblLoadingText = new System.Windows.Forms.Label();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnShowCanvas = new System.Windows.Forms.Button();
            this.DgvVectors = new System.Windows.Forms.DataGridView();
            this.Vectors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VectorX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VectorY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlCanvas = new System.Windows.Forms.Panel();
            this.LblInitialX = new System.Windows.Forms.Label();
            this.TextBoxInitialX = new System.Windows.Forms.TextBox();
            this.TextBoxInitialY = new System.Windows.Forms.TextBox();
            this.LblInitialY = new System.Windows.Forms.Label();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.TrackBarLineHeight = new System.Windows.Forms.TrackBar();
            this.LblLineHeight = new System.Windows.Forms.Label();
            this.LblLineSize = new System.Windows.Forms.Label();
            this.PnlCentral.SuspendLayout();
            this.PnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLineHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackgroundImage = global::PE24A_RRDE.Properties.Resources.bgPractica3;
            this.PnlCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCentral.Controls.Add(this.BtnDraw);
            this.PnlCentral.Controls.Add(this.PnlSidebar);
            this.PnlCentral.Controls.Add(this.DgvVectors);
            this.PnlCentral.Controls.Add(this.PnlCanvas);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(0, 0);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(1484, 808);
            this.PnlCentral.TabIndex = 0;
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PnlSidebar.Controls.Add(this.LblLineSize);
            this.PnlSidebar.Controls.Add(this.LblLineHeight);
            this.PnlSidebar.Controls.Add(this.TrackBarLineHeight);
            this.PnlSidebar.Controls.Add(this.TextBoxInitialY);
            this.PnlSidebar.Controls.Add(this.LblInitialY);
            this.PnlSidebar.Controls.Add(this.TextBoxInitialX);
            this.PnlSidebar.Controls.Add(this.LblInitialX);
            this.PnlSidebar.Controls.Add(this.LblLoadingText);
            this.PnlSidebar.Controls.Add(this.BtnImport);
            this.PnlSidebar.Controls.Add(this.BtnShowCanvas);
            this.PnlSidebar.Location = new System.Drawing.Point(10, 12);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(216, 784);
            this.PnlSidebar.TabIndex = 11;
            // 
            // LblLoadingText
            // 
            this.LblLoadingText.AutoSize = true;
            this.LblLoadingText.BackColor = System.Drawing.Color.Transparent;
            this.LblLoadingText.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold);
            this.LblLoadingText.ForeColor = System.Drawing.Color.Black;
            this.LblLoadingText.Location = new System.Drawing.Point(23, 729);
            this.LblLoadingText.Name = "LblLoadingText";
            this.LblLoadingText.Size = new System.Drawing.Size(175, 38);
            this.LblLoadingText.TabIndex = 10;
            this.LblLoadingText.Text = "Cargando...";
            this.LblLoadingText.Visible = false;
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnImport.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.Color.White;
            this.BtnImport.Location = new System.Drawing.Point(3, 16);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(210, 54);
            this.BtnImport.TabIndex = 9;
            this.BtnImport.Text = "Importar";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnShowCanvas
            // 
            this.BtnShowCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnShowCanvas.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowCanvas.ForeColor = System.Drawing.Color.White;
            this.BtnShowCanvas.Location = new System.Drawing.Point(3, 76);
            this.BtnShowCanvas.Name = "BtnShowCanvas";
            this.BtnShowCanvas.Size = new System.Drawing.Size(210, 85);
            this.BtnShowCanvas.TabIndex = 6;
            this.BtnShowCanvas.Text = "Mostrar Canvas";
            this.BtnShowCanvas.UseVisualStyleBackColor = false;
            this.BtnShowCanvas.Click += new System.EventHandler(this.BtnShowCanvas_Click);
            // 
            // DgvVectors
            // 
            this.DgvVectors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvVectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vectors,
            this.VectorX,
            this.VectorY});
            this.DgvVectors.Location = new System.Drawing.Point(1213, 12);
            this.DgvVectors.Name = "DgvVectors";
            this.DgvVectors.Size = new System.Drawing.Size(257, 724);
            this.DgvVectors.TabIndex = 8;
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
            // PnlCanvas
            // 
            this.PnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCanvas.BackColor = System.Drawing.Color.White;
            this.PnlCanvas.Location = new System.Drawing.Point(232, 12);
            this.PnlCanvas.Name = "PnlCanvas";
            this.PnlCanvas.Size = new System.Drawing.Size(975, 784);
            this.PnlCanvas.TabIndex = 7;
            this.PnlCanvas.Visible = false;
            // 
            // LblInitialX
            // 
            this.LblInitialX.AutoSize = true;
            this.LblInitialX.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInitialX.Location = new System.Drawing.Point(16, 181);
            this.LblInitialX.Name = "LblInitialX";
            this.LblInitialX.Size = new System.Drawing.Size(144, 21);
            this.LblInitialX.TabIndex = 11;
            this.LblInitialX.Text = "Punto de inicio X:";
            // 
            // TextBoxInitialX
            // 
            this.TextBoxInitialX.Location = new System.Drawing.Point(19, 205);
            this.TextBoxInitialX.Name = "TextBoxInitialX";
            this.TextBoxInitialX.Size = new System.Drawing.Size(179, 20);
            this.TextBoxInitialX.TabIndex = 12;
            // 
            // TextBoxInitialY
            // 
            this.TextBoxInitialY.Location = new System.Drawing.Point(19, 252);
            this.TextBoxInitialY.Name = "TextBoxInitialY";
            this.TextBoxInitialY.Size = new System.Drawing.Size(179, 20);
            this.TextBoxInitialY.TabIndex = 14;
            // 
            // LblInitialY
            // 
            this.LblInitialY.AutoSize = true;
            this.LblInitialY.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInitialY.Location = new System.Drawing.Point(16, 228);
            this.LblInitialY.Name = "LblInitialY";
            this.LblInitialY.Size = new System.Drawing.Size(143, 21);
            this.LblInitialY.TabIndex = 13;
            this.LblInitialY.Text = "Punto de inicio Y:";
            // 
            // BtnDraw
            // 
            this.BtnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnDraw.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraw.ForeColor = System.Drawing.Color.White;
            this.BtnDraw.Location = new System.Drawing.Point(1213, 742);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(257, 54);
            this.BtnDraw.TabIndex = 15;
            this.BtnDraw.Text = "Dibujar";
            this.BtnDraw.UseVisualStyleBackColor = false;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // TrackBarLineHeight
            // 
            this.TrackBarLineHeight.Location = new System.Drawing.Point(19, 323);
            this.TrackBarLineHeight.Maximum = 12;
            this.TrackBarLineHeight.Minimum = 1;
            this.TrackBarLineHeight.Name = "TrackBarLineHeight";
            this.TrackBarLineHeight.Size = new System.Drawing.Size(141, 45);
            this.TrackBarLineHeight.TabIndex = 15;
            this.TrackBarLineHeight.Value = 1;
            this.TrackBarLineHeight.Scroll += new System.EventHandler(this.TrackBarLineHeight_Scroll);
            // 
            // LblLineHeight
            // 
            this.LblLineHeight.AutoSize = true;
            this.LblLineHeight.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLineHeight.Location = new System.Drawing.Point(15, 299);
            this.LblLineHeight.Name = "LblLineHeight";
            this.LblLineHeight.Size = new System.Drawing.Size(144, 21);
            this.LblLineHeight.TabIndex = 16;
            this.LblLineHeight.Text = "Grosor de la linea:";
            // 
            // LblLineSize
            // 
            this.LblLineSize.AutoSize = true;
            this.LblLineSize.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLineSize.Location = new System.Drawing.Point(163, 323);
            this.LblLineSize.Name = "LblLineSize";
            this.LblLineSize.Size = new System.Drawing.Size(27, 17);
            this.LblLineSize.TabIndex = 18;
            this.LblLineSize.Text = "1px";
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
            this.PnlSidebar.ResumeLayout(false);
            this.PnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLineHeight)).EndInit();
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
        private System.Windows.Forms.Panel PnlSidebar;
        private System.Windows.Forms.TextBox TextBoxInitialX;
        private System.Windows.Forms.Label LblInitialX;
        private System.Windows.Forms.TextBox TextBoxInitialY;
        private System.Windows.Forms.Label LblInitialY;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Label LblLineHeight;
        private System.Windows.Forms.TrackBar TrackBarLineHeight;
        private System.Windows.Forms.Label LblLineSize;
    }
}