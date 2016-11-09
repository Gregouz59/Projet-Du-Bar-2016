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
            this.tempsPasser = new System.Windows.Forms.ProgressBar();
            this.progressBarArgent = new System.Windows.Forms.ProgressBar();
            this.progressBarAlcool = new System.Windows.Forms.ProgressBar();
            this.otherBarButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterNewGame
            // 
            this.enterNewGame.Location = new System.Drawing.Point(614, 104);
            this.enterNewGame.Name = "enterNewGame";
            this.enterNewGame.Size = new System.Drawing.Size(147, 23);
            this.enterNewGame.TabIndex = 0;
            this.enterNewGame.Text = "New Game";
            this.enterNewGame.UseVisualStyleBackColor = true;
            this.enterNewGame.Click += new System.EventHandler(this.enterNewGame_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(595, 426);
            this.panel.TabIndex = 1;
            // 
            // tempsPasser
            // 
            this.tempsPasser.Location = new System.Drawing.Point(614, 416);
            this.tempsPasser.Name = "tempsPasser";
            this.tempsPasser.Size = new System.Drawing.Size(147, 23);
            this.tempsPasser.TabIndex = 2;
            // 
            // progressBarArgent
            // 
            this.progressBarArgent.Location = new System.Drawing.Point(614, 387);
            this.progressBarArgent.Name = "progressBarArgent";
            this.progressBarArgent.Size = new System.Drawing.Size(147, 23);
            this.progressBarArgent.TabIndex = 3;
            // 
            // progressBarAlcool
            // 
            this.progressBarAlcool.Location = new System.Drawing.Point(614, 358);
            this.progressBarAlcool.Name = "progressBarAlcool";
            this.progressBarAlcool.Size = new System.Drawing.Size(147, 23);
            this.progressBarAlcool.TabIndex = 4;
            // 
            // otherBarButton
            // 
            this.otherBarButton.Location = new System.Drawing.Point(614, 225);
            this.otherBarButton.Name = "otherBarButton";
            this.otherBarButton.Size = new System.Drawing.Size(147, 23);
            this.otherBarButton.TabIndex = 5;
            this.otherBarButton.Text = "aller à un autre bar";
            this.otherBarButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "boire une biére rince cochon";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.otherBarButton);
            this.Controls.Add(this.progressBarAlcool);
            this.Controls.Add(this.progressBarArgent);
            this.Controls.Add(this.tempsPasser);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.enterNewGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterNewGame;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ProgressBar tempsPasser;
        private System.Windows.Forms.ProgressBar progressBarArgent;
        private System.Windows.Forms.ProgressBar progressBarAlcool;
        private System.Windows.Forms.Button otherBarButton;
        private System.Windows.Forms.Button button2;
    }
}

