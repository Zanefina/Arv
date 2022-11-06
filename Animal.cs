using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{   //Base class Animal
    class Animal
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }   //Characteristics of animals.
        public float happiness { get; set; }
        public string color { get; set; }

        public Animal() //Constructor without parameters to create default values
        {

        }
        //Constructor
        public Animal(string name, string gender, int age, float happiness, string color)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.happiness = happiness;
            this.color = color;
        }

        public void PrintData() //Method to print data.
        {
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Gender: {0}", this.gender);
            Console.WriteLine("Age: {0}", this.age);
            Console.WriteLine("Happiness: {0}", this.happiness);
            Console.WriteLine("Color: {0}", this.color);

        }
        public void GoOut() //Method for animals which says that they need to go out.
        {
            Console.WriteLine(this.name + " needs to go out.");
        }
        public void TakeNapp() //Method for animals which says that the animal took a napp.
        {
            Console.WriteLine(this.name + " took a nap ");
        }
    }
}
