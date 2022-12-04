using System;
using System.IO;
using System.Windows.Forms;

namespace Projektarbeit
{
    public partial class Hauptmenü : Form
    {
        public Hauptmenü()
        {
            InitializeComponent();
        }

        #region Methoden
        //Setzt sämtliche Controls auf unsichtbar
        public void zeigeHauptmenü()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = true;
            }
        }

        private void Hauptmenü_Load(object sender, EventArgs e)
        { 
            if (!File.Exists("KaffeWelt.txt")) File.Create("KaffeWelt.txt").Dispose();
        }
        #endregion
        #region Events
        //Schließt das gesamte Programm
        private void btn_Verlassen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Versteckt Controls und Ruft das UserSteuerelement neues Spiel auf dieses wird angezeigt und füllt die gesamte Form aus
        private void btn_NeuesSpiel_Click(object sender, EventArgs e)
        {
            DialogResult tmp_dialogResult = MessageBox.Show("Neues Spiel erstellen?", "Neues Spiel" ,MessageBoxButtons.YesNo);

            if (tmp_dialogResult == DialogResult.Yes)
            {
                Clicker.m_hauptCount = (decimal)0.1;
                Clicker.m_punkteGesamt = 100000000;  
                if (File.Exists("Timer.txt")) File.Delete("Timer.txt");
                KlasseKaffeWelt tmp_klasseKaffeWelt = new KlasseKaffeWelt(0);
                Clicker tmp_clicker = new Clicker(tmp_klasseKaffeWelt);
                tmp_clicker.m_creator = this;
                this.Hide();
                tmp_clicker.Show();
                tmp_klasseKaffeWelt.m_clicker = tmp_clicker;
            }
        }
        //Versteckt Controls und Ruft das UserSteuerelement Spiel laden auf dieses wird angezeigt und füllt die gesamte Form aus
        private void btn_SpielLaden_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText("KaffeWelt.txt") == "")
            {
                MessageBox.Show("Es gibt keine vorhandenen Speicherdaten.");
                return;
            }

            DialogResult tmp_dialogResult = MessageBox.Show("Spiel laden?", "Spiel laden", MessageBoxButtons.YesNo);

            if (tmp_dialogResult == DialogResult.Yes)
            {
                KlasseKaffeWelt tmp_klasseKaffeWelt = new KlasseKaffeWelt(1);
                Clicker tmp_clicker = new Clicker(tmp_klasseKaffeWelt);
                tmp_clicker.m_creator = this;
                this.Hide();
                tmp_clicker.Show();
                tmp_klasseKaffeWelt.m_clicker = tmp_clicker;
                if (File.Exists("Timer.txt"))
                {
                    tmp_clicker.tmr_autoclicker.Interval = Convert.ToInt32(File.ReadAllText("Timer.txt"));
                    tmp_clicker.tmr_autoclicker.Start();
                }
            }
        }
        #endregion
    }
}
