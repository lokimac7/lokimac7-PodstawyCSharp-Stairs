using System;

namespace Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stairs st = new Stairs();
            Console.WriteLine(st.ClimbStairs(1));
            Console.WriteLine(st.ClimbStairs(2));
            Console.WriteLine(st.ClimbStairs(3));
            Console.WriteLine(st.ClimbStairs(4));
            Console.WriteLine(st.ClimbStairs(5));
            Console.WriteLine(st.ClimbStairs(6));
            Console.WriteLine(st.ClimbStairs(7));
            Console.WriteLine(st.ClimbStairs(8));
            Console.WriteLine(st.ClimbStairs(9));
            Console.WriteLine(st.ClimbStairs(10));
            Console.WriteLine(st.ClimbStairsRecur(1));
            Console.WriteLine(st.ClimbStairsRecur(2));
            Console.WriteLine(st.ClimbStairsRecur(3));
            Console.WriteLine(st.ClimbStairsRecur(4));
            Console.WriteLine(st.ClimbStairsRecur(5));
            Console.WriteLine(st.ClimbStairsRecur(6));
            Console.WriteLine(st.ClimbStairsRecur(7));
            Console.WriteLine(st.ClimbStairsRecur(8));
            Console.WriteLine(st.ClimbStairsRecur(9));
            Console.WriteLine(st.ClimbStairsRecur(10));
            Console.ReadKey();
        }

        public class Stairs
        {
            //rekurencyjnie
            public int ClimbStairsRecur(int n)
            {
                if (n == 1)
                    return 1;
                else if (n == 2)
                    return 2;
                else
                    return ClimbStairs(n - 1) + ClimbStairs(n - 2);         
            }
            //nierekurencyjnie
            public int ClimbStairs(int n)
            {
                if (n == 1)
                    return 1;
                else if (n == 2)
                    return 2;

                var previous = 1;
                var previous2 = 2;
                int fibDigit = 3;

                for (int i = 3; i <=n ; i++)
                {
                    fibDigit = previous + previous2;
                    previous = previous2;
                    previous2 = fibDigit;
                }

                return fibDigit;
            }
        }
    }
}
