using System.IO;
using System.Media;
using System.Text;
using System.Threading;

namespace Exercise_16
{
    public class Dog : Animal
    {
        public string favoriteDogFood;

        public Dog(string favoriteDogFood, string name) : base(name)
        {
            this.favoriteDogFood = favoriteDogFood;
        }

        public override void MakeSound()
        {
            Bark();
        }

        public virtual void Bark()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\DogBark.wav");

            soundPlayer.PlayLooping();
            Thread.Sleep(1000);
            soundPlayer.Stop();
            soundPlayer.Dispose();
        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString())
                .AppendLine($"favoriteDogFood: {favoriteDogFood}")
                .ToString();
        }
    }
}
