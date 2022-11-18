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
        public KlasseKaffeWelt(int auswahl)
        {
            if(auswahl==0)
            {
                NeuesSpiel(Properties.Resources.KaffeeArten);
            }
            else if (auswahl == 1)
            {

            }
            else if (auswahl == 2)
            {

            }

        }
        public void NeuesSpiel(string resources)
        {
            string temp;
            int zaehler = 0;
            m_verkaufsgüter = new Verkaufsgut[4];

            temp = resources;
            string[] stringAufspalten = temp.Split('\n');

            // entferne alle umruchzeichen aus jedem String
            for (int i = 0; i < stringAufspalten.Length; i++)
                stringAufspalten[i] = stringAufspalten[i].Replace("\r", "");

            for (int i = 0; i < m_verkaufsgüter.Length; i++)
            {
                m_verkaufsgüter[i].m_name = stringAufspalten[zaehler++];
                m_verkaufsgüter[i].m_anzahl = 0;
                m_verkaufsgüter[i].m_tassenGröße = 0;
                m_verkaufsgüter[i].m_kosten = Convert.ToInt32(stringAufspalten[zaehler++]);
                m_verkaufsgüter[i].m_count = Convert.ToDecimal(stringAufspalten[zaehler++]);
                m_verkaufsgüter[i].m_upgrade = false;
            }
        }

        public int Kaufen(object p_sender)
        {
            for (int i = 0; i < m_verkaufsgüter.Length; i++)
            {
                if (m_verkaufsgüter[i].m_name == BekommeControleName(p_sender))
                {
                    if (Clicker.m_PunkteGesamt >= m_verkaufsgüter[i].m_kosten)
                    {
                        Clicker.m_PunkteGesamt -= m_verkaufsgüter[i].m_kosten;
                        m_verkaufsgüter[i].m_anzahl += 1;
                        m_verkaufsgüter[i].m_kosten = m_verkaufsgüter[i].m_kosten * 1.1;
                        Clicker.m_HauptCount += m_verkaufsgüter[i].m_count;
                        return m_verkaufsgüter[i].m_anzahl;
                    }
                }
            }
            return 0;
        }
        public static string BekommeControleName(object sender)
        {
            try
            {
                PictureBox Controle = (PictureBox)sender;
                string ControleName = Controle.Name;

                return ControleName;
            }
            catch
            {
                return "";
            }
        }
        //Die Methode bekommt die Position der Verkaufsgüter übergeben und sucht anhand dieser das Passende Objekt und dessen Anzahl.
        //Die Anzahl wird abgeglichen und es wird dann die Passende Bitmap zurückgegeben.
        public Bitmap getAnzahlBeens(int position)
        {
            if (m_verkaufsgüter[position].m_anzahl < 50)
            {
                return Properties.Resources.unknown;
            }
            else if (m_verkaufsgüter[position].m_anzahl >= 50 && m_verkaufsgüter[position].m_anzahl < 150)
            {
                return Properties.Resources.unknown2;
            }
            else if (m_verkaufsgüter[position].m_anzahl >= 150 && m_verkaufsgüter[position].m_anzahl < 300)
            {
                return Properties.Resources.unknown3;
            }
            else if (m_verkaufsgüter[position].m_anzahl >= 350 )
            {
                return Properties.Resources.unknown4;
            }

            return Properties.Resources.unknown;
        }
        //Die Methode bekommt die Position der Verkaufsgüter übergeben und sucht anhand dieser das Passende Objekt und dessen Kosten.
        //Die Kosten werden als integer zurückgegeben.
        public double getBeensKosten(int position)
        {
           return m_verkaufsgüter[position].m_kosten;
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
    }
}