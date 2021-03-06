﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDuBar
{
    public partial class barModule1 : UserControl 
    {

        bool isBeer = false;
        private static barModule1 _instance;


        public static barModule1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new barModule1();
                return _instance;
            }
        }

        //ne pas afficher les images et cacher les 3 boutons de consommations
        public barModule1()
        {
            InitializeComponent();
            hideAllPictures();
            drinkBeer1.Hide();
            drinkCocaButton.Hide();
            drinkBeerRinceCochon.Hide();
        }

        public void drinkBeer1_Click(object sender, EventArgs e)
        {
            //boire une bière
            hideAllPictures();
            biereZytho.Show();
            Form1.alcool +=  2;
            Form1.enjoy += 3;
            Form1.argent -= 2;
            Form1.heure += Form1.vingtMin;
            isBeer = true;
            drinkBeer1.Hide();
            drinkBeerRinceCochon.Hide();
            drinkCocaButton.Hide();
            displayButton();
            description.Text = "HUM !!! Une bonne Chimay";
            barmanButton.Show();
                        }


        //barmanButton
        private void button6_Click(object sender, EventArgs e)
        {
            Form1.heure += Form1.cinqMin;
            drinkBeer1.Show();
            drinkCocaButton.Show();
            drinkBeerRinceCochon.Show();
            hideAllPictures();
            barmanZytho.Show();
            hideButton();
            description.Text = "Que veux-tu commander? ";
            barmanButton.Hide(); //désolé j'ai changer le nom après coup, button6=barmanButton
        }

        private void drinkCocaButton_Click(object sender, EventArgs e)
        {
         //boire un coca
            Form1.argent -=  2;
            Form1.heure += Form1.dixMin;
            drinkBeer1.Hide();
            drinkBeerRinceCochon.Hide();
            drinkCocaButton.Hide();
            hideAllPictures();
            cocaZytho.Show();
            displayButton();
            barmanButton.Show();
            description.Text = "Un coca ? Peite caisse!";
        }

        //cacher les boutons lorsque l'on clique sur le barman
        public void hideButton()
        {
            danse.Hide();
            conso.Hide();
            table.Hide();
        }

        //puis remettre les boutons
        public void displayButton()
        {
            danse.Show();
            conso.Show();
            table.Show();
        }

        private void drinkBeerRinceCochon_Click(object sender, EventArgs e)
        {
            //prendre un saucisson
            Form1.argent -= 3;
            Form1.alcool -= 1;
            Form1.heure += Form1.quinzeMin;
            drinkBeer1.Hide();
            drinkBeerRinceCochon.Hide();
            drinkCocaButton.Hide();
            hideAllPictures();
            saucissonZytho.Show();
            displayButton();
            description.Text = "Et un saucisson pour la 6 un !!";
            barmanButton.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //se poser à une table
            hideAllPictures();
            tableZytho.Show();
            if (isBeer)
            {
                Form1.enjoy += 3;
                description.Text = "Une table, une bière, les copains c'est parfait";
            }
            else
            {
                Form1.enjoy -= 5;
                description.Text = "Se poser sans bière, quelle idée? VA AU BAR !";
            }

            isBeer = false;
            Form1.heure += Form1.quinzeMin;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            graterZytho.Show();
            //Demander de l'argent
            int gratteConso = Form1._r.Next(3);
            if (gratteConso == 1)
            {
                Form1.alcool += 2;
                Form1.enjoy += 3;
                description.Text = "Merci Romain !!!";
            }
            else
            {
                Form1.enjoy -= 2;
                description.Text = "Dommage mais tes potes sont à sec !";
            }

            //Temps perdu a gratter
            Form1.heure += Form1.cinqMin;
            
        }

        //aller danser
        private void button1_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            dansePicZytho.Show();
            Form1.enjoy += 3;
            description.Text = "T'enflammes le dance floor !";
            Form1.heure += Form1.vingtMin;
            Form1.alcool -= 1;
        }

        private void biereZytho_Click(object sender, EventArgs e)
        {

        }

        private void cocaZytho_Click(object sender, EventArgs e)
        {

        }

        public void hideAllPictures()
        {
            saucissonZytho.Hide();
            cocaZytho.Hide();
            barmanZytho.Hide();
            biereZytho.Hide();
            tableZytho.Hide();
            graterZytho.Hide();
            dansePicZytho.Hide();
        }
    }
}
