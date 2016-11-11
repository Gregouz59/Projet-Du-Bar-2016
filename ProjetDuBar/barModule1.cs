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
           
            Form1.alcool = Form1.alcool + 2;
            Form1.argent = Form1.argent - 5;

           // form.actualiserLesVariables(form.heure, Form1.argent, Form1.alcool);

        }


        //barmanButton
        private void button6_Click(object sender, EventArgs e)
        {
            drinkBeer1.Show();
            drinkCocaButton.Show();
            drinkBeerRinceCochon.Show();
            barmanButton.Hide(); //désolé j'ai changer le nom après coup, button6=barmanButton
        }

        private void drinkCocaButton_Click(object sender, EventArgs e)
        {
            
        }

        private void drinkBeerRinceCochon_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
