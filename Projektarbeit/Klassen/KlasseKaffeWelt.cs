using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Projektarbeit
{
    class KlasseKaffeWelt
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
        public KlasseKaffeWelt()
        {
            m_verkaufsgüter = new Verkaufsgut[4];

            m_verkaufsgüter[0].m_name = "Milchkaffe";
            m_verkaufsgüter[0].m_anzahl = 0;
            m_verkaufsgüter[0].m_tassenGröße = 0;
            m_verkaufsgüter[0].m_kosten = 10;
            m_verkaufsgüter[0].m_count = (decimal)0.1;
            m_verkaufsgüter[0].m_upgrade = false;
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
                        m_verkaufsgüter[i].m_kosten = m_verkaufsgüter[i].m_kosten * 1.5;
                        Clicker.m_HauptCount += m_verkaufsgüter[i].m_count;
                        return m_verkaufsgüter[i].m_anzahl;
                    }
                    return 0;
                }
                return 0;
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
    }
}