using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcoming user message, and initializing primary 
            // variable strings (first name, last name, age, and favorite ROYGBIV color), 
            // and primary, variable intergers (birthmonth and number of siblings).
            // Finally, a helpful "Help" command has been added to inform our users what ROYGBIV is.

            Console.WriteLine("Welcome to the delightful Fortune Teller program! \nHave fun and enjoy your fortune telling experience!\n");

            Console.WriteLine("Please input the following:");
            Console.WriteLine("Your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Your last name");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of siblings");
            int siblings = int.Parse(Console.ReadLine());

            Console.WriteLine("Your month of birth, as an interger. \nExample- If you were born in May, write 5.");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("If you are unfamiliar with what ROYGBIV is, then type in \"Help\" \nOtherwise, please press enter.");
            string help = Console.ReadLine();
            string lowerHelp = help.ToLower();
            if (lowerHelp == "help")
            {
                Console.WriteLine("ROYGBIV stands for: red, orange, yellow, green, blue, indigo, and violet.");
            }

            Console.WriteLine("What is your favorite ROYGBIV color?");
            string color = Console.ReadLine();
            string lowerColor = color.ToLower();
                        
            // First fortune: Have the app calculate when the user will retire based on if his/her age is even or odd.        
            // If the user's age is even, he/she will retire in 30 years, if his/her age is odd have them retire in 60 years.

            int newAge;
            if ((age % 2) != 0)
            {
                newAge = 60;
            }
            else
            {
                newAge = 30;
            }

            //Second fortune. Have the app tell the user where his/her vacation home is depending upon how many siblings he/she has.
            //Answer for 0, 1, 2, 3, and >3. Also, if his/her input is less than 0, give him/her a bad vacation home!
            
            string vacation = "";
            if (siblings == 0)
            {
                vacation = "rustic Huntsville, Alabama";
            }
            else if (siblings == 1)
            {
                vacation = "the gloriously humid swamps of Bayou Le Batre";
            }
            else if (siblings == 2)
            {
                vacation = "the elegent Alabama city of Spanish Fort";
            }
            else if (siblings == 3)
            {
                vacation = "scenic downtown Birmingham";
            }
            else if (siblings >= 3)
            {
                vacation = "the great Azalea city, Mobile, Alabama";
            }
            else
            {
                vacation = "a tent in Mississipi";
            }                      
            
            //Third fortune. Have the app use the user's color choice to dictate what form of transportation he/she will have in the future.
                        
            string transportation = "";
            switch (lowerColor)
              {
                case "red":
                    transportation = "you will have a 200cc 1986 Honda Rebel motorcycle ";
                    break;
                case "orange":
                    transportation = "you will be borrowing Steve Carlsburg's ramshackled, tan Corrola ";
                    break;
                case "yellow":
                    transportation = "you will be borrowing Daenys Targaryen's favored dragon, Rhaegal ";
                    break;
                case "green":
                    transportation = "your will possess a most glorious Tardis ";
                    break;
                case "blue":
                    transportation = " you will ride among the Elder God Cthulu's unholy writhing tendrils ";
                    break;
                case "indigo":
                    transportation = "you will be borrowing your step-uncle Bob's roller blades ";
                    break;
                case "violet":
                    transportation = "you will be gliding on a segway... ";
                    break;
              }

            //Fourth fortune. 
            //Have the app tell the user how much money he/she will have in the bank dependent upon his/her month of birth. 
           
            string bankMoney;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankMoney = "$1,500";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankMoney = "$2,500";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankMoney = "$2,750";
            }
            else
            {
                bankMoney = "$0.00";
            }

            // Consolidate all outcomes to the final fortune telling sentence.

            Console.WriteLine(firstName + " " + lastName + " will retire in " + newAge + " years with " + bankMoney + " in the bank, a vaction home in " + vacation + " and " + transportation + "for transportation.");

            //Final comment. Stretch goal of allowing the user to quit the program at any poinint in the application attempted
            // with no success. Route attempted: discover what command will quite the program (google search brought up Environment.ExitCode();)
            // but I was unsuccessful in finding out how to properly impliment any exit command.
            // If the proper use of that command was discovered, it would be placed as a toLower() command option within 
            // ever Console.Readline() command.
        }
    }
}
