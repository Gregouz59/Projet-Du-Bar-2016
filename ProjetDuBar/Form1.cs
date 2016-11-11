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
        public static int argent;
        public static int alcool;
        public static int enjoy;
        public static Form1 thisForm ;
        public static TimeSpan heure = new TimeSpan(17, 30, 0);
        public static TimeSpan timeToGo = new TimeSpan(19, 30, 0);
        public static TimeSpan cinqMin = TimeSpan.FromMinutes(5);
        public static TimeSpan quinzeMin = TimeSpan.FromMinutes(15);
        public static TimeSpan vingtMin = TimeSpan.FromMinutes(20);
        public static TimeSpan dixMin = TimeSpan.FromMinutes(10);
        public static TimeSpan vingtCinqMin = TimeSpan.FromMinutes(25);



        public static Random _r = new Random();

        public Form1()
        {
            
            InitializeComponent();
            this.Text = "BAR";
            
            argent = 20;
            alcool = 1;
            enjoy = 10;
            actualiserLesVariables(heure, argent, alcool);
            otherBarButton.Hide();
            getMoneyButton.Hide();
            progressBarAlcool.Hide();
            progressBarArgent.Hide();
            enjoyProgressBar.Hide();
            label1.Hide();
            label2.Hide();
            ArgentText.Hide();
            actualiser.Hide();
            AlcoolText.Hide();
            textBox1.Hide();
        }

        public void actualiserLesVariables(TimeSpan h, int ar, int al)
        {
            
            heureTexte.Text = "Heure:  " + h;
            ArgentText.Text = "Argent: " + ar;
            AlcoolText.Text = "Alcool: " + al;
            textBox1.Text = "Enjaille: " + enjoy;
 
            if(ar <= 0)
            {
                label2.Show();
            }
            else
            {
                progressBarArgent.Value = ar;
            }

            if (al <= 0)
            {
                label2.Show();
            }
            else
            {
                progressBarAlcool.Value = al;
            }
            if (enjoy <= 0)
            {
                label2.Show();
            }
            else
            {
                enjoyProgressBar.Value = enjoy;
            }


        }



        private void enterNewGame_Click(object sender, EventArgs e)
        {
            //quand on click sur new game on fait apparaitre le premier barModule1 et disparaitre le boutton "new game"
            if (!panel.Controls.Contains(barModule1.Instance))
            {
                panel.Controls.Add(barModule1.Instance);
                barModule1.Instance.Dock = DockStyle.Fill;
                barModule1.Instance.BringToFront();
                Form1 thisForm = this;
                description.Text = "Bienvenue au Zyhto, que veux-tu faire?";
                enterNewGame.Hide();
                getMoneyButton.Show();
                progressBarAlcool.Show();
                progressBarArgent.Show();
                enjoyProgressBar.Show();
                ArgentText.Show();
                AlcoolText.Show();
                actualiser.Show();
                textBox1.Show();
            }
            else
                barModule1.Instance.BringToFront();

        }

        private void getMoneyButton_Click(object sender, EventArgs e)
        {
            argent = argent + 10;
            enjoy = enjoy - 1;
            heure = heure + vingtMin;
            description.Text = "Tu viens d'aller retirer 10e ! ";
            checkTime();
            actualiserLesVariables(heure, argent, alcool);
        }

        //clique pour aller à l'appart café
        private void otherBarButton_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(barModuleAppartCafe.Instance))
            {
                panel.Controls.Add(barModuleAppartCafe.Instance);
                barModuleAppartCafe.Instance.Dock = DockStyle.Fill;
                barModuleAppartCafe.Instance.BringToFront();
                description.Text = "Bienvenue à l'appart , que veux-tu faire?";
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
            
        }

        private void AlcoolText_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualiser_Click(object sender, EventArgs e)
        {
            actualiserLesVariables(heure, argent, alcool);
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        public void checkTime()
        {
            if(heure >= timeToGo)
            {
                object sender = null;
                EventArgs e = null;
                description.Text = "19h30 , ON FERME ! ";
                otherBarButton_Click(sender, e);

            }
        }
    }
}
