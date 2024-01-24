namespace PE24A_RRDE
{
    partial class DlgPrincipal
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
            this.BtnHelloWorld = new System.Windows.Forms.Button();
            this.ChbHello = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnHelloWorld
            // 
            this.BtnHelloWorld.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnHelloWorld.Font = new System.Drawing.Font("Minecrafter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelloWorld.ForeColor = System.Drawing.Color.Snow;
            this.BtnHelloWorld.Location = new System.Drawing.Point(12, 12);
            this.BtnHelloWorld.Name = "BtnHelloWorld";
            this.BtnHelloWorld.Size = new System.Drawing.Size(291, 104);
            this.BtnHelloWorld.TabIndex = 0;
            this.BtnHelloWorld.Text = "Hello World";
            this.BtnHelloWorld.UseVisualStyleBackColor = false;
            this.BtnHelloWorld.Click += new System.EventHandler(this.BtnHelloWorld_Click);
            // 
            // ChbHello
            // 
            this.ChbHello.AutoSize = true;
            this.ChbHello.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChbHello.Location = new System.Drawing.Point(118, 153);
            this.ChbHello.Name = "ChbHello";
            this.ChbHello.Size = new System.Drawing.Size(89, 17);
            this.ChbHello.TabIndex = 1;
            this.ChbHello.Text = "MyCheckBox";
            this.ChbHello.UseVisualStyleBackColor = false;
            this.ChbHello.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DlgPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1484, 808);
            this.Controls.Add(this.ChbHello);
            this.Controls.Add(this.BtnHelloWorld);
            this.Name = "DlgPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Programación Estructurada 24A";
            this.Load += new System.EventHandler(this.DlgPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHelloWorld;
        private System.Windows.Forms.CheckBox ChbHello;
    }
}

