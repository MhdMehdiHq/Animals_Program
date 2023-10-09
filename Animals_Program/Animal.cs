using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Program
{
    internal class Animal
    {
        public virtual string Name { get; }
        public virtual void Vocal()
        {
            Console.Write("Sound of the animal : ");
        }
        public virtual void Food()
        {
            Console.Write("What the animal eat : ");
        }
        public virtual void Movement()
        {
            Console.Write("How it move : ");
        }
        public virtual void TimeOfSleep()
        {
            Console.Write("How much they sleep ? ");
        }

    }
}
