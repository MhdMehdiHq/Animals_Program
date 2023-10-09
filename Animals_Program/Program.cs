namespace Animals_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // کلاس پدر = Animal

            Cat cat = new Cat();
            Console.WriteLine(cat.Name + "\n");
            cat.Vocal();
            cat.Movement();
            cat.TimeOfSleep();
            cat.Food();
            Console.WriteLine("\n" + "---------------------------------------------------------------------------------------");
                                                           
            Dog dog = new Dog();                           
            Console.WriteLine(dog.Name + "\n");            
            dog.Vocal();                                   
            dog.Movement();                                
            dog.TimeOfSleep();                             
            dog.Food();                                    
                                                           
            Console.WriteLine("\n" + "---------------------------------------------------------------------------------------");
                                                           
            Tiger tiger = new Tiger();                     
            Console.WriteLine(tiger.Name + "\n");          
            tiger.Vocal();                                 
            tiger.Movement();                              
            tiger.TimeOfSleep();                           
            tiger.Food();                                  
                                                           
            Console.WriteLine("\n" + "---------------------------------------------------------------------------------------");

            Horse horse = new Horse();
            Console.WriteLine(horse.Name + "\n");
            horse.Vocal();
            horse.Movement();
            horse.TimeOfSleep();
            horse.Food();

            Console.ReadKey();
        }
    }
}