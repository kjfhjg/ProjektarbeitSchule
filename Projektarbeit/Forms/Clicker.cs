using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbeit
{
    public partial class Form1 : Form
    {
 
        decimal m_mainCount = (decimal)0.1;
        double m_mainPunkteGesamt = 100000;
        decimal m_zwischenPunkte;
        KlasseKaffeWelt x = new KlasseKaffeWelt();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
