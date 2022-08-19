using System;
using System.Net.Cache;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common







            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird Bobo = new Bird();
            {
                Name = "Bobo";
                Age = 2;
                Eyes = true;
                HasHead = true;
                Type = "Parrots";
                Backbone = true;
                wings = 2;
                TwoLegs = true;
            };

            Console.WriteLine($"What is the name of your bird? {Bobo.Name}");
            Console.WriteLine($"Can you tell me how old your bird is ? {Bobo.Age}";
            Console.WriteLine($"Which type of bird is this ? {Bobo.Type}");
            Console.WriteLine($"Is this bird able to see? {Bobo.Eyes}");
            Console.WriteLine($"How about the head? {Bobo.HasHead}");
            Console.WriteLine($"Do these birds have a backbone? {Bobo.Backbone}");
            Console.WriteLine($"These birds have how many wings? {Bobo.Wings}");
            Console.WriteLine($"Birds have two legs, I believe! {Bobo.TwoLegs}");

            ar Glidding = new Reptile()
            {
                Name = "Gliding";
            Age = 2;
            Eyes = true;
            HasHead = true;
            Type = "Goanaa";
            Backbone = true;
            wings = 2;
            TwoLegs = false;
        };
    }
}
