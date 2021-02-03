using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird myBird = new Bird();
            myBird.WingColor = "black";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 2.7;

            ///*Create an object of your Reptile class
            //*  give values to your members using the object of your Bird class
            //* Creatively display the class member values 

            var lizard = new Reptiles()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true,
            };

            var myAnimals = new Animal[] { myBird, lizard };

            foreach (var anamal in myAnimals)
            {
                Console.WriteLine($"Alive:{anamal.IsAlive}");
                Console.WriteLine($"Age: {anamal.Age} years old");
                Console.WriteLine($"It Has {anamal.LegCount} legs");
                Console.WriteLine($"It lives by {anamal.LandSeaAir}");
                Console.WriteLine($"");
            }

        }


    }        
             
}

