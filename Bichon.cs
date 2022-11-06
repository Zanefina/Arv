using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{   //Bichon class that inherits from Dog class
    class Bichon : Dog
    {
        //An extra characteristic in addition to those inherited from the Animal class
        public int weight { get; set; }

        //Constructor without parameters to create default values
        public Bichon()
        {
        }

        //Constructor
        public Bichon(string name, string gender, int age, float happiness, string color,int weight,int length):base(name, gender, age, happiness, color,length)
        {
            this.weight = weight;
        }

        public void Dont() //Method that indicates something that is not allowed to do with the dog
        {
            Console.WriteLine("Never leave" + this.name + " alone.They are not adapted to loneliness.");
        }

    }
}
