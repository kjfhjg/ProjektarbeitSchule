﻿using System;
using System.Windows.Forms;

namespace Projektarbeit
{
    public delegate void delRefresh();
    public partial class Clicker : Form
    {

        public static decimal m_HauptCount { get; set; } = (decimal)0.1;
        public static double m_PunkteGesamt { get; set; } = 100000000;

        public Hauptmenü creator;

        KlasseKaffeWelt m_AuswahlWelt;

        decimal m_zwischenPunkte;
        ShopUndUpgrade Kaufladen;

        public Clicker(KlasseKaffeWelt auswahl)
        {
            InitializeComponent();
            AusgabePunkte();
            Kaufladen = new ShopUndUpgrade(auswahl);
            Kaufladen.m_refresh += AusgabePunkte;
            m_AuswahlWelt = auswahl;
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
            lbl_TalerGesamt.Text = $"{m_PunkteGesamt:0}";
            lbl_TalerPerClick.Text = m_HauptCount.ToString();
        }
        #region Click Funktionen
        private void Hauptklicker_Click(object sender, EventArgs e)
        {
            m_zwischenPunkte += m_HauptCount;
            Runden();
            AusgabePunkte();
        }
        private void btn_Laden_Click(object sender, EventArgs e)
        {
            Kaufladen.ShowDialog();
        }

        private void Clicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                Kaufladen.ShowDialog();
            }
        }
        #endregion

        private void Clicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_AuswahlWelt.Save();
            creator.Show();
        }
    }
}
