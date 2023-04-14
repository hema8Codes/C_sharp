

namespace ConsoleApp1
{
    public class A8_loop_array
    {   
        static void Main(string[] args)
        {
            // one Array

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i <n;i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            // twoD array

            int[,] mat = new int[3, 3];

            // input
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            //output or traversal

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
