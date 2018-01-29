using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] userList = new int[6];
            Random randomNumber = new Random();
            int[] rNumbers = new int[6];
            int pairs = 0;
            double jackpot = 0;
            string playAgain = null;
            do
            {
                Console.WriteLine("Welcome to the Jackpot game! Today's jackpot is $10,000! Ready? push enter!");
                Console.ReadLine();
                Console.WriteLine("Please enter your lowest number"); //ask user for starting number
                int lowNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your largest number");
                int highNumber = int.Parse(Console.ReadLine()); //ask user for ending numbers
                if (lowNumber < highNumber)
                {
                    //make loop for user input for 6 numbers save input in array use loop to populate
                    Console.WriteLine(" Please select six numbers between " + lowNumber + " and " + highNumber);
                    for (int i = 0; i < userList.Length; i++)
                    {
                        userList[i] = int.Parse(Console.ReadLine());
                        if (highNumber < lowNumber)   //if not make prompt user to imput a valid number   

                        {
                            Console.WriteLine("try Again, please selecct a number higher than " + lowNumber); //set first number to lowest number in range
                        }
                        else if (lowNumber > highNumber) //enter valid #
                        {
                            Console.WriteLine("try Again, please selecct a number lower than " + highNumber); //set number to highest in range
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number at least 6 more than your lowest numbers");
                    highNumber = int.Parse(Console.ReadLine()); //this isnt working properly....i think i need a loop maybe???
                }
                //make loop to compare one number from one array to all the other numbers in arry
                //make loop for random numbers
                for (int i = 1; i < userList.Length; i++)
                {
                    for (int j = 0; j < rNumbers.Length; j++)
                    {
                        randomNumber.Next(lowNumber, highNumber);
                        rNumbers[j] = randomNumber.Next(lowNumber, highNumber);
                        i++;

                        if (rNumbers[j] != rNumbers[j])
                        {
                           rNumbers[j]=randomNumber.Next(lowNumber, highNumber);
                           Console.WriteLine("Lucky Number: " + rNumbers[j]); //display random #
                           i++;
                        }
                        else
                        {
                            rNumbers[j] = randomNumber.Next(lowNumber,highNumber);
                            Console.WriteLine("Lucky Number: " + rNumbers[j]); //display random #
                            i++;
                        }                     
                    }
                    for (int j = 0; j < userList.Length; j++) //compare numbers for matches
                    {
                        if (userList[0] == rNumbers[j])
                        {
                            pairs++;
                        }
                        else if (userList[1] == rNumbers[j])
                        {
                            pairs++;
                        }
                        else if (userList[2] == rNumbers[j])
                        {
                            pairs++;
                        }
                        else if (userList[3] == rNumbers[j])
                        {
                            pairs++;
                        }
                        else if (userList[4] == rNumbers[j])
                        {
                            pairs++;
                        }
                        else if (userList[5] == rNumbers[j])
                        {
                            pairs++;
                        }
                    }
                    jackpot = pairs * 1000; //jackpot formula //calcualte winnings bbased on correct numbe
                }

                Console.WriteLine("You guessed " + pairs + " numbers correctly!"); //correct numbers matches
                Console.WriteLine("You  won $" + jackpot + "!");//you won $!
                Console.WriteLine("Would you like to play again?");
                 playAgain =Console.ReadLine();

                if (playAgain == "no") 
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
            } while (playAgain != "exit"); //replay game
        }
    }
}

    

    
    

