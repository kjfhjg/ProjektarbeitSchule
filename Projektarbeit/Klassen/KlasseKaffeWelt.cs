using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string x = Properties.Resources.KaffeeWelt;
            m_verkaufsgüter[0].m_anzahl = 0;
            m_verkaufsgüter[0].m_tassenGröße = 0;
            m_verkaufsgüter[0].m_kosten = 10;
            m_verkaufsgüter[0].m_name = "Milchkaffe";
            m_verkaufsgüter[0].m_name = "Milchkaffe";

        }
    }
}
