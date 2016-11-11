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
        Form1 form = new Form1();
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
            drinkBeer1.Hide();
            drinkCocaButton.Hide();
            drinkBeerRinceCochon.Hide();
        }

        public void drinkBeer1_Click(object sender, EventArgs e)
        {
           
            Form1.alcool +=  2;
            Form1.enjoy += 3;
            Form1.argent -= 5;
            Form1.heure += Form1.vingtMin;
            isBeer = true;
            drinkBeer1.Hide();
            drinkBeerRinceCochon.Hide();
            drinkCocaButton.Hide();
            displayButton();
            barmanButton.Show();

        }


        //barmanButton
        private void button6_Click(object sender, EventArgs e)
        {
            drinkBeer1.Show();
            drinkCocaButton.Show();
            drinkBeerRinceCochon.Show();
            hideButton();
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
            displayButton();
            barmanButton.Show();
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
            displayButton();
            barmanButton.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (isBeer)
            {
                Form1.enjoy += 3;
        }
            else
            {
                Form1.enjoy -= 5;
            }
            isBeer = false;
            Form1.heure += Form1.dixMin;

    }

        private void button2_Click(object sender, EventArgs e)
        {
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
            Form1.enjoy += 3;
            Form1.heure += Form1.quinzeMin;
        }
    }
}
