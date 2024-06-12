using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This info is for the bird:");
            Bird animal1 = new Bird();

            animal1.Diet = "Worms";
            animal1.EatsFish = true;
            animal1.Habitat = "Nest";
            animal1.Sound = "Tweet";

         animal1.PrintBirdDetails();
            Console.WriteLine();
            Console.WriteLine("This info is for the reptile:");

            Reptile animal2 = new Reptile();

            animal2.HasLegs = true;
            animal2.IsCarnivor = true;
            animal2.Water = "Swamp"; 
            animal2.HasForkedTongue = true;

         animal2.PrintReptileDetails();
            
            
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird - DONE
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile - DONE
            // Set this class to inherit from your Animal Class - DONE




            /*Create an object of your Bird class - DONE
             *  give values to your members using the object of your Bird class - DONE
             *  
             * Creatively display the class member values - DONE
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class - DONE
             *  
             * Creatively display the class member values - DONE
             */
        }
    }
}
