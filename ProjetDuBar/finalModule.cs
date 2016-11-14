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
    public partial class finalModule : UserControl
    {
        private static finalModule _instance;
        public static finalModule Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new finalModule();
                return _instance;
            }
        }
        public finalModule()
        {
            InitializeComponent();
            alcool.Text = "Alcool = : " + Form1.alcool + " / 15";
            argent.Text = "Argent = : " + Form1.argent;
            enjaille.Text = "Enjaille = " + Form1.enjoy + " / 40";

        }

        private void alcool_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}
