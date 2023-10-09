using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Program
{
    internal class Horse : Animal
    {
        public override string Name => "The name is : Horse";
        public override void Vocal()
        {
            base.Vocal();
            Console.WriteLine("Nnnneeeeiighhh,.neigh !");
        }
        public override void Food()
        {
            base.Food();
            Console.WriteLine("They love to eat grass.");
        }
        public override void Movement()
        {
            base.Movement();
            Console.WriteLine("Walking and running fast.");
        }
        public override void TimeOfSleep()
        {
            base.TimeOfSleep();
            Console.WriteLine("They sleep from 5 to 7 hours a day!");
        }
    }
}
