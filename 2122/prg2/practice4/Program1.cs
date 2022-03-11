/* Program #1 */
using System;
using System.Collections.Generic;

namespace Dumbo_Octopus
{
    class Program
    {
        static int[,] P;
        static int X = 0;
        static int N;
        static Queue<Tuple<int,int>> Fro = new Queue<Tuple<int,int>>();

        static void pole()
        {
            int.TryParse(Console.ReadLine(),out N);
            P = new int[N,N];
            for(int i=0; i<N; i++) 
            {
                string s = Console.ReadLine();
                for(int j=0; j<N; j++)
                {
                    ///Console.WriteLine($"{(int)Char.GetNumericValue(s[j])}");
                    P[i,j] = (int)Char.GetNumericValue(s[j]);
                }
            }

        }
        static void projed()
        {
            for(int i=0; i<N; i++) 
            {
                for(int j=0; j<N; j++)
                {
                    P[i,j]++;
                    if (P[i,j]==10)
                    {
                        Tuple<int, int> y =new Tuple<int, int>(i,j);
                        Fro.Enqueue(y);
                    }
                }
            }
        }
        static void blik()
        {
            Tuple<int, int> y;
            while (Fro.Count > 0)
            {
                y = Fro.Dequeue();
                int i = y.Item1;
                int j = y.Item2;

                int di = i-1;
                int hi = i+1;
                int dj = j-1;
                int hj = j+1;

                if (i==0) di = i;
                if (i==N-1) hi = i;
                if (j==0) dj = j;
                if (j==N-1) hj = j;

                for(int k = di;k<=hi;k++)
                {
                    for(int l = dj;l<=hj;l++)
                    {
                        if(k!=i || l!=j)
                        {
                            ///Console.WriteLine("A");
                            P[k,l]++;
                            if (P[k,l]==10)
                            {
                                Tuple<int, int> z =new Tuple<int, int>(k,l);
                                Fro.Enqueue(z);
                            }
                        }
                    }
                }

            }
        }
        static void pocet()
        {
            for(int i=0; i<N; i++) 
            {
                for(int j=0; j<N; j++)
                {
                    if(P[i,j]>9)
                    {
                        P[i,j] = 0;
                        X++;
                    }
                }
            }
        }
        static void tisk()
        {
            for(int i=0; i<N; i++) 
            {
                for(int j=0; j<N; j++)
                {
                    Console.Write(P[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            pole();
            for(int i = 0;i<100;i++)
            {
                projed();
                blik();
                pocet();
                ///tisk();
                ///Console.WriteLine($"{X}");
                ///Console.WriteLine();
                ///Console.ReadLine();
            }
            Console.WriteLine($"{X}");            
        }
    }
}