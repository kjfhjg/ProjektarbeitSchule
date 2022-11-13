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
            string tmp_name;

            tmp_anzahl = m_kaffewelt.Kaufen(sender);

            if (tmp_anzahl != 0)
            {
                tmp_name = KlasseKaffeWelt.BekommeControleName(sender);
                tmp_name = "lbl_" + tmp_name;
                //Suche nach Control mit tmp_name, cast dieses in Label Array , nehme erstes Array Element und weise Text zu!     
                ((Label)this.Controls.Find(tmp_name, true)[0]).Text = tmp_anzahl.ToString();
            }
            Refresh();
        }
    }
}
