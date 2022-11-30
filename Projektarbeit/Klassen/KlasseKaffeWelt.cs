using System;
using System.Resources;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace Projektarbeit
{
    public class KlasseKaffeWelt
    {
        public struct Verkaufsgut
        {
            public string m_name;
            public int m_anzahl;
            public int m_tassenGröße;
            public double m_kosten;
            public decimal m_count;
            public bool m_upgrade;
        }
        Verkaufsgut[] m_verkaufsgüter;
        public Clicker m_clicker;

        public KlasseKaffeWelt(int p_auswahl)
        {
            if (p_auswahl == 0)
            {
                NeuesSpiel(Properties.Resources.KaffeeArten);
            }
            else if (p_auswahl == 1)
            {

            }
            else if (p_auswahl == 2)
            {

            }

        }
        public void NeuesSpiel(string p_resources)
        {
            //Initialisieren und Deklarieren.
            string tmp_temp;
            int tmp_zaehler = 0;
            m_verkaufsgüter = new Verkaufsgut[4];

            tmp_temp = p_resources;
            string[] stringAufspalten = tmp_temp.Split('\n');

            // entferne alle umbruchzeichen aus jedem String.
            for (int i = 0; i < stringAufspalten.Length; i++)
                stringAufspalten[i] = stringAufspalten[i].Replace("\r", "");
            
            //erstellt ein Struct mit den Verkaufsgütern die man im Shop kaufen kann.
            for (int i = 0; i < m_verkaufsgüter.Length; i++)
            {
                m_verkaufsgüter[i].m_name = stringAufspalten[tmp_zaehler++];
                m_verkaufsgüter[i].m_anzahl = 0;
                m_verkaufsgüter[i].m_tassenGröße = 0;
                m_verkaufsgüter[i].m_kosten = Convert.ToInt32(stringAufspalten[tmp_zaehler++]);
                m_verkaufsgüter[i].m_count = Convert.ToDecimal(stringAufspalten[tmp_zaehler++]);
                m_verkaufsgüter[i].m_upgrade = false;
            }
        }
        //Die Methode bekommt das Verkaufsgut übergeben und vergleicht die Kosten mit den aktuellen Punkten.
        //Sind die Punkte genug für den Kauf dann wird die Anzahl des Verkaufsgut um 1, die Kosten und der Clickwert erhöht.
        public int Kaufen(object p_sender)
        {
            for (int i = 0; i < m_verkaufsgüter.Length; i++)
            {
                if (m_verkaufsgüter[i].m_name == BekommeControleName(p_sender))
                {
                    if (Clicker.m_punkteGesamt >= m_verkaufsgüter[i].m_kosten)
                    {
                        Clicker.m_punkteGesamt -= m_verkaufsgüter[i].m_kosten;
                        m_verkaufsgüter[i].m_anzahl += 1;
                        m_verkaufsgüter[i].m_kosten = m_verkaufsgüter[i].m_kosten * 1.1;
                        Clicker.m_hauptCount += m_verkaufsgüter[i].m_count;

                        //Bei jedem Kauf eines Verkaufsgut wird nachgefragt ob sich etwas an der Autoclickgeschwindigkeit verändert.
                        AnzahlUpgradeMeilensteine(m_verkaufsgüter[i].m_anzahl);

                        return m_verkaufsgüter[i].m_anzahl;
                    }
                }
            }
            return 0;
        }
        public static string BekommeControleName(object p_sender)
        {
            try
            {
                PictureBox tmp_Controle = (PictureBox)p_sender;
                string tmp_ControleName = tmp_Controle.Name;

                return tmp_ControleName;
            }
            catch
            {
                return "";
            }
        }
        //Die Methode bekommt die Position der Verkaufsgüter übergeben und sucht anhand dieser das Passende Objekt und dessen Anzahl.
        //Die Anzahl wird abgeglichen und es wird dann die Passende Bitmap zurückgegeben.
        public Bitmap getAnzahlBeens(int p_position)
        {
            if (m_verkaufsgüter[p_position].m_anzahl < 50)
            {
                return Properties.Resources.BohneBronze;
            }
            else if (m_verkaufsgüter[p_position].m_anzahl >= 50 && m_verkaufsgüter[p_position].m_anzahl < 150)
            {
                return Properties.Resources.BohneSilber;
            }
            else if (m_verkaufsgüter[p_position].m_anzahl >= 150 && m_verkaufsgüter[p_position].m_anzahl < 300)
            {
                return Properties.Resources.BohneGold;
            }
            else if (m_verkaufsgüter[p_position].m_anzahl >= 350)
            {
                return Properties.Resources.BohneDiamand;
            }

            return Properties.Resources.BohneBronze;
        }
        //Die Methode bekommt die Position der Verkaufsgüter übergeben und sucht anhand dieser das Passende Objekt und dessen Kosten.
        //Die Kosten werden als integer zurückgegeben.
        public double getBeensKosten(int p_position)
        {
            return m_verkaufsgüter[p_position].m_kosten;
        }

        public void Save()
        {
            File.WriteAllText("Save\\KaffeWelt.txt", "");
            foreach (Verkaufsgut gut in m_verkaufsgüter)
            {
                File.AppendAllText("Save\\KaffeWelt.txt", gut.m_name + "\r\n");
                File.AppendAllText("Save\\KaffeWelt.txt", gut.m_anzahl.ToString() + "\r\n");
                File.AppendAllText("Save\\KaffeWelt.txt", gut.m_tassenGröße.ToString() + "\r\n");
                File.AppendAllText("Save\\KaffeWelt.txt", gut.m_kosten.ToString() + "\r\n");
                File.AppendAllText("Save\\KaffeWelt.txt", gut.m_count.ToString() + "\r\n");
                File.AppendAllText("Save\\KaffeWelt.txt", gut.m_upgrade.ToString() + "\r\n");
            }
        }

        #region MeilensteineUndErrungenschaften
        //Wenn ein Verkaufsobjekt den jeweiligen Meilenstein erreicht wird der Autoclicker schneller
        //Beim ersten Meilenstein wird der Autoclicker angeschalten
        public void AnzahlUpgradeMeilensteine(int anzahlGüter)
        {
            int[] tmp_Meilensteine = new int[4]{10, 25, 50, 100};
            int tmr_Intervall = m_clicker.tmr_autoclicker.Interval;
            int tmp_upgrade = 250;
            
                if (anzahlGüter == tmp_Meilensteine[0])
                {
                tmr_Intervall -= tmp_upgrade;
                m_clicker.tmr_autoclicker.Start();
                }
                if (anzahlGüter == tmp_Meilensteine[1])
                {
                tmr_Intervall -= tmp_upgrade;
                }
                if (anzahlGüter == tmp_Meilensteine[2])
                {
                tmr_Intervall -= tmp_upgrade;
                }
                if (anzahlGüter == tmp_Meilensteine[3])
                {
                tmr_Intervall -= tmp_upgrade;
                }              
        }

        #endregion
    }
}