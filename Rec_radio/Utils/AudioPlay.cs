using System;
using System.Media;

namespace Rec_radio.Utils
{
    public class AudioPlayer
    {
        public static void PlayAudio(string filePath)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }
        }
    }
}
