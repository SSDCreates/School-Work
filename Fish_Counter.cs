using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davidson_Sam_CountFish
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sam Davidson
            //06-10-2018
            //001
            //Count Fish Assignment

            //Declare and Define
            string[] fishColor = new string[10] { "red", "blue", "green", "yellow", "blue", "green", "blue", "blue", "red", "green", };
            int userInput;
            int fishCount = 0;
            string fishShade = "";

            //Req user input
            Console.WriteLine("Welcome to the fish counter\n\r(1)for Red, (2) for Blue, (3) for Green, and(4) for Yellow");
            string userInputString = Console.ReadLine();

            //validate and convert
            while (!int.TryParse(userInputString, out userInput)||userInput > 4)
            {
                Console.WriteLine("Invalid Input! Please enter (1)for Red, (2) for Blue, (3) for Green, and(4) for Yellow and press return");
                userInputString = Console.ReadLine();
            }
       
            //Review input if user selects 1
            if (userInput == 1)
            {
                foreach (string colorFish in fishColor)
                {
                    if (colorFish == "red") //locates string red in the array
                    {
                        fishShade = "red";
                        fishCount++;
                    }
                }
                //review input for a selection of 2
            }
            else if (userInput == 2)
            {
                foreach (string colorFish in fishColor)
                {
                    if (colorFish == "blue")
                    { //locates string blue in array
                        fishShade = "blue";
                        fishCount++;
                    }
                }
                //review input for input of 3
            }
            else if (userInput == 3)
            {
                foreach (string colorFish in fishColor)
                {
                    if (colorFish == "green")
                    {
                        fishShade = "green";
                        fishCount++;
                    }
                }
                //review final input value of 4
            }
            else if (userInput == 4)
            {
                foreach (string colorFish in fishColor)
                {
                    if (colorFish == "yellow")
                    {
                        fishShade = "yellow";
                        fishCount++;
                    }
                }
            }
            else//provide response if value is not listed on the menu 
            {
                Console.WriteLine("There are no fish associated with this value!");
            }
            //returns number of fish and color
            Console.WriteLine("In the fish tank there are {0} fish of the color {1}.", fishCount, fishShade);

            /*Test Values
             * In the fish tank there are 2 fish of the color red.
             * In the fish tank there are 4 fish of the color blue.
             * In the fish tank there are 3 fish of the color green.
             * In the fish tank there are 1 fish of the color yellow.
             * */
        }
    }
}
