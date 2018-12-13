using System;

namespace GameOfTwoStacks
{
    public class GameOfTwoStacks
    {
        public static int twoStacks(int x, int[] a, int[] b)
        {
            
            int[] sumStackA = new int[a.Length + 1];
            int sumStackB = 0;
            int sumTotalStacks = 0;
            int countA = 0;
            int result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sumStackA[i + 1] = sumStackA[i] + a[i];
                sumTotalStacks += a[i];

                if (sumTotalStacks <= x)
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
            sumTotalStacks = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sumStackB += b[i];
                sumTotalStacks = sumStackA[countA] + sumStackB;

                if (sumTotalStacks <= x)
                {
                    result = verifyCountA(result, countA, i);
                }
                else countA--;

                if (sumStackB <= x)
                {
                    result = verifyResult(result, i);
                }
                else break;
                sumTotalStacks = 0;
            }
            return result;
        }

        public static int verifyResult(int result, int positon)
        {
            if (result > positon + 1)
            {
                return result;
            }
            return positon + 1;
        }

        public static int verifyCountA(int result, int countA, int position)
        {
            if (result > countA + position + 1)
            {
                return result;
            }
                return countA + position + 1;
                       
        }

        public static int readAndProcessInput()
        {
            string[] nmx = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(nmx[2]);
            int[] a = convertInputToArray(Console.ReadLine());
            int[] b = convertInputToArray(Console.ReadLine());
            return twoStacks(x, a, b);
        }

        public static int[] convertInputToArray(string input)
        {
            return Array.ConvertAll(input.Split(' '), aTemp => Convert.ToInt32(aTemp));
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
    }
}
