namespace ProjetDuBar
{
    partial class barModule1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barModule1));
            this.drinkBeer1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drinkBeer1
            // 
            this.drinkBeer1.Location = new System.Drawing.Point(35, 217);
            this.drinkBeer1.Name = "drinkBeer1";
            this.drinkBeer1.Size = new System.Drawing.Size(121, 25);
            this.drinkBeer1.TabIndex = 7;
            this.drinkBeer1.Text = "boire une bière chimay";
            this.drinkBeer1.UseVisualStyleBackColor = true;
            this.drinkBeer1.Click += new System.EventHandler(this.drinkBeer1_Click);
            // 
            // barModule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.drinkBeer1);
            this.Name = "barModule1";
            this.Size = new System.Drawing.Size(462, 336);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drinkBeer1;
    }
}
