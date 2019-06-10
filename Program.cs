using System;

//Creating a Program to exemplify MultiLevel inheritance
namespace Inheritance
{
    //Use ':' for inheritance declarations 

    //Parent class
    class Modes
    {
        public void Mode()
        {
            string meansOfTrans = "There are alot of ways for one to get from place to place.";
            Console.WriteLine("{0}", meansOfTrans);
        }
    }
    //Inherits mode function from Mode
    class Vehicle: Modes
    {
        public void Feature()
        {
            string variety = "All help in traveling. Some come with different accomodations.";
            Console.WriteLine("{0}", variety);
        }
    }

    //Inherits feature function from Vehicle
    //Main class, contains main
    class MainClass:Vehicle
    {
        public void Noise()
        {
            string ok = "This is just a basic set up. I will play with it later and add user interface.";
            Console.WriteLine("{0}", ok);
        }

        public static void Main(string[] args)
        {
            MainClass sheesh = new MainClass();
            sheesh.Mode();
            sheesh.Feature();
            sheesh.Noise();
            Console.Read();
        }
    }


}
