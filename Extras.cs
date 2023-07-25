using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class Extras
    {
        public static void PlayMusic()
        {
            new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "./The_Bards_Tale.wav").PlayLooping();
        }
    }
}
