/* Program #3 */
using System;

namespace DumboOctopus
{
    class Program
    {
        static long[,] ExtractInput(int arraySize)
        {
            long[,] inputArray = new long[arraySize, arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                long numbers = long.Parse(Console.ReadLine());
                for (int j = arraySize - 1; j >= 0; j--)
                {
                    long newNumber = numbers % 10;
                    inputArray[i, j] = newNumber;
                    numbers /= 10;
                }
            }
            return inputArray;
        }
        static void IncerementElement(long[,] array, int x, int y, int arraySize)
        {
            if (x >= 0 && y >= 0 && x < arraySize && y < arraySize)
            {
                array[x, y]++;
            }
        }
        static long[,] IncrementNeighbours(long[,] energies, int x, int y, int arraySize)
        {
            IncerementElement(energies, x - 1, y - 1, arraySize);
            IncerementElement(energies, x, y - 1, arraySize);
            IncerementElement(energies, x + 1, y - 1, arraySize);
            IncerementElement(energies, x - 1, y, arraySize);
            IncerementElement(energies, x + 1, y, arraySize);
            IncerementElement(energies, x - 1, y + 1, arraySize);
            IncerementElement(energies, x, y + 1, arraySize);
            IncerementElement(energies, x + 1, y + 1, arraySize);
            return energies;
        }
        static (long[,], bool[,], int) CheckFlashes(int sizeOfMap, long[,] energies, bool[,] flashArray, int flashNumber)
        {
            bool flashed;
            do
            {
                flashed = false;
                for (int row = 0; row < sizeOfMap; row++)
                {
                    for (int column = 0; column < sizeOfMap; column++)
                    {
                        if (energies[row, column] > 9)
                        {
                            if (!flashArray[row, column])
                            {
                                flashNumber++;
                                flashArray[row, column] = true;
                                energies = IncrementNeighbours(energies, row, column, sizeOfMap);
                                flashed = true;
                            }
                        }
                    }
                }
            } while (flashed);
            return (energies, flashArray, flashNumber);
        }
        static (long[,], int) Step(int sizeOfMap, long[,] energies, int flashNumber)
        {
            bool flashed = false;
            bool[,] flashes = new bool[sizeOfMap, sizeOfMap];
            for (int row = 0; row < sizeOfMap; row++)
            {
                for (int column = 0; column < sizeOfMap; column++)
                {
                    IncerementElement(energies, row, column, sizeOfMap);
                    if (energies[row, column] > 9)
                    {
                        flashNumber++;
                        flashes[row, column] = true;
                        energies = IncrementNeighbours(energies, row, column, sizeOfMap);
                        flashed = true;
                    }
                }
            }
            if (flashed)
            {
                (energies, flashes, flashNumber) = CheckFlashes(sizeOfMap, energies, flashes, flashNumber);
            }
            for (int i = 0; i < sizeOfMap; i++)
            {
                for (int j = 0; j < sizeOfMap; j++)
                {
                    if (flashes[i, j])
                    {
                        energies[i, j] = 0;
                    }
                }
            }
            return (energies, flashNumber);
        }
        static void Main(string[] args)
        {
            int mapSize = int.Parse(Console.ReadLine());
            long[,] energyLevels = ExtractInput(mapSize);
            int numberOfFlashes = 0;
            for (int i = 0; i < 100; i++)
            {
                (energyLevels, numberOfFlashes) = Step(mapSize, energyLevels, numberOfFlashes);
            }
            Console.WriteLine(numberOfFlashes);
        }
    }
}