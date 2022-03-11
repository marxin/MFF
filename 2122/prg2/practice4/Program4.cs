/* Program #4 */
using System;
using System.Collections.Generic;

namespace HW
{
    class OctopusSimulator
    {
        int[,] octopusGrid;
        int gridSize;

        private HashSet<(int, int)> flashingCoordinates = new HashSet<(int, int)>();
        
        public int FlashCount { get; private set; }

        private void NullOutFlashes()
        {
            foreach (var coordinates in flashingCoordinates)
            {
                octopusGrid[coordinates.Item1, coordinates.Item2] = 0;
                FlashCount++;
            }
            flashingCoordinates.Clear();
        }

        private void FlashCoordinates(int i, int j)
        {
            flashingCoordinates.Add((i, j));

            for (int k = Math.Max(i - 1, 0); k < Math.Min(i + 2, gridSize); k++)
            {
                for (int l = Math.Max(j - 1, 0); l < Math.Min(j + 2, gridSize); l++)
                {
                    octopusGrid[k, l] += 1;
                    if (octopusGrid[k, l] > 9 && ! flashingCoordinates.Contains((k, l)))
                    {
                        FlashCoordinates(k, l);
                    }
                }
            }
        }
        
        public void LoadOctopusGrid()
        {
            string s = Console.ReadLine();
            gridSize = int.Parse(s);
            octopusGrid = new int[gridSize, gridSize];

            for (int i = 0; i < gridSize; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < gridSize; j++)
                {
                    octopusGrid[i, j] =  line[j]- '0';
                }
            }
        }

        public void SimulateStep()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    octopusGrid[i, j] += 1;
                    if (octopusGrid[i,j] > 9 && !flashingCoordinates.Contains((i, j)))
                    {
                        FlashCoordinates(i, j);
                    }
                }
            }

            NullOutFlashes();
        }

        public void PrintGrid()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Console.Write(octopusGrid[i, j]);
                }
                Console.WriteLine();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var simulator = new OctopusSimulator();
            simulator.LoadOctopusGrid();
            for (int i = 0; i < 100; i++)
            {
                simulator.SimulateStep();
            }
            Console.WriteLine(simulator.FlashCount);
        }
    }
}