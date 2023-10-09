using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Program
{
    internal class Tiger : Animal
    {
        public override string Name => "The name is : Tiger";
        public override void Vocal()
        {
            base.Vocal();
            Console.WriteLine("Rrrroooaaaaarrrrr !");
        }
        public override void Food()
        {
            base.Food();
            Console.WriteLine("Mostly eat meats.");
        }
        public override void Movement()
        {
            base.Movement();
            Console.WriteLine("Walking and running so fast.");
        }
        public override void TimeOfSleep()
        {
            base.TimeOfSleep();
            Console.WriteLine("Some of them sleep up to 20 hours a day!");
        }
    }
}
