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
        public Form1()
        {
            InitializeComponent();
            otherBarButton.Hide();
            getMoneyButton.Hide();
        }

        private void enterNewGame_Click(object sender, EventArgs e)
        {
            //quand on click sur new game on fait apparaitre le premier barModule1 et disparaitre le boutton "new game"
            if (!panel.Controls.Contains(barModule1.Instance))
            {
                panel.Controls.Add(barModule1.Instance);
                barModule1.Instance.Dock = DockStyle.Fill;
                barModule1.Instance.BringToFront();
                enterNewGame.Hide();
                otherBarButton.Show();
                getMoneyButton.Show();
            }
            else
                barModule1.Instance.BringToFront();

        }

        private void getMoneyButton_Click(object sender, EventArgs e)
        {

        }

        //clique pour aller à l'appart café
        private void otherBarButton_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(barModuleAppartCafe.Instance))
            {
                panel.Controls.Add(barModuleAppartCafe.Instance);
                barModuleAppartCafe.Instance.Dock = DockStyle.Fill;
                barModuleAppartCafe.Instance.BringToFront();
                enterNewGame.Hide();
                otherBarButton.Hide();
            }
            else
                barModuleAppartCafe.Instance.BringToFront();
        }
    }
}
