using System;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;

namespace Exercise_16
{
    public class Horse : Animal
    {
        public bool racingHorse;

        public Horse(bool racingHorse, string name) : base(name)
        {
            this.racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            Neigh();
        }

        public virtual void Neigh()
        {
            SoundPlayer soundPlayer =
                new Random().Next(10) != 0 ?
                new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\HorseNeigh.wav") :
                new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\HorseBlow.wav");

            soundPlayer.PlayLooping();
            Thread.Sleep(1000);
            soundPlayer.Stop();
            soundPlayer.Dispose();
        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString())
                .AppendLine($"racingHorse: {racingHorse}")
                .ToString();
        }
    }
}
