﻿using System;
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

        //Creation des variables 
        public static int argent;
        public static int alcool;
        public static int enjoy;
        public static Form1 thisForm ;
        public static TimeSpan heure = new TimeSpan(17, 30, 0);
        public static TimeSpan timeToGo = new TimeSpan(19, 30, 0);
        public static TimeSpan endGame = new TimeSpan(22, 30, 0);
        public static TimeSpan cinqMin = TimeSpan.FromMinutes(5);
        public static TimeSpan quinzeMin = TimeSpan.FromMinutes(15);
        public static TimeSpan vingtMin = TimeSpan.FromMinutes(20);
        public static TimeSpan dixMin = TimeSpan.FromMinutes(10);
        public static TimeSpan vingtCinqMin = TimeSpan.FromMinutes(25);
        public static TimeSpan unMin = TimeSpan.FromMinutes(1);
        public static bool isAppart = false;
        public static Random _r = new Random();

        public Form1()
        {
            
            InitializeComponent();
            this.Text = "BAR";
            
            argent = 20;
            alcool = 1;
            enjoy = 10;
            hideForTheEnd();
        }

        //fonction qui actualise argent heure alcool et enjaille
        //fonction qui régit les conditions de fin du jeu
        public void actualiserLesVariables(TimeSpan h, int ar, int al)
        {
            description.Text = "Bienvenue au Zyhto, que veux-tu faire?";
            if (isAppart)
                description.Text = "Bienvenue à l'appartcafe";

            heureTexte.Text = "Heure:  " + h;
            ArgentText.Text = "Argent: " + ar;
            AlcoolText.Text = "Alcool: " + al;
            textBox1.Text = "Enjaille: " + enjoy;

            //Conditions sur l'argent, défaite si <=0
            if (ar <= 0)
            {
                progressBarArgent.Value = progressBarArgent.Minimum;
                if (!panel.Controls.Contains(finalModule.Instance))
                {
                    description.Text = "Rentre chez toi, t'es fauché !";
                    hideForTheEnd();
                    panel.Controls.Add(finalModule.Instance); 
                    finalModule.Instance.Dock = DockStyle.Fill;
                    finalModule.Instance.BringToFront();
                }
            }
            else {
                progressBarArgent.Value = ar;
            }

            //Condition sur l'alcool, défaite si max
            if (al <= 0) {
                progressBarAlcool.Value = progressBarAlcool.Minimum;
            }
            else if(al >= progressBarAlcool.Maximum){
                description.Text = "Rentre chez toi, t'es trop bourré pour ce soir...";
                hideForTheEnd();
                panel.Controls.Add(finalModule.Instance);
                finalModule.Instance.Dock = DockStyle.Fill;
                finalModule.Instance.BringToFront();
                progressBarAlcool.Value = progressBarAlcool.Maximum;
            }
              else  {
                progressBarAlcool.Value = al;
            }

            //Condition sur l'enjaille, victoire si max
            if (enjoy <= 0){
                description.Text = "Tu t'ai fais trop chier... rentre chez toi!";
                hideForTheEnd();
                panel.Controls.Add(finalModule.Instance);
                finalModule.Instance.Dock = DockStyle.Fill;
                finalModule.Instance.BringToFront();
            }
            else if(enjoy>= enjoyProgressBar.Maximum){
                description.Text = "Tu as passé une putain de soirée! BRAVO !";
                hideForTheEnd();
                panel.Controls.Add(finalModule.Instance);
                finalModule.Instance.Dock = DockStyle.Fill;
                finalModule.Instance.BringToFront();
                enjoyProgressBar.Value = enjoyProgressBar.Maximum;
            }
                else  {
                enjoyProgressBar.Value = enjoy;
                }
            
        }


        //bouton nouvelle partie
        private void enterNewGame_Click(object sender, EventArgs e)
        {
            //quand on click sur new game on fait apparaitre le premier barModule1 et disparaitre le boutton "new game"
            actualiserLesVariables(heure, argent, alcool);
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
        //fonction pour retirer de l'argent
        private void getMoneyButton_Click(object sender, EventArgs e)
        {
            checkTime();
            argent = argent + 10;
            enjoy = enjoy - 1;
            heure = heure + vingtMin;
            description.Text = "Tu viens d'aller retirer 10e ! ";
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
                description.Text = "T'as été virer du bar ISEN mon pote... direction l'appart café! ";
                enterNewGame.Hide();
                otherBarButton.Hide();
            }
            else
                barModuleAppartCafe.Instance.BringToFront();

            isAppart = true;
           
        }

        //progresse bar alcool
        private void progressBarAlcool_Click(object sender, EventArgs e)
        {
            progressBarAlcool.Maximum = 20;
        }
        //progresse bar argent
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualiser_Click(object sender, EventArgs e)
        {
            checkTime();
            actualiserLesVariables(heure, argent, alcool);

        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        //fonction qui permet de surveiller l'heure
        public void checkTime()
        {
            if(heure >= timeToGo && heure <= endGame)
            {
                object sender = null;
                EventArgs e = null;
                otherBarButton_Click(sender, e);

            } else if(heure >= endGame)
            {
                if (!panel.Controls.Contains(finalModule.Instance))
                {
                    description.Text = "Il se fait tard, rentre chez toi, sans meuf, sans cuite... vraiment moyen!";
                    hideForTheEnd();
                    panel.Controls.Add(finalModule.Instance);
                    finalModule.Instance.Dock = DockStyle.Fill;
                    finalModule.Instance.BringToFront();
                }
            }
        }

        //fonction créer pour le finalModule: permet de ne pas afficher un certain nombre de boutons
        public void hideForTheEnd()
        {
            otherBarButton.Hide();
            getMoneyButton.Hide();
            progressBarAlcool.Hide();
            progressBarArgent.Hide();
            enjoyProgressBar.Hide();
            ArgentText.Hide();
            actualiser.Hide();
            AlcoolText.Hide();
            textBox1.Hide();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   }
