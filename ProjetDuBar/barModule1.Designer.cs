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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.drinkBeerRinceCochon = new System.Windows.Forms.Button();
            this.barmanButton = new System.Windows.Forms.Button();
            this.drinkCocaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drinkBeer1
            // 
            this.drinkBeer1.Location = new System.Drawing.Point(48, 47);
            this.drinkBeer1.Name = "drinkBeer1";
            this.drinkBeer1.Size = new System.Drawing.Size(121, 25);
            this.drinkBeer1.TabIndex = 7;
            this.drinkBeer1.Text = "boire une bière chimay";
            this.drinkBeer1.UseVisualStyleBackColor = true;
            this.drinkBeer1.Click += new System.EventHandler(this.drinkBeer1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "danser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "grater une conso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 25);
            this.button4.TabIndex = 11;
            this.button4.Text = "s\'poser à une table t\'as vu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // drinkBeerRinceCochon
            // 
            this.drinkBeerRinceCochon.Location = new System.Drawing.Point(3, 135);
            this.drinkBeerRinceCochon.Name = "drinkBeerRinceCochon";
            this.drinkBeerRinceCochon.Size = new System.Drawing.Size(166, 25);
            this.drinkBeerRinceCochon.TabIndex = 12;
            this.drinkBeerRinceCochon.Text = "boire une bière rince cochon";
            this.drinkBeerRinceCochon.UseVisualStyleBackColor = true;
            this.drinkBeerRinceCochon.Click += new System.EventHandler(this.drinkBeerRinceCochon_Click);
            // 
            // barmanButton
            // 
            this.barmanButton.Location = new System.Drawing.Point(166, 178);
            this.barmanButton.Name = "barmanButton";
            this.barmanButton.Size = new System.Drawing.Size(124, 25);
            this.barmanButton.TabIndex = 13;
            this.barmanButton.Text = "Barman";
            this.barmanButton.UseVisualStyleBackColor = true;
            this.barmanButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // drinkCocaButton
            // 
            this.drinkCocaButton.Location = new System.Drawing.Point(3, 93);
            this.drinkCocaButton.Name = "drinkCocaButton";
            this.drinkCocaButton.Size = new System.Drawing.Size(166, 25);
            this.drinkCocaButton.TabIndex = 14;
            this.drinkCocaButton.Text = "boire un coca (t\'es sérieux la?!)";
            this.drinkCocaButton.UseVisualStyleBackColor = true;
            this.drinkCocaButton.Click += new System.EventHandler(this.drinkCocaButton_Click);
            // 
            // barModule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.drinkCocaButton);
            this.Controls.Add(this.barmanButton);
            this.Controls.Add(this.drinkBeerRinceCochon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drinkBeer1);
            this.Name = "barModule1";
            this.Size = new System.Drawing.Size(462, 336);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drinkBeer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button drinkBeerRinceCochon;
        private System.Windows.Forms.Button barmanButton;
        private System.Windows.Forms.Button drinkCocaButton;
    }
}
