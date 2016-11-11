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
        }

        private void barModuleAppartCafe_Load(object sender, EventArgs e)
        {

        }
    }
}
