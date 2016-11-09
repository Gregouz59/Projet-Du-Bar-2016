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
            this.getMoneyButton = new System.Windows.Forms.Button();
            this.sexAppealBar = new System.Windows.Forms.ProgressBar();
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
            this.progressBarArgent.Location = new System.Drawing.Point(614, 358);
            this.progressBarArgent.Name = "progressBarArgent";
            this.progressBarArgent.Size = new System.Drawing.Size(147, 23);
            this.progressBarArgent.TabIndex = 3;
            // 
            // progressBarAlcool
            // 
            this.progressBarAlcool.Location = new System.Drawing.Point(614, 329);
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
            this.otherBarButton.Text = "aller à l\'appart café";
            this.otherBarButton.UseVisualStyleBackColor = true;
            this.otherBarButton.Click += new System.EventHandler(this.otherBarButton_Click);
            // 
            // getMoneyButton
            // 
            this.getMoneyButton.Location = new System.Drawing.Point(614, 254);
            this.getMoneyButton.Name = "getMoneyButton";
            this.getMoneyButton.Size = new System.Drawing.Size(147, 23);
            this.getMoneyButton.TabIndex = 6;
            this.getMoneyButton.Text = "aller retirer de l\'argent";
            this.getMoneyButton.UseVisualStyleBackColor = true;
            this.getMoneyButton.Click += new System.EventHandler(this.getMoneyButton_Click);
            // 
            // sexAppealBar
            // 
            this.sexAppealBar.Location = new System.Drawing.Point(614, 387);
            this.sexAppealBar.Name = "sexAppealBar";
            this.sexAppealBar.Size = new System.Drawing.Size(147, 23);
            this.sexAppealBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 451);
            this.Controls.Add(this.sexAppealBar);
            this.Controls.Add(this.getMoneyButton);
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
        private System.Windows.Forms.Button getMoneyButton;
        private System.Windows.Forms.ProgressBar sexAppealBar;
    }
}

