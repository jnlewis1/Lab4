// See https://aka.ms/new-console-template for more information
using System;

namespace Lab4

{
    class Program
    {

    //Welcome to Toy Story! Create a menu-driven application that allows the user to completes the following:
    // 1. Buy an item
    // 2. Give Hamm a coin
    // 3. Check Hamm’s money balance
    // 4. Exit the program

    //Menu()
        // Creates a totalMoney variable and sets its value to $11.00
        // Shows user how much money they have
        // Calls method to display all menu options
        // Accepts users menu selection, checks to see if it is valid, and calls the method corresponding to users choice

    // DisplayMenu()
        // Display the menu with all options listed in previous slide
    
    // BuyItem()
        // Accepts a parameter for totalMoney
        // Displays toy options for users
        // Reads in the user choice and calls the Transaction method if user enters valid selection
        
    // Transaction()
        // Should accept the users choice of toy and the total amount of money user has
        // Test which dollar amount is associated with users selection and if they have enough money to purchase
        // Update the users total amount of money to reflect the purchase
    
    // DisplayToyItems()
        // Allow the user to choose from the following options
        // Mr. Potato head mustache | $5
        // Spaceship for Buzz Lightyear | $10
        // Cowboy hat for Woody | $15
        // Purse for Barbie | $20

    // GiveHammACoin()
        // Accepts one parameter for totalMoney
        // Asks user to enter one of the following coin types and associate it with a value
        // Penny, = 0.01
        // Nickel = 0.05
        // Dime = 0.10
        // Quarter = 0.25

    // CheckMoneyBalance()
        // Accepts one argument for totalMoney
        // Displays to user ****** Ham's Money Balance: $XXX ******
        
        static void Main(string[] args)
        {
            Menu();
            GiveHammACoin();
            Console.WriteLine("Would you like to continue the program? Type 'yes' to continue, type 'no' to exit.");
            string userDecision = Console.ReadLine();
            while (userDecision != "no") 
            {
                return;
            }

            while (userDecision == "no")
            {
                break;
            }

        }

        static void Menu()
        {
            // Creates a totalMoney variable and sets its value to $11.00
            double totalMoney = 11.00;

            // Shows user how much money they have
            Console.WriteLine("Hi! Welcome to the Toy Story Shop! You currently have a total of $" + totalMoney + " to spend.\n");
            // Calls method to display all menu options
            DisplayMenu();
            // Accepts users menu selection, checks to see if it is valid, and calls the method corresponding to users choice
            // string userSelection = Console.ReadLine();
            
            BuyItem();

            // return;           
        }

        static void DisplayMenu() 
        {
            // Display the menu with all options listed in previous slide
            DisplayToyItems();
        }

        static void BuyItem()
        {
            // Accepts a parameter for totalMoney
            double totalMoney = 11.00;
            double cost = 0.0;
            // Displays toy options for users
            // Reads in the user choice and calls the Transaction method if user enters valid selection
            string userSelection = Console.ReadLine();
            if(userSelection == "Mr. Potato Head")
            {
                cost = 5;
                Console.WriteLine("\nYou have chosen Mr. Potato Head, which cost $" + cost + "!");
            }
            else if(userSelection == "Spaceship for Buzz Lightyear")
            {
                cost = 10;
                Console.WriteLine("\nYou have chosen a Spaceship for Buzz Lightyear, which cost $" + cost + "!");
            }
            else if(userSelection == "Cowboy hat for Woody")
            {
                cost = 15;
                Console.WriteLine("\nYou have chosen a Cowboy hat for Woody, which cost $" + cost + "!");
            }
            else if(userSelection == "Purse for Barbie")
            {
                cost = 20;
                Console.WriteLine("\nYou have chosen a Purse for Barbie, which cost $" + cost + "!");
            }
            else
            {
                Console.WriteLine("\nYou have entered something that does not match our menu system, please try again.\n");
            }

            Transaction(cost);

            // return cost;
        }

        static double Transaction(double cost)
        {
            // Should accept the users choice of toy and the total amount of money user has
            // Test which dollar amount is associated with users selection and if they have enough money to purchase
            // Update the users total amount of money to reflect the purchase
            double totalMoney = 11.00;

            while (cost <= 11.00)
            {
                totalMoney = totalMoney - cost;
                Console.WriteLine("You now have a balance of $" + totalMoney + ".");
                break;
            }
            
            while (cost > 11.00)
            {
                Console.WriteLine("You do not have enough money to make this purchase.");
                break;
            }

            return totalMoney;
        }
    


        static void DisplayToyItems() 
        {
            // Allow the user to choose from the following options
            Console.WriteLine("TOY MENU\n\n");
            // Mr. Potato head mustache | $5
            Console.WriteLine("Mr. Potato Head | $5");
            // string potatoHead = "Mr. Potato Head";
            // Spaceship for Buzz Lightyear | $10
            Console.WriteLine("Spaceship for Buzz Lightyear | $10");
            // string spaceship = "Spaceship for Buzz Lightyear";
            // Cowboy hat for Woody | $15
            Console.WriteLine("Cowboy hat for Woody | $15");
            // string cowboyHat = "Cowboy hat for Woody";
            // Purse for Barbie | $20
            Console.WriteLine("Purse for Barbie | $20\n\n"); 
            // string purse = "Purse for Barbie";
            Console.WriteLine("Please enter the full title (as displayed on the menu, without the price) to select an item.\n");   

        
        }



        static void GiveHammACoin()
        {
           // Accepts one parameter for totalMoney
            // Asks user to enter one of the following coin types and associate it with a value
            Console.WriteLine("\nCongrats on your purchase! Now, give Ham a coin! Choose which type of coin you would like to give: enter 'penny', 'nickel', 'dime', or 'quarter'.\n");

            double penny = 0.01;
            double nickel = 0.05;
            double dime = 0.10;
            double quarter = 0.25; 
            double hamBalance = 0.00;

            string coinType = Console.ReadLine();
            double chosenCoin = 0.00;

            if (coinType == "penny")
            {
                chosenCoin = penny;
                hamBalance = hamBalance + chosenCoin;
            }

            else if (coinType == "nickel")
            {
                chosenCoin = nickel;
                hamBalance = hamBalance + chosenCoin;
            }

            else if (coinType == "dime")
            {
                chosenCoin = dime;
                hamBalance = hamBalance + chosenCoin;
            }

            else if (coinType == "quarter")
            {
                chosenCoin = quarter;
                hamBalance = hamBalance + chosenCoin;
            }

            else
            {
                Console.WriteLine("You have entered an invalid coin type, please try again.");
            }


            CheckMoneyBalance(hamBalance); 

        }

        static double CheckMoneyBalance(double hamBalance) 
        {
            // Accepts one argument for totalMoney
            // Displays to user ****** Ham's Money Balance: $XXX ******
        
            Console.WriteLine("****** Ham's Money Balance: " + hamBalance + " ******");

            return hamBalance;
        }

    }
}
