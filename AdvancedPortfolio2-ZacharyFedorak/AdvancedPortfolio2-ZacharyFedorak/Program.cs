using System;

namespace AdvancedPortfolio2_ZacharyFedorak
{
    class Program
    {
        static void Main(string[] args)
        {
            char playerX = 'X';
            char playerO = 'O';
            bool isFound;
            char[,] boardArray = { { 'A', 'B', 'C' },{ 'D', 'E', 'F' },{ 'G', 'H', 'I' } };
            
            do
            {
                Console.WriteLine("Tic Tac Toe Game");
                Console.WriteLine("The cell IDs for the game shown below.");
                DisplayGame(boardArray);
                Console.Write("Enter cell ID (A-I) for player X: ");
                GetUserChar();
                playerX = GetUserChar();
                SearchArray(boardArray, out isFound);

                if (isFound)
                {
                    boardArray = playerX;
                }

            } while (true);
           
        }
        static void DisplayGame(char[,] displayArray)
        {
            Console.WriteLine("---------------");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write("| " + displayArray[row,column] + " |");

                }
                Console.WriteLine();
                Console.WriteLine("---------------");
            }
        }

        static char GetUserChar()
        {
            char userInput = 'A';
            bool validInput = false;
            do
            {
                try
                {
                    userInput = char.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            } while (validInput == false);
            return userInput;
        }
        static void SearchArray(char[,] searchArray, out bool isFound)
        {
            isFound = false;
            GetUserChar();
            for (int index = 0; index < searchArray.Length; index++)
            {
                if (searchArray [0,0] == GetUserChar() || searchArray[0, 1] == GetUserChar() || searchArray[0, 2] == GetUserChar() || searchArray[1, 0] == GetUserChar() || searchArray[1, 1] == GetUserChar() || searchArray[1, 2] == GetUserChar() || searchArray[2, 0] == GetUserChar() || searchArray[2, 1] == GetUserChar() || searchArray[2, 2] == GetUserChar())
                {
                    isFound = true;
                } 
            }
            
        }
    }
}
