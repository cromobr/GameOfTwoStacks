using System;

namespace GameOfTwoStacks
{
    class GameOfTwoStacks
    {
        static int twoStacks(int x, int[] a, int[] b)
        {
            int countA = 0;
            int somattor = 0;
            int somattorB = 0;
            int[] somattorA = new int[a.Length + 1];
            int result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                somattorA[i + 1] = somattorA[i] + a[i];
                somattor += a[i];

                if (somattor <= x)
                {
                    result = i + 1;
                }
                else
                {
                    countA = result = i;
                    break;
                }

            }
            countA = result;
            somattor = 0;
            for (int i = 0; i < b.Length; i++)
            {
                somattorB += b[i];
                somattor = somattorA[countA] + somattorB;

                if (somattor <= x)
                {
                    result = verifyCountA(result, countA, i);
                }
                else countA--;

                if (somattorB <= x)
                {
                    result = verifyResult(result, i);
                }
                else break;
                somattor = 0;
            }
            return result;
        }

        static int verifyResult(int result, int positon)
        {
           return result > positon + 1 ? result : positon + 1;
        }

        static int verifyCountA(int result, int countA, int position)
        {
            return result > countA + position + 1 ? result : countA + position + 1;
        }

        static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());

            for (int gItr = 0; gItr < g; gItr++)
            {
                Console.WriteLine(readAndProcessInput());
            }
            Console.Read();
        }

        static int readAndProcessInput()
        {
            string[] nmx = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(nmx[2]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
            return twoStacks(x, a, b);
        }
    }
}
