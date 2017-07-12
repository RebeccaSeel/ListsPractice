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
          


        }
    }
}
