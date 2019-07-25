using System;
using System.Collections.Generic;

namespace GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {//created lists for info of students
            List<string> students = new List<string> { "Tom Sanders", "Eric Fiddlestick", "Grant Chirpus", "Aretha Franklin", "Barock Obama" };
            List<string> food = new List<string> { "Pizza", "Greens", "Bananas", "Pasta", "Potato Salad" };
            List<string> hometown = new List<string> { "Detoit, MI", "Cleveland, OH", "Dallas, TX", "Atlanan, GA", "Seattle, WA" };
            List<string> color = new List<string> { "Purple", "Yellow", "Maroon", "Turquoise", "Green" };
            //input was instantiated to 1 because we have input -1 to line up the user choice with the placement of the list
            int input = 1;
            bool go = true;
            while (go)
            {
                try
                {//prompts the user for input
                    Console.WriteLine("Which student do you want to learn more about? Or would you like to add a student!('add student')");
                    //calling on method to display the students
                    DisplayPeople(students);
                    //gets user input and if the type 'add student' it goes into the if statment
                    string somethingCoolHappens = Console.ReadLine();
                    //calls on the addtolist method which will store the input 
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
                    {//input goes to the second getuserinput that holds a string, then calls on the displayinfo method which after you enter in your student + info
                        //it is now stored in the memory of the console and will display the stored info correctly once chosen
                        input = GetUserInput(somethingCoolHappens);
                        DisplayInfo(input, students, food, hometown, color);
                    }
                    //initiates the continue method, will ask the user if they would like to cont. or end program
                    go = Continue();
                }
                catch
                {
                    //if user does not enter in any of the requested info this will display.
                    Console.WriteLine("mmmmmm.....try again.");
                }

            }
        }
        //made this method void because it is just printing to the console.
        public static void DisplayPeople(List<string> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {students[i]}");
                //1. student name
            }
        }
        //huge method, calls on all lists and uses incantination to apply the list info in the sentence
        public static void DisplayInfo(int input, List<string> students, List<string> food, List<string> hometown, List<string> color)
        {
            // made input -1 because if not it will display the wrong info for the wrong person. Just aligns the user input with the correct info
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
        //this is used to gather the info for the add student part.
        public static int GetUserInput(string input)
        {
            //because method was declared as an int and stores a string, we can hold it like this
            return int.Parse(input);
        }
        //this method is taking the user input when they add a student and storing the info and adding it to the list.
        //did not make this method void for practice for the assessment, we need to return List<> were as if we make it void itll just be stored in console memory
        public static List<string> AddToList(List<string> studentInfo, string input)//**USE THIS IN THE ASSESSMENT**
        {
            //adds an object to the end of the list
            studentInfo.Add(input);
            return studentInfo;
        }
        //made this method bool so it will return true or false
        public static bool Continue()
        {
            //will prompt the user if they would like to cont. if not end the program
            Console.WriteLine($"Press {'y'} to continue or press any other key to exit.");
            char response = Console.ReadKey(true).KeyChar;
            if (response == 'y')
            {
                return true;
            }
            else if (response != 'y')
            {
                //if the user does not enter 'y' the program will return false and end the program
                return false;
            }
            else
            {
                //use recursion to call on the method
                return Continue();
            }
        }
    }
}
