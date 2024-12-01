using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace Game_Character_GUI.Class
{
    public class SoundSystem
    {
        private Queue<string> soundQueue = new Queue<string>();
        private bool isPlaying = false;
        private object lockObject = new object();

        public void PlaySound(string filePath)
        {
            lock (lockObject)
            {
                soundQueue.Enqueue(filePath);

                if (!isPlaying)
                {
                    isPlaying = true;
                    ThreadPool.QueueUserWorkItem(PlayNextSound);
                }
            }
        }

        private void PlayNextSound(object state)
        {
            while (true)
            {
                string filePath;

                lock (lockObject)
                {
                    if (soundQueue.Count == 0)
                    {
                        isPlaying = false;
                        break;
                    }

                    filePath = soundQueue.Dequeue();
                }

                try
                {
                    using (SoundPlayer player = new SoundPlayer(filePath))
                    {
                        player.PlaySync(); // Plays sound synchronously
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error playing sound: {ex.Message}");
                }
            }
        }
    }
}
