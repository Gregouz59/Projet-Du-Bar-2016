using System;
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

            hideAllPictures();
            biereZytho.Show();
            Form1.alcool +=  2;
            Form1.enjoy += 3;
            Form1.argent -= 5;
            Form1.heure += Form1.vingtMin;
            isBeer = true;
            drinkBeer1.Hide();
            drinkBeerRinceCochon.Hide();
            drinkCocaButton.Hide();
            displayButton();
            description.Text = "BIERE !";
            barmanButton.Show();
            



        }


        //barmanButton
        private void button6_Click(object sender, EventArgs e)
        {
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
            Form1.heure += Form1.cinqMin;
            drinkBeer1.Hide();
            drinkBeerRinceCochon.Hide();
            drinkCocaButton.Hide();
            hideAllPictures();
            cocaZytho.Show();
            displayButton();
            barmanButton.Show();
            description.Text = "Peite caisse!";
        }

        public void hideButton()
        {
            danse.Hide();
            conso.Hide();
            table.Hide();
        }

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
            //Form1.heure = Form1.heure + Form1.quinzeMin;
            Form1.alcool -= 1;
            drinkBeer1.Hide();
            drinkBeerRinceCochon.Hide();
            drinkCocaButton.Hide();
            hideAllPictures();
            saucissonZytho.Show();
            displayButton();
            description.Text = "Hmmm!! Il est bon mon saucisson..";
            barmanButton.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            tableZytho.Show();
            if (isBeer)
            {
                Form1.enjoy += 3;
                description.Text = "Tu kiff à ta table, avec ta bière !";
            }
            else
            {
                Form1.enjoy -= 5;
                description.Text = "Se poser sans bière, VA AU BAR !";
            }

            isBeer = false;
            Form1.heure += Form1.dixMin;

    }

        private void button2_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            graterZytho.Show();
            //Demander de l'argent
            int gratteConso = Form1._r.Next(5);
            if (gratteConso == 1)
            {
                Form1.alcool += 2;
                Form1.enjoy += 3;
                description.Text = "Bien joué, t'as graté une bière !";
            }
            else
            {
                description.Text = "Dommage mais tes potes sont à sec !";
            }

            //Temps perdu a gratter
            Form1.heure += Form1.cinqMin;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            dansePicZytho.Show();
            Form1.enjoy += 3;
            description.Text = "T'enflammes le dance floor !";
            Form1.heure += Form1.quinzeMin;
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
