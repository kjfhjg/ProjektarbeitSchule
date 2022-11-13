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
        public event delRefresh m_refresh;
        KlasseKaffeWelt m_kaffewelt;
        public ShopUndUpgrade()
        {
            InitializeComponent();
            m_kaffewelt = new KlasseKaffeWelt();
        }
        public void Refresh()
        {
            if (m_refresh != null)
            {
                m_refresh();
            }
        }

        private void Click(object sender, EventArgs e)
        {
            int tmp_anzahl;
            string x;

            tmp_anzahl = m_kaffewelt.Kaufen(sender);

            if (tmp_anzahl != 0)
            {
                x = KlasseKaffeWelt.BekommeControleName(sender);
                x = "lbl_" + x;
                ((Label)this.Controls.Find(x, true)[0]).Text = tmp_anzahl.ToString();
            }
            Refresh();
        }
    }
}
