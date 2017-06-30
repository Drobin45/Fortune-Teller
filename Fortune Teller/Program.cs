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
            // variable strings (first name, last name, age, and favorite ROYGBIV color) 
            // and intergers (birthmonth and number of siblings).

            Console.WriteLine("Welcome to the delightful Fortune Teller program! \nHave fun and please follow instructions accurately!\n");

            Console.WriteLine("Please input your first name");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Input your last name");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Input your age");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input your month of birth, as an interger. \nExample- If you were born in May, write 5");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? If you are unfamiliar with what ROYGBIV is, then type in \"Help\"");
            string color = Console.ReadLine();
            string lowerColor = color.ToLower();

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());


            // Adding "Help" message for users that don't understand what ROYGBIV is.
            //add code here


            // First fortune. Have the app calculate when the user will retire based on if their age is even or odd.        
            // If the users age is even, the retire in 30 years, if their age is odd have them retire in 60 years.

            int newAge;
            if ((age % 2) != 0)
            {
                newAge = 60;
            }
            else
            {
                newAge = 30;
            }

            //Second fortune. Have the app tell the user where their vacation home is depending upon how many siblings they have.
            // Answer for 0, 1, 2, 3, and >3. Also, if they input anything other than >=3, give them a bad vacation home!


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
                vacation = "scenic downtown Birmingham!";
            }
            else if (siblings >= 3)
            {
                Console.WriteLine("Your vacation home will be delightful, cozy condo in the great Azalea city, Mobile, Alabama!");
            }
            else
            {
                vacation = "a tent in Mississipi";
            }
                        
            

            //Third fortune. Have the app use the users color choice to dictate what form of transportation they will have in the future.

            string transportation = "";
            switch (lowerColor)
              {
                case "red":
                    transportation = "a 200cc 1986 Honda Rebel motorcycle!";
                    break;
                case "orange":
                    transportation = "you will be borrowing Steve Carlsburg's ramshackled, tan Corrola";
                    break;
                case "yellow":
                    transportation = "you will be borrowing Daenys Targaryen's favored dragon, Rhaegal";
                    break;
                case "green":
                    transportation = "your most glorious form of transportation will be a Tardis";
                    break;
                case "blue":
                    transportation = "your most glorious form of transportation will be the Elder God Cthulu! Good luck with your ensuing madness?";
                    break;
                case "indigo":
                    transportation = "you will be borrowing your step-uncles roller blades";
                    break;
                case "violet":
                    transportation = "You're most glorious form of transportation will be a segway, you pretentious dingus...";
                    break;
                case "help":
                    Console.WriteLine("ROYGBIV stands for: red, orange, yellow, green, blue, indigo, and violet");
                    Console.WriteLine("Please enter your favorite ROYGBIV color now.");
                    break;
            }

            //Fourth fortune. Have the app tell the user how much money they will have in the bank dependent upon their birthmonth. 
            // 1-4, 5-8, 9-12, and a default for all else

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

            
            Console.WriteLine(firstName + " " + lastName + " will retire in " + newAge + " years with " + bankMoney + " in the bank, a vaction home in " + vacation + " and " + transportation + "for transportation");
           



        }
    }
}
