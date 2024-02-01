using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Mission4;

class Program
{

    static void Main(string[] args)
    {
        Driver();
    }
    static void Driver()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe.");

        string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int playerNum = 1;
        bool exitLoop = false;

        Helper h = new Helper();

        do
        {
            // Prompt the player
            Console.WriteLine($"Player {playerNum}, where will you play? 1-9");
            h.printBoard( board );
            string playerChoice = Console.ReadLine();

            if (int.TryParse(playerChoice, out int playerChoiceInt) &&
                playerChoiceInt >= 1 && playerChoiceInt <= 9 &&
                board[playerChoiceInt - 1] != "X" && board[playerChoiceInt - 1] != "O")
            {
                board[playerChoiceInt - 1] = (playerNum == 1) ? "X" : "O";
                h.printBoard(board);
                // Checks for winner
                if (h.hasWinner(board))
                {
                    Console.WriteLine($"Player {playerNum} wins!");
                    exitLoop = true;
                }
                // Checks for tie
                else if (!board.Contains("1") && !board.Contains("2") && !board.Contains("3") &&
                         !board.Contains("4") && !board.Contains("5") && !board.Contains("6") &&
                         !board.Contains("7") && !board.Contains("8") && !board.Contains("9"))
                {
                    Console.WriteLine("It's a tie!");
                    exitLoop = true;
                }

                // Switch players
                playerNum = (playerNum == 1) ? 2 : 1;
            }
            else
            {
                Console.WriteLine("Invalid input! Please choose an available number from 1 to 9.");
            }

        } while (!exitLoop);
    }
}