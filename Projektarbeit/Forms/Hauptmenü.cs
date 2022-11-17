using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbeit
{
    public partial class Hauptmenü : Form
    {
        public Hauptmenü()
        {
            InitializeComponent();
        }

        #region Hauptmenü Kontrolle
        //Setzt sämtliche Controls auf unsichtbar
        public void zeigeHauptmenü()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = true;
            }
        }

        private void versteckeHauptmenü()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = false;
            }
        }

        private void Hauptmenü_Load(object sender, EventArgs e)
        { 
            if (!Directory.Exists("Save")) Directory.CreateDirectory("Save");
            if (!File.Exists("Save\\KaffeWelt.txt")) File.Create("Save\\KaffeWelt.txt");
        }
        #endregion

        #region Click Funktionen
        //Schließt das gesamte Programm
        private void btn_Verlassen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Versteckt Controls und Ruft das UserSteuerelement neues Spiel auf dieses wird angezeigt und füllt die gesamte Form aus
        private void btn_NeuesSpiel_Click(object sender, EventArgs e)
        {
            versteckeHauptmenü();
            uc_NeuesSpiel uc_neuesSpiel = new uc_NeuesSpiel(this);
            uc_neuesSpiel.Dock = DockStyle.Fill;
            this.Controls.Add(uc_neuesSpiel);
        }
        //Versteckt Controls und Ruft das UserSteuerelement Spiel laden auf dieses wird angezeigt und füllt die gesamte Form aus
        private void btn_SpielLaden_Click(object sender, EventArgs e)
        {
            versteckeHauptmenü();
            uc_SpielLaden uc_spielLaden = new uc_SpielLaden();
            uc_spielLaden.Dock = DockStyle.Fill;
            this.Controls.Add(uc_spielLaden);
        }
        //Versteckt Controls und Ruft das UserSteuerelement Einstellungen auf dieses wird angezeigt und füllt die gesamte Form aus
        private void btn_Einstellungen_Click(object sender, EventArgs e)
        {
            versteckeHauptmenü();
            uc_Einstellungen uc_einstellungen = new uc_Einstellungen();
            uc_einstellungen.Dock= DockStyle.Fill;
            this.Controls.Add(uc_einstellungen);
        }
        #endregion
    }
}
