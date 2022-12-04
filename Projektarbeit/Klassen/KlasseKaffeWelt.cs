using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Projektarbeit
{
    public class KlasseKaffeWelt
    {
        public struct Verkaufsgut
        {
            public string m_name;
            public int m_anzahl;
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
                LoadGame(File.ReadAllText("KaffeWelt.txt"));
            }
        }
        public void NeuesSpiel(string p_resources)
        {
            //Initialisieren und Deklarieren.
            int tmp_zaehler = 0;
            m_verkaufsgüter = new Verkaufsgut[4];

            string[] stringAufspalten = p_resources.Split('\n');

            // entferne alle umbruchzeichen aus jedem String.
            for (int i = 0; i < stringAufspalten.Length; i++)
                stringAufspalten[i] = stringAufspalten[i].Replace("\r", "");
            
            //erstellt ein Struct mit den Verkaufsgütern die man im Shop kaufen kann.
            for (int i = 0; i < m_verkaufsgüter.Length; i++)
            {
                m_verkaufsgüter[i].m_name = stringAufspalten[tmp_zaehler++];
                m_verkaufsgüter[i].m_anzahl = 0;
                m_verkaufsgüter[i].m_kosten = Convert.ToDouble(stringAufspalten[tmp_zaehler++]);
                m_verkaufsgüter[i].m_count = Convert.ToDecimal(stringAufspalten[tmp_zaehler++]);
                m_verkaufsgüter[i].m_upgrade = false;
            }
        }
        public void LoadGame(string p_resources)
        {
            //Initialisieren und Deklarieren.
            int tmp_zaehler = 0;
            m_verkaufsgüter = new Verkaufsgut[4];

            string[] stringAufspalten = p_resources.Split('\n');

            // entferne alle umbruchzeichen aus jedem String.
            for (int i = 0; i < stringAufspalten.Length; i++)
                stringAufspalten[i] = stringAufspalten[i].Replace("\r", "");

            // Gesamtpunkte werden geladen
            Clicker.m_punkteGesamt = Convert.ToDouble(stringAufspalten[tmp_zaehler++]);

            // Lade die Anzahl, die pro Klick addiert wird
            Clicker.m_hauptCount = Convert.ToDecimal(stringAufspalten[tmp_zaehler++]);

            //erstellt ein Struct mit den Verkaufsgütern die man im Shop kaufen kann.
            for (int i = 0; i < m_verkaufsgüter.Length; i++)
            {
                m_verkaufsgüter[i].m_name = stringAufspalten[tmp_zaehler++];
                m_verkaufsgüter[i].m_anzahl = Convert.ToInt16(stringAufspalten[tmp_zaehler++]);
                m_verkaufsgüter[i].m_kosten = Convert.ToDouble(stringAufspalten[tmp_zaehler++]);
                m_verkaufsgüter[i].m_count = Convert.ToDecimal(stringAufspalten[tmp_zaehler++]);
                m_verkaufsgüter[i].m_upgrade = Convert.ToBoolean(stringAufspalten[tmp_zaehler++]);
            }

        }

        public int getAmount(string tmp_name)
        {
            int tmp_amount = 0;

            if(tmp_name == "Milchkaffe") tmp_amount = m_verkaufsgüter[0].m_anzahl;
            if (tmp_name == "Cappuccino") tmp_amount = m_verkaufsgüter[1].m_anzahl;
            if (tmp_name == "Latte") tmp_amount = m_verkaufsgüter[2].m_anzahl;
            if (tmp_name == "Espresso") tmp_amount = m_verkaufsgüter[3].m_anzahl;

            return tmp_amount;
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
            else if (m_verkaufsgüter[p_position].m_anzahl >= 150 && m_verkaufsgüter[p_position].m_anzahl < 350)
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
            File.WriteAllText("KaffeWelt.txt", $"{Clicker.m_punkteGesamt} \r\n");
            File.AppendAllText("KaffeWelt.txt", $"{Clicker.m_hauptCount} \r\n");
            foreach (Verkaufsgut gut in m_verkaufsgüter)
            {
                File.AppendAllText("KaffeWelt.txt", gut.m_name + "\r\n");
                File.AppendAllText("KaffeWelt.txt", gut.m_anzahl.ToString() + "\r\n");
                File.AppendAllText("KaffeWelt.txt", gut.m_kosten.ToString() + "\r\n");
                File.AppendAllText("KaffeWelt.txt", gut.m_count.ToString() + "\r\n");
                File.AppendAllText("KaffeWelt.txt", gut.m_upgrade.ToString() + "\r\n");
            }
            if (m_clicker.tmr_autoclicker.Enabled)
            File.WriteAllText("Timer.txt", m_clicker.tmr_autoclicker.Interval.ToString());
        }

        //Wenn ein Verkaufsobjekt den jeweiligen Meilenstein erreicht wird der Autoclicker schneller
        //Beim ersten Meilenstein wird der Autoclicker angeschalten
        public void AnzahlUpgradeMeilensteine(int anzahlGüter)
        {
            int[] tmp_Meilensteine = new int[4]{10, 25, 50, 100};
            int tmr_Intervall = m_clicker.tmr_autoclicker.Interval;
            int tmp_upgrade = 250;

                for (int i = 0; i < tmp_Meilensteine.Length; i++)
                {
                    if (anzahlGüter == tmp_Meilensteine[i])
                    {
                    tmr_Intervall -= tmp_upgrade;
                    m_clicker.tmr_autoclicker.Start();
                    return;
                    }
                    
                }
        }
    }
}