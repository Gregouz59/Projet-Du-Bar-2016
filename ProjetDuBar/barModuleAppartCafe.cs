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
    public partial class barModuleAppartCafe : UserControl
    {

        bool isBeer = false;
        private static barModuleAppartCafe _instance;


        public static barModuleAppartCafe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new barModuleAppartCafe();
                return _instance;
            }
        }

        public barModuleAppartCafe()
        {
            InitializeComponent();
            hideAllPictures();
        }

        private void barModuleAppartCafe_Load(object sender, EventArgs e)
        {

        }

        //bouton barman
        private void barmanButton_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            drinkBeer1.Show();
            drinkCocaButton.Show();
            Jagger.Show();
            barmanAppart.Show();
            hideButton();
            description.Text = "Que veux-tu commander? ";
            barmanButton.Hide(); //désolé j'ai changer le nom après coup, button6=barmanButton
        }
    
        //cacher les boutons suivant si on clqiue sur le barman
        public void hideButton()
        {
            danse.Hide();
            conso.Hide();
            table.Hide();
            chiner.Hide();
        }

        //les afficher
        public void displayButton()
        {
            danse.Show();
            conso.Show();
            table.Show();
            chiner.Show();
        }

        //cacher l'ensemble des photos
        public void hideAllPictures()
        {
            cocaAppart.Hide();
            Jagger.Hide();
            drinkBeer1.Hide();
            jaggerPicture.Hide();
            drinkCocaButton.Hide();
            barmanAppart.Hide();
            biereAppart.Hide();
            tableAppart.Hide();
            gratterAppart.Hide();
            danseAppart.Hide();
            chinerMoche.Hide();
            chinerRiche.Hide();
            
        }

        //aler danser
        private void danse_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            danseAppart.Show();
            Form1.enjoy += 3;
            Form1.alcool -= 1;
            description.Text = "Attention ca va partir en danse du limousin...";
            Form1.heure += Form1.quinzeMin;
        }

        //aller se poser a une table
        private void table_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            tableAppart.Show();
            if (isBeer)
            {
                Form1.enjoy += 3;
                description.Text = "Il ne te manque plus qu'une fille et ta vie sera parfaite :)";
            }
            else
            {
                Form1.enjoy -= 5;
                description.Text = "Se poser sans bière, VA AU BAR !";
            }

            isBeer = false;
            Form1.heure += Form1.dixMin;
        }

        //gratter de l'argent
        private void conso_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            gratterAppart.Show();
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

        //boire une biere
        private void drinkBeer1_Click_1(object sender, EventArgs e)
        {
            hideAllPictures();
            biereAppart.Show();
            Form1.alcool += 2;
            Form1.enjoy += 3;
            Form1.argent -= 5;
            Form1.heure += Form1.vingtMin;
            isBeer = true;
            drinkBeer1.Hide();
            drinkCocaButton.Hide();
            displayButton();
            description.Text = "Une bière David s'il te plait !";
            barmanButton.Show();
        }

        private void drinkCocaButton_Click_1(object sender, EventArgs e)
        {
            //boire un coca
            Form1.argent -= 2;
            Form1.heure += Form1.cinqMin;
            drinkBeer1.Hide();
            drinkCocaButton.Hide();
            hideAllPictures();
            cocaAppart.Show();
            displayButton();
            barmanButton.Show();
            description.Text = "Peite caisse!";
         }


        private void Jagger_Click(object sender, EventArgs e)
        {
            //boire un jagger
            Form1.argent -= 5;
            Form1.heure += Form1.unMin;
            Form1.alcool += 3;
            Form1.enjoy += 4;
            drinkBeer1.Hide();
            drinkCocaButton.Hide();
            hideAllPictures();
            jaggerPicture.Show();
            displayButton();
            barmanButton.Show();
            Jagger.Hide();
            description.Text = "Ca attaque fort !!!";
        }


        //aller draguer
        private void chiner_Click(object sender, EventArgs e)
        {
            hideAllPictures();
            if (Form1.argent > 30)
            {
                chinerRiche.Show();
                description.Text = "Mais dis moi, c'est un porte-monnaie bien remplis!";
                Form1.argent -= 15;
                Form1.heure += Form1.quinzeMin;
                Form1.alcool += 5;
                Form1.enjoy += 10;
            }
            else {
                chinerMoche.Show();
                description.Text = "tu t'attendais à qui? T'as pas de tune...";
                Form1.heure += Form1.quinzeMin;
                Form1.alcool += 4;
                Form1.argent -= 5;
                Form1.enjoy -= 5 ;
            }
        }

    }


}
