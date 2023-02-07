using System;

namespace Console3InARow
{
    class Program
    {
        static int[,] board = new int[3, 3];
        static int currentPlayer = 1;
        static int moves = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                DrawBoard();
                Console.WriteLine("Player " + currentPlayer + " turn. Enter row and column (0-2):");
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != 0)
                {
                    Console.WriteLine("Invalid move, try again");
                    continue;
                }

                board[row, col] = currentPlayer;
                moves++;
                if (IsWinningMove(row, col))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                if (moves == 9)
                {
                    Console.WriteLine("Draw!");
                    break;
                }

                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine(" 0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] == 0 ? "-" : board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool IsWinningMove(int row, int col)
        {
            // Check row
            for (int i = 0; i < 3; i++)
            {
                if (board[row, i] != currentPlayer)
                {
                    break;
                }
                if (i == 2)
                {
                    return true;
                }
            }

            // Check column
            for (int i = 0; i < 3; i++)
            {
                if (board[i, col] != currentPlayer)
                {
                    break;
                }
                if (i == 2)
                {
                    return true;
                }
            }

            // Check diagonal
            if (row == col)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, i] != currentPlayer)
                    {
                        break;
                    }
                    if (i == 2)
                    {
                        return true;
                    }
                }
            }

            // Check reverse diagonal
            if (row + col == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 2 - i] != currentPlayer)
                    {
                        break;
                    }
                    if (i == 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}