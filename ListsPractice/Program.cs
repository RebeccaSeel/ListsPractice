using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////List<int> varNam = new List<int>() {98, 100,76,84,93};

            ////create list of favorite numbers
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7); //the value of 7 is added to list, not 7 elements or indices
            //favNumbers.Add(25); //the value of 25 is added to list, not 7 element or indices
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine(favNumbers.Count); //prints the length of the list (for arrays = .Length)

            ////when you know the content of your list
            //List<string> books = new List<string> { "Cat in the Hat", "Toad and Frog", "Green Eggs and Ham" };

            ////insert into the list at a paticular position and moves what was there down 1
            //Console.WriteLine(books[0]); //prints Cat in the Hat
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]); //now prints Horton hears a Who

            ////example: create a list and add 5 animals using the .Add()
            ////print each animal in the list
            //List<string> animal = new List<string>();
            //animal.Add("cat");
            //animal.Add("dog");
            //animal.Add("skunk");
            //animal.Add("horse");
            //animal.Add("donkey");

            //foreach(string animalType in animal)
            //{
            //    Console.WriteLine(animalType);
            //}

            //for(int i = 0; i<animal.Count;i++)
            //{
            //    Console.WriteLine(animal[i]);
            //}


            //create the following list:
            //A bool list {true, false, false, true, false}
            //loop through each value
            //if the value is true print "Better bring an umbrella"
            //if the value is false print "No rain today enjoy the sun"

            //List<bool> rain = new List<bool> { true, false, false, true, false };

            //foreach(bool forecast in rain)
            //{
            //    if (forecast == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today enjoy the sun");
            //    }
            //}

            //another method important with lists is contains, returns a boolean
            //create list of favorite foods

            //List<string> favFoods = new List<string> { "Steak", "fish", "katsudon", "ice cream", "nachos" };
            //if(favFoods.Contains("fish")) //will run if true since this is a boolean
            //{
            //    Console.WriteLine("I like fish too!!");
            //}

            //create a list with the following numbers: 1, 23,9, 77,922, 6, 32, 63, 14, 5
            //use the contains method with the following values: 23, 77, 15
            //remove these elements: 23 77 32 and 6
            //use contains() again on these values: 23 77 15
            //these will print out true, true, false, false, false, false

            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //numbers.Remove(23);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);

            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //Remove.At[] will remove at a specific index

            //Final problem for lists
            //Create a console app - a movie ordering service
            //ask the user for a movie they want to see
            //let user know we have that movie
            //if movie doesn't exist, add it to the list 
            //let user know it will be available in 3-5 days
            //when the user quits, show them all of the movies in the list
            string movieTitle;
            List<string> movies = new List<string> { "Transporter", "Bourne Identity", "Speed", "Star Wars", "Avatar" };
            do
            {
                Console.WriteLine("Thanks for checking out our movie service!\n");
                Console.WriteLine("You can quit at any time by typing \"QUIT\".\n");
                Console.WriteLine("Please enter a movie to see if we have it: ");
                movieTitle = Console.ReadLine().ToUpper();
                if (movies.Contains(movieTitle))
                {
                    Console.WriteLine("Yes! We have that movie and will send it to you ASAP!");
                }
                else
                {
                    Console.WriteLine("We're sorry! We do not have that title but will add it and it will be availble in 3-5 days.");
                    movies.Add(movieTitle);
                }

                if (Console.ReadLine() == "Quit")
                {
                    Console.WriteLine("Here is list of our current movies: " + movies);
                }
            } while (movieTitle != "QUIT");
                        
        }
    }
}
