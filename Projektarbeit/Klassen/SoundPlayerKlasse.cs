using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Resources;

namespace Projektarbeit
{
    internal class SoundPlayerKlasse
    {
        static void SpieleSound(string Sound)
        {
            SoundPlayer player = new SoundPlayer(Sound);
            player.Play();
        }
    }
}
