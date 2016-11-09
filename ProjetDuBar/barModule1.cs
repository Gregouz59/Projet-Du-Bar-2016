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
        }

        private void drinkBeer1_Click(object sender, EventArgs e)
        {

        }
    }
}
