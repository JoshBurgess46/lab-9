using System;
using System.Collections.Generic;

namespace GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string> { "Tom Sanders", "Eric Fiddlestick", "Grant Chirpus", "Aretha Franklin", "Barock Obama" };
            List<string> food = new List<string> { "Pizza", "Greens", "Bananas", "Pasta", "Potato Salad" };
            List<string> hometown = new List<string> { "Detoit, MI", "Cleveland, OH", "Dallas, TX", "Atlanan, GA", "Seattle, WA" };
            List<string> color = new List<string> { "Purple", "Yellow", "Maroon", "Turquoise", "Green" };

            int input = 1;
            bool go = true;
            while (go)
            {
                try
                {
                    Console.WriteLine("Which student do you want to learn more about? Or would you like to add a student!('add student')");

                    DisplayPeople(students);
                    string somethingCoolHappens = Console.ReadLine();
                    if (somethingCoolHappens == "add student")
                    {

                        Console.WriteLine("Gimme name");
                        AddToList(students, Console.ReadLine());

                        Console.WriteLine("Gimme hometown");
                        AddToList(hometown, Console.ReadLine());

                        Console.WriteLine("Gimme food");
                        AddToList(food, Console.ReadLine());

                        Console.WriteLine("Gimme color");
                        AddToList(color, Console.ReadLine());
                    }
                    else
                    {
                        input = GetUserInput(somethingCoolHappens);
                        DisplayInfo(input, students, food, hometown, color);

                    }



                    go = Continue();
                }
                catch
                {
                    Console.WriteLine("mmmmmm.....try again.");
                }

            }

        }
        public static void DisplayPeople(List<string> students)
        {

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {students[i]}");
            }

        }
        public static void DisplayInfo(int input, List<string> students, List<string> food, List<string> hometown, List<string> color)
        {


            Console.WriteLine($"You picked {students[input - 1]}, What would you like to know about them?(hometown, favorite food, or favorite color.)");
            string userInput = Console.ReadLine();

            if (userInput == "hometown")
            {

                Console.WriteLine($"They are from {hometown[input - 1]}!");
            }
            else if (userInput == "favorite food")
            {
                Console.WriteLine($"Their favorite food is {food[input - 1]}!");
            }
            else if (userInput == "favorite color")
            {
                Console.WriteLine($"Their favorite color is {color[input - 1]}!");
            }
        }

        public static int GetUserInput(string input)
        {
            return int.Parse(input);
        }
        public static int GetUserInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static List<string> AddToList(List<string> studentInfo, string input)
        {
            studentInfo.Add(input);
            return studentInfo;
        }

        public static bool Continue()
        {
            Console.WriteLine($"Press {'y'} to continue or press any other key to exit.");
            char response = Console.ReadKey(true).KeyChar;
            if (response == 'y')
            {
                return true;
            }
            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}
