﻿namespace ProjetDuBar
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
            this.drinkBeer1.Location = new System.Drawing.Point(64, 58);
            this.drinkBeer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkBeer1.Name = "drinkBeer1";
            this.drinkBeer1.Size = new System.Drawing.Size(161, 31);
            this.drinkBeer1.TabIndex = 7;
            this.drinkBeer1.Text = "boire une bière chimay";
            this.drinkBeer1.UseVisualStyleBackColor = true;
            this.drinkBeer1.Click += new System.EventHandler(this.drinkBeer1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "danser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "grater une conso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 277);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 31);
            this.button4.TabIndex = 11;
            this.button4.Text = "s\'poser à une table t\'as vu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // drinkBeerRinceCochon
            // 
            this.drinkBeerRinceCochon.Location = new System.Drawing.Point(4, 166);
            this.drinkBeerRinceCochon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkBeerRinceCochon.Name = "drinkBeerRinceCochon";
            this.drinkBeerRinceCochon.Size = new System.Drawing.Size(221, 31);
            this.drinkBeerRinceCochon.TabIndex = 12;
            this.drinkBeerRinceCochon.Text = "Acheter un saucisson à l\'ail";
            this.drinkBeerRinceCochon.UseVisualStyleBackColor = true;
            this.drinkBeerRinceCochon.Click += new System.EventHandler(this.drinkBeerRinceCochon_Click);
            // 
            // barmanButton
            // 
            this.barmanButton.Location = new System.Drawing.Point(221, 219);
            this.barmanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barmanButton.Name = "barmanButton";
            this.barmanButton.Size = new System.Drawing.Size(165, 31);
            this.barmanButton.TabIndex = 13;
            this.barmanButton.Text = "Barman";
            this.barmanButton.UseVisualStyleBackColor = true;
            this.barmanButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // drinkCocaButton
            // 
            this.drinkCocaButton.Location = new System.Drawing.Point(4, 114);
            this.drinkCocaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkCocaButton.Name = "drinkCocaButton";
            this.drinkCocaButton.Size = new System.Drawing.Size(221, 31);
            this.drinkCocaButton.TabIndex = 14;
            this.drinkCocaButton.Text = "boire un coca (t\'es sérieux la?!)";
            this.drinkCocaButton.UseVisualStyleBackColor = true;
            this.drinkCocaButton.Click += new System.EventHandler(this.drinkCocaButton_Click);
            // 
            // barModule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "barModule1";
            this.Size = new System.Drawing.Size(616, 414);
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
