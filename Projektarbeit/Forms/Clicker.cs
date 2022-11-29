using System;
using System.Windows.Forms;

namespace Projektarbeit
{
    public delegate void delRefresh();
    public partial class Clicker : Form
    {
        
        //Initialisieren und Deklarieren.
        public static decimal m_HauptCount { get; set; } = (decimal)0.1;
        public static double m_PunkteGesamt { get; set; } = 100000000;
        
        public Hauptmenü creator;

        KlasseKaffeWelt m_AuswahlWelt;

        decimal m_zwischenPunkte;
        ShopUndUpgrade Kaufladen;

        int timer = 0;
        

        public Clicker(KlasseKaffeWelt auswahl)
        {
            InitializeComponent();
            AusgabePunkte();
            Kaufladen = new ShopUndUpgrade(auswahl);
            Kaufladen.m_refresh += AusgabePunkte;
            m_AuswahlWelt = auswahl;
        }
        //Rundet die Zahlen
        public void Runden()
        {
            if (m_zwischenPunkte >= 1)
            {
                m_PunkteGesamt += (double)m_zwischenPunkte;
                m_zwischenPunkte = 0;
            }
        }
        //Gibt die Punkte aus
        public void AusgabePunkte()
        {
            lbl_TalerGesamt.Text = $"{m_PunkteGesamt:0}";
            lbl_TalerPerClick.Text = m_HauptCount.ToString();
        }
        #region Click Funktionen
        //Beim Click auf den CLickbutton erhöhen sich die Punkte um den Clickwert.
        private void Hauptklicker_Click(object sender, EventArgs e)
        {
            m_zwischenPunkte += m_HauptCount;
            Runden();
            AusgabePunkte();
        }
        //Öffnet den Kaufladen
        private void btn_Laden_Click(object sender, EventArgs e)
        {
            Kaufladen.ShowDialog();
        }
        //Öffnet den Shop indem man I drückt
        private void Clicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                Kaufladen.ShowDialog();
            }
        }
        #endregion
        //führt den Hauptclicker aus wenn der tickt
        private void tmr_autoclicker_Tick(object sender, EventArgs e)
        {
           Hauptklicker_Click(sender, e);
        }
        //Speichert das Programm beim schließen
        private void Clicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_AuswahlWelt.Save();
            creator.Show();
        }
    }
}
