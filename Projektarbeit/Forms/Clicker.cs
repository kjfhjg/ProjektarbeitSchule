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
    public partial class Clicker : Form
    {

        decimal m_HauptCount = (decimal)0.1;
        double m_PunkteGesamt = 0;
        decimal m_zwischenPunkte;
        KlasseKaffeWelt x = new KlasseKaffeWelt();
        public Clicker()
        {
            InitializeComponent();
        }
        public void Runden()
        {
            if (m_zwischenPunkte >= 1)
            {
                m_PunkteGesamt += (double)m_zwischenPunkte;
                m_zwischenPunkte = 0;
            }
        }
        public void AusgabePunkte()
        {
            lbl_TalerGesamt.Text = m_PunkteGesamt.ToString();
            lbl_TalerPerSecond.Text = m_HauptCount.ToString();
        }
        #region ClickEvents
        private void Hauptklicker_Click(object sender, EventArgs e)
        {
            m_zwischenPunkte += m_HauptCount;
            Runden();
            AusgabePunkte();
        }
        #endregion
    }
}
