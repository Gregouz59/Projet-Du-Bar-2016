namespace ProjetDuBar
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enterNewGame = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.progressBarArgent = new System.Windows.Forms.ProgressBar();
            this.progressBarAlcool = new System.Windows.Forms.ProgressBar();
            this.otherBarButton = new System.Windows.Forms.Button();
            this.getMoneyButton = new System.Windows.Forms.Button();
            this.enjoyProgressBar = new System.Windows.Forms.ProgressBar();
            this.AlcoolText = new System.Windows.Forms.TextBox();
            this.ArgentText = new System.Windows.Forms.TextBox();
            this.heureTexte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.actualiser = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterNewGame
            // 
            this.enterNewGame.Location = new System.Drawing.Point(819, 128);
            this.enterNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterNewGame.Name = "enterNewGame";
            this.enterNewGame.Size = new System.Drawing.Size(196, 28);
            this.enterNewGame.TabIndex = 0;
            this.enterNewGame.Text = "New Game";
            this.enterNewGame.UseVisualStyleBackColor = true;
            this.enterNewGame.Click += new System.EventHandler(this.enterNewGame_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(17, 16);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(793, 480);
            this.panel.TabIndex = 1;
            // 
            // progressBarArgent
            // 
            this.progressBarArgent.Location = new System.Drawing.Point(819, 332);
            this.progressBarArgent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarArgent.Name = "progressBarArgent";
            this.progressBarArgent.Size = new System.Drawing.Size(196, 28);
            this.progressBarArgent.TabIndex = 3;
            this.progressBarArgent.Click += new System.EventHandler(this.progressBarArgent_Click);
            // 
            // progressBarAlcool
            // 
            this.progressBarAlcool.Location = new System.Drawing.Point(819, 400);
            this.progressBarAlcool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarAlcool.Maximum = 20;
            this.progressBarAlcool.Name = "progressBarAlcool";
            this.progressBarAlcool.Size = new System.Drawing.Size(196, 28);
            this.progressBarAlcool.TabIndex = 4;
            this.progressBarAlcool.Click += new System.EventHandler(this.progressBarAlcool_Click);
            // 
            // otherBarButton
            // 
            this.otherBarButton.Location = new System.Drawing.Point(819, 229);
            this.otherBarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otherBarButton.Name = "otherBarButton";
            this.otherBarButton.Size = new System.Drawing.Size(196, 28);
            this.otherBarButton.TabIndex = 5;
            this.otherBarButton.Text = "aller à l\'appart café";
            this.otherBarButton.UseVisualStyleBackColor = true;
            this.otherBarButton.Click += new System.EventHandler(this.otherBarButton_Click);
            // 
            // getMoneyButton
            // 
            this.getMoneyButton.Location = new System.Drawing.Point(819, 265);
            this.getMoneyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getMoneyButton.Name = "getMoneyButton";
            this.getMoneyButton.Size = new System.Drawing.Size(196, 28);
            this.getMoneyButton.TabIndex = 6;
            this.getMoneyButton.Text = "aller retirer de l\'argent";
            this.getMoneyButton.UseVisualStyleBackColor = true;
            this.getMoneyButton.Click += new System.EventHandler(this.getMoneyButton_Click);
            // 
            // enjoyProgressBar
            // 
            this.enjoyProgressBar.Location = new System.Drawing.Point(819, 468);
            this.enjoyProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enjoyProgressBar.Maximum = 30;
            this.enjoyProgressBar.Name = "enjoyProgressBar";
            this.enjoyProgressBar.Size = new System.Drawing.Size(196, 28);
            this.enjoyProgressBar.TabIndex = 7;
            // 
            // AlcoolText
            // 
            this.AlcoolText.Location = new System.Drawing.Point(819, 368);
            this.AlcoolText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlcoolText.Name = "AlcoolText";
            this.AlcoolText.Size = new System.Drawing.Size(195, 22);
            this.AlcoolText.TabIndex = 8;
            this.AlcoolText.TextChanged += new System.EventHandler(this.AlcoolText_TextChanged);
            // 
            // ArgentText
            // 
            this.ArgentText.Location = new System.Drawing.Point(819, 300);
            this.ArgentText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArgentText.Name = "ArgentText";
            this.ArgentText.Size = new System.Drawing.Size(195, 22);
            this.ArgentText.TabIndex = 9;
            this.ArgentText.TextChanged += new System.EventHandler(this.ArgentText_TextChanged);
            // 
            // heureTexte
            // 
            this.heureTexte.Location = new System.Drawing.Point(819, 512);
            this.heureTexte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heureTexte.Name = "heureTexte";
            this.heureTexte.Size = new System.Drawing.Size(195, 22);
            this.heureTexte.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOU WIN !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(915, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOU LOOSE !";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(819, 436);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // actualiser
            // 
            this.actualiser.Location = new System.Drawing.Point(919, 15);
            this.actualiser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actualiser.Name = "actualiser";
            this.actualiser.Size = new System.Drawing.Size(100, 28);
            this.actualiser.TabIndex = 12;
            this.actualiser.Text = "Actualiser";
            this.actualiser.UseVisualStyleBackColor = true;
            this.actualiser.Click += new System.EventHandler(this.actualiser_Click);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Cursor = System.Windows.Forms.Cursors.No;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(17, 512);
            this.description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(793, 21);
            this.description.TabIndex = 13;
            this.description.Text = "C\'est mercredi! Va au zytho !";
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 555);
            this.Controls.Add(this.description);
            this.Controls.Add(this.actualiser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heureTexte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarArgent);
            this.Controls.Add(this.progressBarAlcool);
            this.Controls.Add(this.ArgentText);
            this.Controls.Add(this.AlcoolText);
            this.Controls.Add(this.enjoyProgressBar);
            this.Controls.Add(this.getMoneyButton);
            this.Controls.Add(this.otherBarButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.enterNewGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterNewGame;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ProgressBar progressBarArgent;
        private System.Windows.Forms.ProgressBar progressBarAlcool;
        private System.Windows.Forms.Button otherBarButton;
        private System.Windows.Forms.Button getMoneyButton;
        private System.Windows.Forms.ProgressBar enjoyProgressBar;
        private System.Windows.Forms.TextBox AlcoolText;
        private System.Windows.Forms.TextBox ArgentText;
        public System.Windows.Forms.TextBox heureTexte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button actualiser;
        private System.Windows.Forms.TextBox description;
    }
}

