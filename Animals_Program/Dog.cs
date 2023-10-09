using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Program
{
    internal class Dog : Animal
    {
        public override string Name => "The name is : Dog";
        public override void Vocal()
        {
            base.Vocal();
            Console.WriteLine("Whaapp, whaapp !");
        }
        public override void Food()
        {
            base.Food();
            Console.WriteLine("Mostly eat meat and bones.");
        }
        public override void Movement()
        {
            base.Movement();
            Console.WriteLine("Walking and running.");
        }
        public override void TimeOfSleep()
        {
            base.TimeOfSleep();
            Console.WriteLine("Usually they sleep 12 to 14 hours a day.And some of them sleep up to 19 hours.");
        }
    }
}
