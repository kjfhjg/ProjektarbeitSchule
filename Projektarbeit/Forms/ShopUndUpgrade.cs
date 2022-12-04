using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbeit
{
    public partial class ShopUndUpgrade : Form
    {
        public event delRefresh m_refresh;
        KlasseKaffeWelt m_kaffewelt;
        public ShopUndUpgrade(KlasseKaffeWelt p_kaffewelt)
        {
            InitializeComponent();
            m_kaffewelt = p_kaffewelt;
            setBeensBitmap();
            setBeensKosten();
        }
        public void soundplayer()
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.ResourceManager.GetStream("click");
            player.Play();
        }
        #region Methoden
        public void Refresh()
        {
            if (m_refresh != null)
            {
                m_refresh();
            }
        }
        //Die Bitmaps(Bilder) werden entsprechend aus den Ressourcen bezogen und eingefügt.
        private void setBeensBitmap()
        {
            Milchkaffe.BackgroundImage = m_kaffewelt.getAnzahlBeens(0);
            Cappuccino.BackgroundImage = m_kaffewelt.getAnzahlBeens(1);
            Latte.BackgroundImage = m_kaffewelt.getAnzahlBeens(2);
            Espresso.BackgroundImage = m_kaffewelt.getAnzahlBeens(3);
        }
        //Die Kosten werden Passend in die Labels eingefügt und angezeigt.
        private void setBeensKosten()
        {
            lbl_MilchkaffeKosten.Text = $"{m_kaffewelt.getBeensKosten(0):0}";
            lbl_CappuccinoKosten.Text = $"{m_kaffewelt.getBeensKosten(1):0}";
            lbl_LatteKosten.Text = $"{m_kaffewelt.getBeensKosten(2):0}";
            lbl_EspressoKosten.Text = $"{m_kaffewelt.getBeensKosten(3):0}";
        }
        #endregion 
        #region Events
        private void Click(object sender, EventArgs e)
        {
            soundplayer();
            int tmp_anzahl;
            string tmp_name;

            tmp_anzahl = m_kaffewelt.Kaufen(sender);

            if (tmp_anzahl != 0)
            {
                tmp_name = KlasseKaffeWelt.BekommeControleName(sender);
                tmp_name = "lbl_" + tmp_name;
                //Suche nach Control mit tmp_name, cast dieses in Label Array , nehme erstes Array Element und weise Text zu!     
                ((TextBox)this.Controls.Find(tmp_name, true)[0]).Text = tmp_anzahl.ToString();
            }
            Refresh();
            setBeensBitmap();
            setBeensKosten();
        }
        private void ShopUndUpgrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
