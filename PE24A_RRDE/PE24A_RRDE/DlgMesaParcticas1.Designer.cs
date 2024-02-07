namespace PE24A_RRDE
{
    partial class DlgMesaParcticas1
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
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoMesa1 = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.TextBoxNum2 = new System.Windows.Forms.TextBox();
            this.TextBoxNum1 = new System.Windows.Forms.TextBox();
            this.PnlDerecho = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.BtnTest = new System.Windows.Forms.Button();
            this.PnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMesa1)).BeginInit();
            this.PnlIzquierdo.SuspendLayout();
            this.PnlDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.PnlSuperior.Controls.Add(this.label1);
            this.PnlSuperior.Controls.Add(this.LogoMesa1);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(1484, 80);
            this.PnlSuperior.TabIndex = 0;
            this.PnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesa de trabajo I";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogoMesa1
            // 
            this.LogoMesa1.BackgroundImage = global::PE24A_RRDE.Properties.Resources.favicon__1_;
            this.LogoMesa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoMesa1.Location = new System.Drawing.Point(24, 12);
            this.LogoMesa1.Name = "LogoMesa1";
            this.LogoMesa1.Size = new System.Drawing.Size(53, 59);
            this.LogoMesa1.TabIndex = 0;
            this.LogoMesa1.TabStop = false;
            this.LogoMesa1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.PnlIzquierdo.Controls.Add(this.BtnTest);
            this.PnlIzquierdo.Controls.Add(this.TextBoxNum2);
            this.PnlIzquierdo.Controls.Add(this.TextBoxNum1);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 80);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(150, 728);
            this.PnlIzquierdo.TabIndex = 1;
            this.PnlIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // TextBoxNum2
            // 
            this.TextBoxNum2.Location = new System.Drawing.Point(12, 75);
            this.TextBoxNum2.Name = "TextBoxNum2";
            this.TextBoxNum2.Size = new System.Drawing.Size(119, 20);
            this.TextBoxNum2.TabIndex = 1;
            this.TextBoxNum2.TextChanged += new System.EventHandler(this.TextBoxNum2_TextChanged);
            // 
            // TextBoxNum1
            // 
            this.TextBoxNum1.Location = new System.Drawing.Point(13, 28);
            this.TextBoxNum1.Name = "TextBoxNum1";
            this.TextBoxNum1.Size = new System.Drawing.Size(119, 20);
            this.TextBoxNum1.TabIndex = 0;
            this.TextBoxNum1.TextChanged += new System.EventHandler(this.TextBoxNum1_TextChanged);
            // 
            // PnlDerecho
            // 
            this.PnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.PnlDerecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlDerecho.Controls.Add(this.comboBox1);
            this.PnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecho.Location = new System.Drawing.Point(1334, 80);
            this.PnlDerecho.Name = "PnlDerecho";
            this.PnlDerecho.Size = new System.Drawing.Size(150, 728);
            this.PnlDerecho.TabIndex = 2;
            this.PnlDerecho.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDerecho_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.Color.Transparent;
            this.PnlCentral.BackgroundImage = global::PE24A_RRDE.Properties.Resources.bg;
            this.PnlCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(150, 80);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(1184, 728);
            this.PnlCentral.TabIndex = 3;
            this.PnlCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(13, 119);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(118, 31);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "Boton de prueba";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // DlgMesaParcticas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 808);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlDerecho);
            this.Controls.Add(this.PnlIzquierdo);
            this.Controls.Add(this.PnlSuperior);
            this.Name = "DlgMesaParcticas1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DlgMesaParcticas1";
            this.Load += new System.EventHandler(this.DlgMesaParcticas1_Load);
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMesa1)).EndInit();
            this.PnlIzquierdo.ResumeLayout(false);
            this.PnlIzquierdo.PerformLayout();
            this.PnlDerecho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Panel PnlDerecho;
        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.PictureBox LogoMesa1;
        private System.Windows.Forms.TextBox TextBoxNum2;
        private System.Windows.Forms.TextBox TextBoxNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnTest;
    }
}