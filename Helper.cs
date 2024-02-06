using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Helper
    {
        public void printBoard(string[] board)
        {
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
        }

        public bool hasWinner(string[] board)
        {
            // Check diagonals
            if (board[0] == board[4] && board[4] == board[8])
            {
                return true;
            }
            if (board[2] == board[4] && board[4] == board[6])
            {
                return true;
            }

            // Check rows
            for (int i = 0; i < 9; i += 3) // Increment by 3 for each row
            {
                if (board[i] == board[i + 1] && board[i + 1] == board[i + 2])
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++) // Increment by 1 for each column
            {
                if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                {
                    return true;
                }
            }

            return false;
        }

    }
}
