using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace MatzaAvatarGenerator
{
    class Sound
    {
        public static void Play(string path)
        {
            //if (Options.Sound)
                try
                {
                    WindowsMediaPlayer WMP = new WindowsMediaPlayer();
                    //WMP.settings.volume = Options.SoundVolume;

                    WMP.URL = "Data\\Sound\\" + path;
                }
                catch(Exception ex)
                {
                    Log.WriteLine("ERROR: In playing sound '" + path + "': " + ex);
                }
        }
    }
}
