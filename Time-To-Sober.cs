using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Sam Davidson
        //06-17-2018
        //001
        //Final Assignment

        //Request list of drinks, comma seperated
        Console.WriteLine("Please provide a list of drinks you had during the night out seperated by a comma.");
        string userDrinks = Console.ReadLine();

        //validate
        while (string.IsNullOrWhiteSpace(userDrinks))
        {
            Console.WriteLine("The space is empty. Please enter a comma seperated list of drinks and press return.");
            userDrinks = Console.ReadLine();
        }

        //call drink list array
        string[] drinkListArray = DrinkTextToArray(userDrinks.Trim());

        //call drink type array
        string[] drinkTypeArray = PromptForDrinkType(drinkListArray);

        //call sobreity time and attach to variable
        int soberTime = WaitTimeTillSober(drinkTypeArray);

        //output sobriety time
        Console.WriteLine("You must wait {0} minutes before you are sober", soberTime);

    }

    //create function to split input text into array
    public static string[] DrinkTextToArray(string drinkInput)
    {
        string[] drinkList = drinkInput.Split(',');
        return drinkList;
    }

    //create function for drinkType array
    public static string[] PromptForDrinkType(string[] drinkNames)
    {
        int drinkTypeNum;
        int listSize = drinkNames.Length;
        //create new list for drink type w/length matching drinkNames
        string[] drinkType = new string[listSize];

        //Cycle through drink names and request type.
        for (int i = 0; i < listSize; i++)
        {
            Console.WriteLine("For drink " + drinkNames[i] + ". Please enter \r\n(1) For Mixed Drink\r\n(2) For Wine\r\n(3) For Beer\r\n(4) For Non-Alcoholic!");
            string drinkTypeNumString = Console.ReadLine();


            //validate drinkTypeInput and convert
            while (!int.TryParse(drinkTypeNumString, out drinkTypeNum))
            {
                Console.WriteLine("That entry was invalid!\n\rEnter the drink type and press return");
                drinkTypeNumString = Console.ReadLine();
            }
            //cycle through list and attach
            if (drinkTypeNum == 1)
            {
                drinkType[i] = "Mixed Drink";
            }
            else if (drinkTypeNum == 2)
            {
                drinkType[i] = "Wine";
            }
            else if (drinkTypeNum == 3)
            {
                drinkType[i] = "Beer";
            }
            else if (drinkTypeNum == 4)
            {
                drinkType[i] = "Non-Alcoholic";
            }

        }
        return drinkType;
    }
    //create array for time till sober
    public static int WaitTimeTillSober(string[] drinkType)
    {
        //creat variable for wait time
        int timeTillSober = 0;

        //cycle through drink types and add appropraite wait time for sobriety
        for (int i = 0; i < drinkType.Length; i++)
        {
            if (drinkType[i] == "Mixed Drink")
            {
                timeTillSober += 60;
            }
            else if (drinkType[i] == "Wine")
            {
                timeTillSober += 45;
            }
            else if (drinkType[i] == "Beer")
            {
                timeTillSober += 30;
            }
            else
            {
                timeTillSober += 0;
            }
        }
        //return for use in main()
        return timeTillSober;
    }
    /*Test Values
     * Whit Rus, Mosc, Vodk Cran, D. Coke = You must wait 195 minutes before you are sober
     * blackberry margarita, rhubarb margarita, perfect pineapple margarita = all type 1 = You must wait 180 minutes before you are sober
     * Budweiser, Vodka Redbull, Dr. Pepper, Vodka Redbull, Moscow Mule = type, 3,1,4,1,1 = You must wait 210 minutes before you are sober
     * */

}
