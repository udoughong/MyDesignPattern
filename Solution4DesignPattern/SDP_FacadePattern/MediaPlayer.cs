using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FacadePattern
{
    class MediaPlayer
    {
        Preset preset;
        public void SetPreset(Preset preset)
        {
            this.preset = preset;
        }
        public void ApplyPreset()
        {
            preset.Apply();
        }
        public void Play()
        {
            Console.WriteLine("[MediaPlayer] Playing...");
        }
    }
}
