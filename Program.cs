using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {  //Lamb,Cat,Dog,Bichon and Dachsador objects and theis methods.
            Lamb babra = new Lamb("Babra", "Female", 3, 1.0f, "White", "Medium");
            babra.PrintData();
            babra.GiveMilk();
            babra.GoOut();                           //Lamb
            babra.TakeNapp();
            babra.MakeSound();
            Console.WriteLine("------------------------------------------");
            Cat sam = new Cat("Sam", "Male", 13, 0.5f, "Black", 0.1f);
            sam.PrintData();
            sam.TakeNapp();                     //Cat
            sam.Play();
            sam.GoOut();
            sam.MakeSound();
            Console.WriteLine("---------------------------------------------");
            Dog Lucy = new Dog("Lucy", "Female", 4, 4.9f, "Colorful", 55);
            Lucy.PrintData();
            Lucy.TakeNapp();              //Dog
            Lucy.GoOut();
            Lucy.MakeSound();
            Lucy.Eats();
            Console.WriteLine("---------------------------------");
            Bichon Milo = new Bichon("Milo", "Male", 17, 3.7f, "Brown", 12, 56);
            Milo.PrintData();
            Milo.GoOut();
            Milo.TakeNapp();            //Bichon dog
            Milo.MakeSound();
            Milo.Eats();
            Milo.Dont();
            Console.WriteLine("----------------------------------------");
            Dachsador Daisy = new Dachsador("Daisy", "Female", 3, 5.9f, "White", 5.5f, 20);
            Daisy.PrintData();
            Daisy.TakeNapp();
            Daisy.MakeSound();
            Daisy.GoOut();              //Dachasdor dog.
            Daisy.Eats();
            Daisy.ToTrain();
            
            
            
        }
    }
}
