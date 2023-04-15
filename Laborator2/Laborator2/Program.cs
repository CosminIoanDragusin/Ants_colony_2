using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace Laborator2
{
    class Program
    {
        class KnapsackAlgorithm
        {
            public static int KnapSack(int capacity, int[] weight, int[] value, int itemsCount)
            {
                int[,] K = new int[itemsCount + 1, capacity + 1];

                for (int i = 0; i <= itemsCount; ++i)
                {
                    for (int w = 0; w <= capacity; ++w)
                    {
                        if (i == 0 || w == 0)
                            K[i, w] = 0;
                        else if (weight[i - 1] <= w)
                            K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - weight[i - 1]], K[i - 1, w]);
                        else
                            K[i, w] = K[i - 1, w];

                        //Console.WriteLine(K[i, w]);//+ System.Environment.NewLine);
                    }   
                }
                
                return K[itemsCount, capacity];
            }



            static void Main(string[] args)
            {
                int[] profit = { 1, 2, 4, 5 };
                int[] weight = { 1, 2, 3, 4 };
                int capacitate = 8;
                int nr_de_item = 4;

                int calcul = KnapSack(capacitate, weight, profit, nr_de_item);

                for (int i = 0; i <= nr_de_item; ++i)
                {
                    for (int w = 0; w <= capacitate; ++w)
                    {
                        //Console.WriteLine(K[i, w]);
                    }
                }

               Console.WriteLine(calcul);
            }
        }
    }
}

