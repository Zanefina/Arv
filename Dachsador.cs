using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    //Dachsador class that inherits from Dog class
    class Dachsador : Dog
    {
        //An extra characteristic in addition to those inherited from the Animal class
        public float energy { get; set; }

        //Constructor without parameters to create default values
        public Dachsador()
        {

        }
        //Constructor
        public Dachsador(string name, string gender, int age, float happiness, string color,float energy, int length): base(name, gender, age, happiness, color,length)
        {
            this.energy = energy;
        }

        public void ToTrain()//Method to train.
        {
            Console.WriteLine(this.name + " is training now");
        }
    }
}
