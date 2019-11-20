using System.Text;

namespace Exercise_16
{
    public abstract class Animal
    {
        public string name;

        protected Animal(string name)
        {
            this.name = name;
        }

        public abstract void MakeSound();

        public override string ToString() 
        {
            return new StringBuilder()
                .AppendLine($"{ GetType().Name}")
                .AppendLine($"name: {name}")
                .ToString();
        }
    }
}
