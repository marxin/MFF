/* Program #2 */
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int boardSize = int.Parse(Console.ReadLine());

        int[,] board = new int[boardSize, boardSize];

        for(int j = 0;j<boardSize; j++)
        {
            string row = Console.ReadLine();
            for(int i=0; i<boardSize; i++)
            {
                board[j, i] = (int)Char.GetNumericValue(row[i]); 
            }
        }

        int[,] surroundings = new int[,] {{1, 0}, {1, 1}, {0, 1}, {-1, -1}, {1, -1}, {-1, 1}, {0, -1}, {-1, 0}};
        long flashes = 0;
        bool flashing = false;

        for(int i=0; i<100; i++)
            Step();

        Console.WriteLine(flashes);

        void Step()
        {
            for(int i=0; i<boardSize; i++)
            {
                for(int j=0; j<boardSize; j++)
                {
                    board[i, j]++;
                }
            }
            Flash();
        }

        void Flash()
        {
            flashing = false;
            for(int i=0; i<boardSize; i++)
            {
                for(int j=0; j<boardSize; j++)
                {
                    if(board[i, j] >= 10)
                    {
                        board[i, j] = 0;
                        flashes++;
                        for(int n = 0; n<8; n++)
                        {
                            try
                            {
                                if(board[i+surroundings[n,0], j+surroundings[n,1]] != 0)
                                {
                                    if(++board[i+surroundings[n,0], j+surroundings[n,1]] >= 10)
                                        flashing = true;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                ;
                            }
                        }
                    }
                }
            }
            if(flashing)
            {
                Flash();
            }
        }
    }
}