using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{   //Cat class that inherits from Animal class.
    class Cat : Animal
    {   //An extra characteristic in addition to those inherited from the Animal class
        public float cuteness { get; set; }

        //Constructor without parameters to create default values
        public Cat()
        {
        }
        //Constructor
        public Cat(string name, string gender, int age, float happiness, string color,float cuteness) : base(name, gender,age,happiness,color)
        {
            this.cuteness = cuteness;
        }

        public void MakeSound () //Method to make sound
        {
            Console.WriteLine("Mewou!!!");
        }
        public void Play() //Method to play.
        {
            Console.WriteLine(this.name + " leker med en liten boll");
        }
    }
}
