namespace PBKDF2_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.passtb = new System.Windows.Forms.TextBox();
            this.svctb = new System.Windows.Forms.TextBox();
            this.genbtn = new System.Windows.Forms.Button();
            this.resulttb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passtb
            // 
            this.passtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passtb.Location = new System.Drawing.Point(13, 13);
            this.passtb.Name = "passtb";
            this.passtb.PasswordChar = '*';
            this.passtb.Size = new System.Drawing.Size(266, 20);
            this.passtb.TabIndex = 0;
            this.passtb.Text = "Password";
            // 
            // svctb
            // 
            this.svctb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.svctb.Location = new System.Drawing.Point(13, 40);
            this.svctb.Name = "svctb";
            this.svctb.Size = new System.Drawing.Size(266, 20);
            this.svctb.TabIndex = 1;
            this.svctb.Text = "Service (not case-sensitive)";
            // 
            // genbtn
            // 
            this.genbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genbtn.Location = new System.Drawing.Point(13, 67);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(266, 61);
            this.genbtn.TabIndex = 2;
            this.genbtn.Text = "Generate";
            this.genbtn.UseVisualStyleBackColor = true;
            this.genbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // resulttb
            // 
            this.resulttb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resulttb.Location = new System.Drawing.Point(13, 135);
            this.resulttb.Name = "resulttb";
            this.resulttb.ReadOnly = true;
            this.resulttb.Size = new System.Drawing.Size(266, 20);
            this.resulttb.TabIndex = 3;
            this.resulttb.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 165);
            this.Controls.Add(this.resulttb);
            this.Controls.Add(this.genbtn);
            this.Controls.Add(this.svctb);
            this.Controls.Add(this.passtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.TextBox svctb;
        private System.Windows.Forms.Button genbtn;
        private System.Windows.Forms.TextBox resulttb;
    }
}

