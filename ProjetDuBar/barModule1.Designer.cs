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
            this.danse = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.drinkBeerRinceCochon = new System.Windows.Forms.Button();
            this.barmanButton = new System.Windows.Forms.Button();
            this.drinkCocaButton = new System.Windows.Forms.Button();
            this.conso = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
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
            // danse
            // 
            this.danse.Location = new System.Drawing.Point(48, 225);
            this.danse.Name = "danse";
            this.danse.Size = new System.Drawing.Size(121, 25);
            this.danse.TabIndex = 8;
            this.danse.Text = "danser";
            this.danse.UseVisualStyleBackColor = true;
            this.danse.Click += new System.EventHandler(this.button1_Click);
            // 
            // table
            // 
            this.table.Location = new System.Drawing.Point(288, 225);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(159, 25);
            this.table.TabIndex = 11;
            this.table.Text = "s\'poser à une table t\'as vu";
            this.table.UseVisualStyleBackColor = true;
            this.table.Click += new System.EventHandler(this.button4_Click);
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
            // conso
            // 
            this.conso.Location = new System.Drawing.Point(326, 135);
            this.conso.Name = "conso";
            this.conso.Size = new System.Drawing.Size(121, 25);
            this.conso.TabIndex = 15;
            this.conso.Text = "grater une conso";
            this.conso.UseVisualStyleBackColor = true;
            this.conso.Click += new System.EventHandler(this.button2_Click);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.Info;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Cursor = System.Windows.Forms.Cursors.No;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.description.Location = new System.Drawing.Point(3, 362);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(592, 16);
            this.description.TabIndex = 16;
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // barModule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.description);
            this.Controls.Add(this.conso);
            this.Controls.Add(this.drinkCocaButton);
            this.Controls.Add(this.barmanButton);
            this.Controls.Add(this.drinkBeerRinceCochon);
            this.Controls.Add(this.table);
            this.Controls.Add(this.danse);
            this.Controls.Add(this.drinkBeer1);
            this.Name = "barModule1";
            this.Size = new System.Drawing.Size(559, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drinkBeer1;
        private System.Windows.Forms.Button danse;
        private System.Windows.Forms.Button table;
        private System.Windows.Forms.Button drinkBeerRinceCochon;
        private System.Windows.Forms.Button barmanButton;
        private System.Windows.Forms.Button drinkCocaButton;
        private System.Windows.Forms.Button conso;
        private System.Windows.Forms.TextBox description;
    }
}
