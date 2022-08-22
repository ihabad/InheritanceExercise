using System;
using System.Net.Cache;
using System.Net.Http.Headers;

namespace Inheritance
{
    class Program
    {
        private static bool Backbone;

        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


           /// Create a class Bird
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
                Bobo.Name = "Bobo";
                Bobo.Age = 2;
                Bobo.Eyes = true;
                Bobo.HasHead = true;
                Bobo.Type = "Parrots";
                Bobo.Backbone = true;
                Bobo.Wings = 2;
                Bobo.TwoLegs = true;
            };

          

            Console.WriteLine($"What is the name of your bird? {Bobo.Name}");
            Console.WriteLine($"Can you tell me how old your bird is? {Bobo.Age}");
            Console.WriteLine($"Which type of bird is this? {Bobo.Type}");
            Console.WriteLine($"Is this bird able to see? {Bobo.Eyes}");
            Console.WriteLine($"Do these birds have big heads? {Bobo.HasHead}");
            Console.WriteLine($"Do these birds have a backbone? {Bobo.Backbone}");
            Console.WriteLine($"These birds have how many wings? {Bobo.Wings}");
            Console.WriteLine($"Birds have two legs, I believe! {Bobo.TwoLegs}");


            Reptile varan  = new Reptile();
            {
                varan.Name = "spike";
                varan.Age = 1;
                varan.Eyes = true;
                varan.HasHead = true;
                varan.Type = "lizard";
                varan.Backbone = true;
                varan.Wings = 2;
                varan.TwoLegs = true;
            };
            Console.WriteLine($"Name {varan.Name} Age {varan.Age} Eyes {varan.Eyes} Head {varan.HasHead}" +
                $" which Type {varan.Type}  Has Backbone {varan.Backbone} Two Legs {varan.TwoLegs}");
        }
    }
}
