using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbeit
{
    public partial class uc_NeuesSpiel : UserControl
    {
        Hauptmenü m_hauptmenü;
        int m_auswahl;
        public uc_NeuesSpiel(Hauptmenü hauptmenü)
        {
            m_hauptmenü = hauptmenü;
            InitializeComponent();
        }

        private void btn_Zurück_Click(object sender, EventArgs e)
        {
            m_hauptmenü.zeigeHauptmenü();
            this.Dispose();
        }

        private void pb_Kaffe_Click(object sender, EventArgs e)
        {
            m_auswahl = 0;
            panelKaffe.BackColor = Color.Brown;
        }
        public void btn_Starten_Click(object sender, EventArgs e)
        {
            KlasseKaffeWelt klasseKaffeWelt = new KlasseKaffeWelt(m_auswahl);
            Clicker clicker = new Clicker(klasseKaffeWelt);
            Parent.Hide();
            clicker.Show();
        }
    }
}
