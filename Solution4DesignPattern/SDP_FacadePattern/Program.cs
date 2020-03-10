using System;

namespace SDP_FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer player = new MediaPlayer();
            player.SetPreset(new RockPreset());
            player.ApplyPreset();
            player.Play();
            Console.ReadLine();
        }
    }
}
/*Output:
Applying rock preset
[HighPassFlanger] SetValue
[Echo] Set
[TwoPassEqualizer] SetHigh
[MediaPlayer] Playing...
*/
