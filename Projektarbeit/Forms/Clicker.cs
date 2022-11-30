using System;
using System.Windows.Forms;

namespace Projektarbeit
{
    public delegate void delRefresh();
    public partial class Clicker : Form
    {
        
        //Initialisieren und Deklarieren.
        public static decimal m_hauptCount { get; set; } = (decimal)0.1;
        public static double m_punkteGesamt { get; set; } = 100000000;  
        public Hauptmenü m_creator;

        KlasseKaffeWelt m_auswahlWelt;
        ShopUndUpgrade m_kaufladen;
        decimal m_zwischenPunkte;
        public Clicker(KlasseKaffeWelt p_auswahl)
        {
            InitializeComponent();
            AusgabePunkte();
            m_kaufladen = new ShopUndUpgrade(p_auswahl);
            m_kaufladen.m_refresh += AusgabePunkte;
            m_auswahlWelt = p_auswahl;
        }
        #region Methoden
        //Rundet die Zahlen
        public void Runden()
        {
            if (m_zwischenPunkte >= 1)
            {
                m_punkteGesamt += (double)m_zwischenPunkte;
                m_zwischenPunkte = 0;
            }
        }
        //Gibt die Punkte aus
        public void AusgabePunkte()
        {
            lbl_TalerGesamt.Text = $"{m_punkteGesamt:0}";
            lbl_TalerPerClick.Text = m_hauptCount.ToString();
        }
        #endregion
        #region Events
        //Beim Click auf den CLickbutton erhöhen sich die Punkte um den Clickwert.
        private void Hauptklicker_Click(object sender, EventArgs e)
        {
            m_zwischenPunkte += m_hauptCount;
            Runden();
            AusgabePunkte();
        }
        //Öffnet den Kaufladen
        private void btn_Laden_Click(object sender, EventArgs e)
        {
            m_kaufladen.ShowDialog();
        }
        //Öffnet den Shop indem man I drückt
        private void Clicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                m_kaufladen.ShowDialog();
            }
        }
        //führt den Hauptclicker aus wenn der tickt
        private void tmr_autoclicker_Tick(object sender, EventArgs e)
        {
            Hauptklicker_Click(sender, e);
        }
        //Speichert das Programm beim schließen
        private void Clicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_auswahlWelt.Save();
            m_creator.Show();
        }
        #endregion
    }
}
