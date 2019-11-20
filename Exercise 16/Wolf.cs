using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    class Wolf : Dog
    {
        public string nameOfPack;

        public Wolf(string nameOfPack, string favoriteDogFood, string name) : base(favoriteDogFood, name)
        {
            this.nameOfPack = nameOfPack;
        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString())
                .AppendLine($"nameOfPack : {nameOfPack}")
                .ToString();
        }
    }
}
