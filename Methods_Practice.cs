using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davidson_Sam_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: Sam Davidson
            //Date: 06-15-2018
            //Section:001
            //Methods Activity

            //Painting a Wall

            //Greet and request wall specifications
            Console.WriteLine("Today we will be calculating how much paint it takes to paint a wall!\n\rPlease enter the height of the wall.");
            string wallHeightString = Console.ReadLine();

            //convert height and validate
            double wallHeight;
            while (!double.TryParse(wallHeightString, out wallHeight))
            {
                //inform invalid input
                Console.WriteLine("You have not entered a number.\n\rEnter the wall height and press return");
                wallHeightString = Console.ReadLine();
            }

            //Request wall width
            Console.WriteLine("Please enter the width of the wall.");
            string wallWidthString = Console.ReadLine();

            //Convert width and validate
            double wallWidth;
            while (!double.TryParse(wallWidthString, out wallWidth))
            {
                //inform invalid input
                Console.WriteLine("You have not entered a number.\n\r Please enter the wall width and press return.");
                wallWidthString = Console.ReadLine();
            }

            //req number of coats of paint
            Console.WriteLine("How many coats of paint will be needed?");
            string coatsOfPaintString = Console.ReadLine();

            //convert and validate
            double coatsOfPaint;
            while (!double.TryParse(coatsOfPaintString, out coatsOfPaint))
            {
                //advise invalid input
                Console.WriteLine("No number was entered.\n\rPlease enter the coats of paint needed and press return.");
                coatsOfPaintString = Console.ReadLine();
            }
            //req size of wall
            Console.WriteLine("What is the surface area 1 gallon of paint will cover in square feet?");
            string paintCoverageString = Console.ReadLine();

            //convert and validate
            double paintCoverage;
            while (!double.TryParse(paintCoverageString, out paintCoverage))
            {
                //advise invalid input
                Console.WriteLine("No number was entered.\n\rPlease enter the area covered by a gallon of paint and press return.");
                paintCoverageString = Console.ReadLine();
            }

            //call function
            double gallonsNeeded = PaintAmount(coatsOfPaint, wallWidth, wallHeight, paintCoverage);
            Console.WriteLine("For {0} coats on that wall you will need {1} gallons of paint.", coatsOfPaint, Math.Round(gallonsNeeded, 2));

            /*Test Value
             *Width	– 8,	Height	– 10,	Coats	– 2,	Surface	Area	- 300	ft2
             *  For 2 coats on that wall you will need 0.533333333333333 gallons of paint.
             *Width	– 30,	Height	– 12.5,	Coats	– 3,	Surface	Area	- 350	ft2
             *  For 3 coats on that wall you will need 3.21428571428571 gallons of paint.
             *Width 40; Height 89; coats 8, surface area 375 ft2
             *  For 8 coats on that wall you will need 75.9466666666667 gallons of paint.
             */

            //Sting!
            //How many bee stings can be endured? let's find out!

            //declar and define
            double beeStings = 9;

            //Request user input for the animal weight
            Console.WriteLine("How many bee stings does it take to kill an animal? Let's find out!\r\nPlease enter the animal weight and press return");
            string animalWeightString = Console.ReadLine();

            //convert and validate!
            double animalWeight;
            while (!double.TryParse(animalWeightString, out animalWeight))
            {
                //advise user of error
                Console.WriteLine("You have entered an invalid weight.\r\n Please enter the animal weight and press return!");
                animalWeightString = Console.ReadLine();
            }
            //call function
            double deathBySting = KillerBee(beeStings, animalWeight);
            //provide results
            Console.WriteLine("It takes {0} bee stings to kill this animal", deathBySting);
            /*Test Value
             * Animal’s	Weight	– 10 = It takes 90 bee stings to kill this animal
             * Animal’s	Weight	– 160 = It takes 1440 bee stings to kill this animal
             * Animal’s	Weight	– Twenty = You have entered an invalid weight. Please enter the animal weight and press return!
             *  Animal's Weight - 225 = It takes 2025 bee stings to kill this animal
             * */

            // Reverse it!

            //Define new array!
            string[] arrayFun = new string[5] { " 1 ", " 2 ", " 3 ", " 4 ", " 5 " };
            string arrayForward = "";
            //to read array in forward loop!
            for (int i = 0; i<= arrayFun.Length-1; i++)
            {
                arrayForward += arrayFun[i];
            }
            //call array function!
            string arrayReturn = ArrayReverse(arrayFun); 
            //tell everyone we're awsome and it works!
            Console.WriteLine("Your original Array was {0} and now it is reversed as {1}.", arrayForward, arrayReturn);

            /*TEST VALUE!
             * Your original Array was apple pear peach coconut kiwi  and now it is kiwi coconut peach pear apple .
             * Your original Array was red orange yellow green blue indigo violet and now it is reversed as violet indigo blue green yellow orange red .
             * Your original Array was  1  2  3  4  5  and now it is reversed as  5  4  3  2  1 .
             * */
        }

        //create a function and list values to be measured

        public static double PaintAmount(double coats, double wallWidth, double wallHeight, double paintCoverage)
        {

            //create arithmatic to provide necessary amount of paint
            double gallonsNeeded = (wallWidth * wallHeight / paintCoverage) * coats;
            return gallonsNeeded; //return to be used in main function

        }

        //create the function to calculate stings
        public static double KillerBee(double beeStings, double animalWeight)
        {
            beeStings = 9; //this number will not change, so place it as hardcoded
                           // do the math for animal weight and number of stings
            double deathBySting = beeStings * animalWeight;
            //return to be used in main function
            return deathBySting;

        }
        //create function to reverse the array!
        public static string ArrayReverse(string[] arrayFun)
        {
            int i = 0;
            string arrayReturn = "";
            //for loop to read the index in reverse
            for (i = arrayFun.Length-1; i >= 0; i--){
                arrayReturn += arrayFun[i];
            }
            return arrayReturn;//return array result!
        }
    }

}
	
