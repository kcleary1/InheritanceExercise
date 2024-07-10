using System;

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
            Bird eagle = new Bird 
            { Tongue = "not what you think of", Eyes = "piercing", Skeleton = "profound", Nose = "characteristic", Feathers = "defining", Wings = "impressive", Beak = "profound", HollowBones = "intelligent" }; 

            Console.WriteLine("Below is a list of descriptions for certain features of an eagle:");
            
            Console.WriteLine($"{eagle.Tongue}\n{eagle.Eyes}\n{eagle.Skeleton}\n{eagle.Nose}\n{eagle.Feathers}\n{eagle.Wings}\n{eagle.Beak}\n{eagle.HollowBones}");

            Console.WriteLine("Which description do you think was used for the beak?");

            var answer = Console.ReadLine();

            if (answer == "profound")

            {
                Console.WriteLine("You guessed correctly!");
            }
            else
            {
                Console.WriteLine("That was not the description used for the beak of an eagle.");
            }


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
            Reptile snake = new Reptile
            { Tongue = "forked", Eyes = "deceiving", Skeleton = "unique", Nose = "perceptive", Scales = "defining", ColdBlooded = "interesting", Turtles = "very cool", Snakes = "fascinating" };

            Console.WriteLine("Below is a list of adjectives");

            Console.WriteLine($"{snake.Tongue}\n{snake.Eyes}\n{snake.Skeleton}\n{snake.Nose}\n{snake.Scales}\n{snake.ColdBlooded}\n{snake.Turtles}\n{snake.Snakes}");

            Console.WriteLine("Pick one that you would use to describe a reptile.");

            var answerOne = Console.ReadLine();
            Console.WriteLine("Now pick one that you would use to describe a snake.");
            var answerTwo = Console.ReadLine();
            Console.WriteLine("Now pick one that you would use to describe a turtle.");
            var answerThree = Console.ReadLine();


            Console.WriteLine("Here is an ad lib containing your choices:");

            Console.WriteLine($"Once there was a {answerOne} iguana. It would always be {answerTwo} observing what was happening. However, one day this {answerThree} habit did not work out as planned, and the iguana fell into the a lake!"); 

















        }




    }
}

