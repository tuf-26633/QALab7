using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALab7
{
    class TicTacToe
    {

        int[] board = new int[9];
        public int turn;


        // fills the 3x3 board with 0's indicating empty spaces

        public void CreateBoard()
        {
            for (int x = 0; x < board.Length; x++)
            {
                board[x] = 0;
            }
        }


        /*
         * player X goes first
         */

        public char CurrentPlayer()
        {
            if (turn % 2 == 1)
                return 'X';

            else return 'O';

        }

        public void ChangePlayer()
        {
            turn++;
        }


        /*
         * player types in name (X or O) and selects space
         * X marked as 1
         * O marked as 2
         */

        public void MakeMove(char p, int space)
        {
            if (p == 'X')
            {
                board[space] = 1;
            }

            if (p == 'O')
            {
                board[space] = 2;
            }
        }

        /* 
         * 
         * returns true if there is an X or an O in the board space
         */

        public bool SpaceInUse(int x)
        {
            return board[x] != 0;
        }

    }
}
