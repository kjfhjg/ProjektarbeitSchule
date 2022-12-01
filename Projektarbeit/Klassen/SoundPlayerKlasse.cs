using System;
using System.Media;

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
