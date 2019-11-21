using System.IO;
using System.Media;
using System.Text;
using System.Threading;

namespace Exercise_16
{
    public class Poodle : Dog
    {
        public int numberOfPonytails;

        public Poodle(int numberOfPonytails, string favoriteDogFood, string name) : base(favoriteDogFood, name)
        {
            this.numberOfPonytails = numberOfPonytails;
        }

        public override void Bark()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\SmallDogBark.wav");

            soundPlayer.PlayLooping();
            Thread.Sleep(1000);
            soundPlayer.Stop();
            soundPlayer.Dispose();
        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString())
                .AppendLine($"numberOfPonytails: {numberOfPonytails}")
                .ToString();
        }
    }
}
