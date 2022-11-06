using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{   //Dog class that inherits from Animal class
    class Dog : Animal
    {
        //An extra characteristic in addition to those inherited from the Animal class
        public int length { get; set; }
        //Constructor without parameters to create default values
        public Dog()
        {
        }
        //Constructor
        public Dog(string name, string gender, int age, float happiness, string color,int length) : base (name,gender,age,happiness,color)
        {
            this.length = length;
        }
        public void MakeSound()//Method to make sound
        {
            Console.WriteLine("Wuf Wuf");
        }
        public void Eats()//Method to eat
        {
            Console.WriteLine(this.name + " likes to eat meat");
        }
    }
}
