using System;
using System.Resources;
using System.IO;
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
            
                m_verkaufsgüter[0].m_name = File.ReadLines(Properties.Resources.KaffeeArten).Take(1).First();
                m_verkaufsgüter[0].m_anzahl = 0;
                m_verkaufsgüter[0].m_tassenGröße = 0;
                m_verkaufsgüter[0].m_kosten = Convert.ToInt32(File.ReadLines(Properties.Resources.KaffeeArten).Skip(1).Take(1).First());
                m_verkaufsgüter[0].m_count = Convert.ToDecimal(File.ReadLines(Properties.Resources.KaffeeArten).Skip(2).Take(1).First());
                m_verkaufsgüter[0].m_upgrade = false;

            Console.WriteLine(m_verkaufsgüter[0].m_kosten);
            
        }
        public void Kaufen(ref double p_gesamtPunkte)
        {
            for (int i = 0; i < m_verkaufsgüter.Length; i++)
            {
                if (p_gesamtPunkte >= m_verkaufsgüter[i].m_kosten)
                {

                }
            }

        }
        public string BekommeControleName(object sender, EventArgs e)
        {
            Button tmp_nameControle;
            string tmp_name;

            tmp_nameControle= sender as Button;
            tmp_name=tmp_nameControle.Name;

            return tmp_name;
        }
    }
}
