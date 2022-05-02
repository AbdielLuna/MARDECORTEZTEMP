using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk
{
    public partial class MenuFicha : Form
    {
        public MenuFicha()
        {
            InitializeComponent();
        }

        private void MenuFicha_Load(object sender, EventArgs e)
        {
            lb_time.Text = (dtTmpct_datatime.Value).ToString();
        }

        private void btt_enviar_Click(object sender, EventArgs e)
        {
            Form bettascreen = new MenuEleccion();
            this.Hide();
            bettascreen.Show();
        }

        private void btt_Shrim_Click(object sender, EventArgs e)
        {
            Form bettafichashirim = new camaronlist();
            bettafichashirim.Show();
        }

        private void bttn_fish_Click(object sender, EventArgs e)
        {
            Form bettafichafish = new peceslist();
            bettafichafish.Show();
        }
    }
}
