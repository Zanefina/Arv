using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{    //Lamb class that inherits from Animal class.
    internal class Lamb : Animal
    {
        public string typeOfWool { get; set; } //An extra characteristic in addition to those inherited from the Animal class

        public Lamb()//Constructor without parameters to create default values
        {

        }
        //Constructor
        public Lamb(string name, string gender, int age, float happiness, string color,string typeOfWool) : base(name, gender, age, happiness, color)
        {
            this.typeOfWool = typeOfWool;
        }

        public void MakeSound() //Method to make sound
        {
            Console.WriteLine("Bääää!");
        }
        public void GiveMilk() //Method to drink milk.
        {
            Console.WriteLine("It's time for "+ this.name + " to drink milk");
        }
    }
}
