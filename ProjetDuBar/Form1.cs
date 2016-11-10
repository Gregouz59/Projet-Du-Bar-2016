using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDuBar
{
    public partial class Form1 : Form
    {
        int argent = 50;
        int alcool = 1;
        TimeSpan heure = new TimeSpan(2, 14, 0);
        TimeSpan cinqMin = TimeSpan.FromMinutes(5);
        TimeSpan vingtMin = TimeSpan.FromMinutes(20);
        TimeSpan dixMin = TimeSpan.FromMinutes(10);
        TimeSpan vingtCinqMin = TimeSpan.FromMinutes(25);

        static Random _r = new Random();

        public Form1()
        {
            
            InitializeComponent();
            this.Text = "BAR";
            actualiserLesVariables();
            otherBarButton.Hide();
            getMoneyButton.Hide();
            progressBarAlcool.Hide();
            progressBarArgent.Hide();
            enjoyProgressBar.Hide();
            ArgentText.Hide();
            AlcoolText.Hide();
        }

        private void actualiserLesVariables()
        {
            heureTexte.Text = "Heure:  " + heure;
            ArgentText.Text = "Argent: " + argent;
            AlcoolText.Text = "Alcool: " + alcool;
            progressBarArgent.Value = argent;
            progressBarAlcool.Value = alcool;
            enjoyProgressBar.Value = (argent * (alcool * 2)) / 3;
        }



        private void enterNewGame_Click(object sender, EventArgs e)
        {
            //quand on click sur new game on fait apparaitre le premier barModule1 et disparaitre le boutton "new game"
            if (!panel.Controls.Contains(barModule1.Instance))
            {
                panel.Controls.Add(barModule1.Instance);
                barModule1.Instance.Dock = DockStyle.Fill;
                barModule1.Instance.BringToFront();
                enterNewGame.Hide();
                otherBarButton.Show();
                getMoneyButton.Show();
                progressBarAlcool.Show();
                progressBarArgent.Show();
                enjoyProgressBar.Show();
                ArgentText.Show();
                AlcoolText.Show();
            }
            else
                barModule1.Instance.BringToFront();

        }

        private void getMoneyButton_Click(object sender, EventArgs e)
        {
            argent = argent + 10;
            heure = heure + vingtMin;
            actualiserLesVariables();
        }

        //clique pour aller à l'appart café
        private void otherBarButton_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(barModuleAppartCafe.Instance))
            {
                panel.Controls.Add(barModuleAppartCafe.Instance);
                barModuleAppartCafe.Instance.Dock = DockStyle.Fill;
                barModuleAppartCafe.Instance.BringToFront();
                enterNewGame.Hide();
                otherBarButton.Hide();
            }
            else
                barModuleAppartCafe.Instance.BringToFront();
        }

        private void progressBarAlcool_Click(object sender, EventArgs e)
        {
            progressBarAlcool.Maximum = 20;
        }

        private void progressBarArgent_Click(object sender, EventArgs e)
        {
            progressBarArgent.Maximum = 50;
        }

        private void ArgentText_TextChanged(object sender, EventArgs e)
        {
            actualiserLesVariables();
        }

        private void AlcoolText_TextChanged(object sender, EventArgs e)
        {
            actualiserLesVariables();
        }
    }
}
