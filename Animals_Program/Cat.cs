using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Program
{
    internal class Cat : Animal
    {
        public override string Name => "The name is : Cat";

        public override void Vocal()
        {
            base.Vocal();
            Console.WriteLine("Meeewwwwwww !");
        }
        public override void Food()
        {
            base.Food();
            Console.WriteLine("Mostly eat everything.But cats love fish and chicken more then others.");
        }
        public override void Movement()
        {
            base.Movement();
            Console.WriteLine("Walking and running.");
        }
        public override void TimeOfSleep()
        {
            base.TimeOfSleep();
            Console.WriteLine("Usually they sleep 16 to 18 hours a day.");
        }
    }
}
