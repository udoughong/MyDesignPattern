using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FacadePattern
{
    class RockPreset : Preset
    {
        public override void Apply()
        {
            Console.WriteLine("Applying rock preset");
            HighPassFlanger flanger = new HighPassFlanger();
            Echo echo = new Echo();
            TwoPassEqualizer equalizer = new TwoPassEqualizer();
            flanger.SetValue();
            echo.Set();
            equalizer.SetHigh();
        }
    }
}
