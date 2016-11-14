namespace ProjetDuBar
{
    partial class finalModule
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finalModule));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alcool = new System.Windows.Forms.TextBox();
            this.argent = new System.Windows.Forms.TextBox();
            this.enjaille = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // alcool
            // 
            this.alcool.Location = new System.Drawing.Point(90, 209);
            this.alcool.Name = "alcool";
            this.alcool.Size = new System.Drawing.Size(429, 22);
            this.alcool.TabIndex = 1;
            this.alcool.TextChanged += new System.EventHandler(this.alcool_TextChanged);
            // 
            // argent
            // 
            this.argent.Location = new System.Drawing.Point(91, 271);
            this.argent.Name = "argent";
            this.argent.Size = new System.Drawing.Size(429, 22);
            this.argent.TabIndex = 2;
            // 
            // enjaille
            // 
            this.enjaille.Location = new System.Drawing.Point(90, 332);
            this.enjaille.Name = "enjaille";
            this.enjaille.Size = new System.Drawing.Size(429, 22);
            this.enjaille.TabIndex = 4;
            // 
            // finalModule
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.enjaille);
            this.Controls.Add(this.argent);
            this.Controls.Add(this.alcool);
            this.Controls.Add(this.pictureBox1);
            this.Name = "finalModule";
            this.Size = new System.Drawing.Size(609, 448);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox alcool;
        private System.Windows.Forms.TextBox argent;
        private System.Windows.Forms.TextBox enjaille;
    }
}
#endregion