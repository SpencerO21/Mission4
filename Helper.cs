using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Helper
    {
        public string printBoard(string[] board)
        {
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
        }

        public bool hasWinner(string[] board)
        {
            return false;
        }
    }
}
