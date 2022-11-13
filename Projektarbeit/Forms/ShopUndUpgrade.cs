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
    public partial class ShopUndUpgrade : Form
    {
        int m_anzahl;
        KlasseKaffeWelt m_kaffewelt;
        public ShopUndUpgrade()
        {
            InitializeComponent();
            m_kaffewelt = new KlasseKaffeWelt();
        }

        private void Milchkaffe_Click(object sender, EventArgs e)
        {
            KlasseKaffeWelt m_kaffewelt = new KlasseKaffeWelt();
            m_anzahl= m_kaffewelt.Kaufen(sender);

            if (m_anzahl > 0)
            lbl_anzahlMilchkaffee.Text = m_anzahl.ToString();
        }

        private void Cappuccino_Click(object sender, EventArgs e)
        {
            KlasseKaffeWelt m_kaffewelt = new KlasseKaffeWelt();
            m_anzahl = m_kaffewelt.Kaufen(sender);

            if (m_anzahl > 0)
                lbl_Cappu.Text = m_anzahl.ToString();
        }

        private void Latte_Click(object sender, EventArgs e)
        {
            KlasseKaffeWelt m_kaffewelt = new KlasseKaffeWelt();
            m_anzahl = m_kaffewelt.Kaufen(sender);

            if (m_anzahl > 0)
                lbl_latte.Text = m_anzahl.ToString();
        }

        private void Espresso_Click(object sender, EventArgs e)
        {
            KlasseKaffeWelt m_kaffewelt = new KlasseKaffeWelt();
            m_anzahl = m_kaffewelt.Kaufen(sender);

            if (m_anzahl > 0)
                lbl_espresso.Text = m_anzahl.ToString();
        }
    }
}
