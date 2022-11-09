namespace Armadilo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            Console.WriteLine(program.Add(12, 23));
            Console.WriteLine(program.Sum(100));
            
        }

        /// <summary>
        /// add together some numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Add(int a, int b) { 
            return a + b; 
        }
        /// <summary>
        /// add up all numbers from 0 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int Sum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;//
            }
            return sum;
        }
        int[] Sumation(int n)
        {
            int[] sum = new int[n];
            sum[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                sum[i] += sum[i - 1];
            }
            return sum;
        }
    }
}