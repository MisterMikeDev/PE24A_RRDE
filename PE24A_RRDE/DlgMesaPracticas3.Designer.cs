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
            this.BtnDraw = new System.Windows.Forms.Button();
            this.PnlSidebar = new System.Windows.Forms.Panel();
            this.LbRotationDeg = new System.Windows.Forms.Label();
            this.LblRotation = new System.Windows.Forms.Label();
            this.TrackBarRotation = new System.Windows.Forms.TrackBar();
            this.LblMarginSize = new System.Windows.Forms.Label();
            this.LblMargin = new System.Windows.Forms.Label();
            this.TrackBarMargin = new System.Windows.Forms.TrackBar();
            this.TextBoxArea = new System.Windows.Forms.TextBox();
            this.LblArea = new System.Windows.Forms.Label();
            this.TextBoxPerimeter = new System.Windows.Forms.TextBox();
            this.LblPerimeter = new System.Windows.Forms.Label();
            this.LblLineSize = new System.Windows.Forms.Label();
            this.LblLineHeight = new System.Windows.Forms.Label();
            this.TrackBarLineHeight = new System.Windows.Forms.TrackBar();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnShowCanvas = new System.Windows.Forms.Button();
            this.DgvVectors = new System.Windows.Forms.DataGridView();
            this.Vectors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VectorX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VectorY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlCanvas = new System.Windows.Forms.Panel();
            this.PnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLineHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectors)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDraw
            // 
            this.BtnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BtnDraw.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraw.ForeColor = System.Drawing.Color.White;
            this.BtnDraw.Location = new System.Drawing.Point(1215, 742);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(257, 54);
            this.BtnDraw.TabIndex = 19;
            this.BtnDraw.Text = "Dibujar";
            this.BtnDraw.UseVisualStyleBackColor = false;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PnlSidebar.Controls.Add(this.LbRotationDeg);
            this.PnlSidebar.Controls.Add(this.LblRotation);
            this.PnlSidebar.Controls.Add(this.TrackBarRotation);
            this.PnlSidebar.Controls.Add(this.LblMarginSize);
            this.PnlSidebar.Controls.Add(this.LblMargin);
            this.PnlSidebar.Controls.Add(this.TrackBarMargin);
            this.PnlSidebar.Controls.Add(this.TextBoxArea);
            this.PnlSidebar.Controls.Add(this.LblArea);
            this.PnlSidebar.Controls.Add(this.TextBoxPerimeter);
            this.PnlSidebar.Controls.Add(this.LblPerimeter);
            this.PnlSidebar.Controls.Add(this.LblLineSize);
            this.PnlSidebar.Controls.Add(this.LblLineHeight);
            this.PnlSidebar.Controls.Add(this.TrackBarLineHeight);
            this.PnlSidebar.Controls.Add(this.BtnImport);
            this.PnlSidebar.Controls.Add(this.BtnShowCanvas);
            this.PnlSidebar.Location = new System.Drawing.Point(12, 12);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(216, 784);
            this.PnlSidebar.TabIndex = 18;
            // 
            // LbRotationDeg
            // 
            this.LbRotationDeg.AutoSize = true;
            this.LbRotationDeg.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRotationDeg.Location = new System.Drawing.Point(162, 326);
            this.LbRotationDeg.Name = "LbRotationDeg";
            this.LbRotationDeg.Size = new System.Drawing.Size(24, 17);
            this.LbRotationDeg.TabIndex = 30;
            this.LbRotationDeg.Text = "0 °";
            // 
            // LblRotation
            // 
            this.LblRotation.AutoSize = true;
            this.LblRotation.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRotation.Location = new System.Drawing.Point(14, 302);
            this.LblRotation.Name = "LblRotation";
            this.LblRotation.Size = new System.Drawing.Size(161, 21);
            this.LblRotation.TabIndex = 29;
            this.LblRotation.Text = "Rotación del dibujo:";
            // 
            // TrackBarRotation
            // 
            this.TrackBarRotation.Location = new System.Drawing.Point(18, 326);
            this.TrackBarRotation.Maximum = 360;
            this.TrackBarRotation.Name = "TrackBarRotation";
            this.TrackBarRotation.Size = new System.Drawing.Size(141, 45);
            this.TrackBarRotation.TabIndex = 28;
            this.TrackBarRotation.Value = 1;
            this.TrackBarRotation.Scroll += new System.EventHandler(this.TrackBarRotation_Scroll);
            // 
            // LblMarginSize
            // 
            this.LblMarginSize.AutoSize = true;
            this.LblMarginSize.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarginSize.Location = new System.Drawing.Point(162, 202);
            this.LblMarginSize.Name = "LblMarginSize";
            this.LblMarginSize.Size = new System.Drawing.Size(27, 17);
            this.LblMarginSize.TabIndex = 27;
            this.LblMarginSize.Text = "1px";
            // 
            // LblMargin
            // 
            this.LblMargin.AutoSize = true;
            this.LblMargin.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMargin.Location = new System.Drawing.Point(14, 178);
            this.LblMargin.Name = "LblMargin";
            this.LblMargin.Size = new System.Drawing.Size(152, 21);
            this.LblMargin.TabIndex = 26;
            this.LblMargin.Text = "Margen del dibujo:";
            // 
            // TrackBarMargin
            // 
            this.TrackBarMargin.Location = new System.Drawing.Point(18, 202);
            this.TrackBarMargin.Maximum = 200;
            this.TrackBarMargin.Name = "TrackBarMargin";
            this.TrackBarMargin.Size = new System.Drawing.Size(141, 45);
            this.TrackBarMargin.TabIndex = 25;
            this.TrackBarMargin.TickFrequency = 10;
            this.TrackBarMargin.Value = 1;
            this.TrackBarMargin.Scroll += new System.EventHandler(this.TrackBarMargin_Scroll);
            // 
            // TextBoxArea
            // 
            this.TextBoxArea.Location = new System.Drawing.Point(18, 441);
            this.TextBoxArea.Name = "TextBoxArea";
            this.TextBoxArea.ReadOnly = true;
            this.TextBoxArea.Size = new System.Drawing.Size(179, 20);
            this.TextBoxArea.TabIndex = 24;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.Location = new System.Drawing.Point(15, 417);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(49, 21);
            this.LblArea.TabIndex = 23;
            this.LblArea.Text = "Area:";
            // 
            // TextBoxPerimeter
            // 
            this.TextBoxPerimeter.Location = new System.Drawing.Point(18, 394);
            this.TextBoxPerimeter.Name = "TextBoxPerimeter";
            this.TextBoxPerimeter.ReadOnly = true;
            this.TextBoxPerimeter.Size = new System.Drawing.Size(179, 20);
            this.TextBoxPerimeter.TabIndex = 22;
            // 
            // LblPerimeter
            // 
            this.LblPerimeter.AutoSize = true;
            this.LblPerimeter.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerimeter.Location = new System.Drawing.Point(15, 370);
            this.LblPerimeter.Name = "LblPerimeter";
            this.LblPerimeter.Size = new System.Drawing.Size(91, 21);
            this.LblPerimeter.TabIndex = 21;
            this.LblPerimeter.Text = "Perimetro:";
            // 
            // LblLineSize
            // 
            this.LblLineSize.AutoSize = true;
            this.LblLineSize.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLineSize.Location = new System.Drawing.Point(162, 264);
            this.LblLineSize.Name = "LblLineSize";
            this.LblLineSize.Size = new System.Drawing.Size(27, 17);
            this.LblLineSize.TabIndex = 18;
            this.LblLineSize.Text = "1px";
            // 
            // LblLineHeight
            // 
            this.LblLineHeight.AutoSize = true;
            this.LblLineHeight.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLineHeight.Location = new System.Drawing.Point(14, 240);
            this.LblLineHeight.Name = "LblLineHeight";
            this.LblLineHeight.Size = new System.Drawing.Size(144, 21);
            this.LblLineHeight.TabIndex = 16;
            this.LblLineHeight.Text = "Grosor de la linea:";
            // 
            // TrackBarLineHeight
            // 
            this.TrackBarLineHeight.Location = new System.Drawing.Point(18, 264);
            this.TrackBarLineHeight.Maximum = 12;
            this.TrackBarLineHeight.Minimum = 1;
            this.TrackBarLineHeight.Name = "TrackBarLineHeight";
            this.TrackBarLineHeight.Size = new System.Drawing.Size(141, 45);
            this.TrackBarLineHeight.TabIndex = 15;
            this.TrackBarLineHeight.Value = 1;
            this.TrackBarLineHeight.Scroll += new System.EventHandler(this.TrackBarLineHeight_Scroll);
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
            this.DgvVectors.Location = new System.Drawing.Point(1215, 12);
            this.DgvVectors.Name = "DgvVectors";
            this.DgvVectors.Size = new System.Drawing.Size(257, 724);
            this.DgvVectors.TabIndex = 17;
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
            this.PnlCanvas.Location = new System.Drawing.Point(234, 12);
            this.PnlCanvas.Name = "PnlCanvas";
            this.PnlCanvas.Size = new System.Drawing.Size(975, 784);
            this.PnlCanvas.TabIndex = 16;
            this.PnlCanvas.Visible = false;
            // 
            // DlgMesaPracticas3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PE24A_RRDE.Properties.Resources.bgPractica3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 808);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.PnlSidebar);
            this.Controls.Add(this.DgvVectors);
            this.Controls.Add(this.PnlCanvas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgMesaPracticas3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Mesa Practicas 3";
            this.PnlSidebar.ResumeLayout(false);
            this.PnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLineHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Panel PnlSidebar;
        private System.Windows.Forms.Label LblLineSize;
        private System.Windows.Forms.Label LblLineHeight;
        private System.Windows.Forms.TrackBar TrackBarLineHeight;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnShowCanvas;
        private System.Windows.Forms.DataGridView DgvVectors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vectors;
        private System.Windows.Forms.DataGridViewTextBoxColumn VectorX;
        private System.Windows.Forms.DataGridViewTextBoxColumn VectorY;
        private System.Windows.Forms.Panel PnlCanvas;
        private System.Windows.Forms.TextBox TextBoxArea;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox TextBoxPerimeter;
        private System.Windows.Forms.Label LblPerimeter;
        private System.Windows.Forms.Label LblMarginSize;
        private System.Windows.Forms.Label LblMargin;
        private System.Windows.Forms.TrackBar TrackBarMargin;
        private System.Windows.Forms.Label LbRotationDeg;
        private System.Windows.Forms.Label LblRotation;
        private System.Windows.Forms.TrackBar TrackBarRotation;
    }
}