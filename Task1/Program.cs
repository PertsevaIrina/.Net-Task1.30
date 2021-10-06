using System;

namespace Task1
{
    class Program
    {

        static void Sort(int[][] matrix)
        {
            int[] temp;
            for (int i = matrix.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {

                    if (matrix[j][0] > matrix[j + 1][0])
                    {
                        temp = matrix[j];
                        matrix[j] = matrix[j + 1];
                        matrix[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var matrix = new int[n][];
            var random = new Random();

            Console.WriteLine("Исходная матрица");
            for (var i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
                for (var j = 0; j < n; j++)
                {
                    matrix[i][j] = random.Next(0, 10);
                    Console.Write(matrix[i][j] + " ");

                }
                Console.WriteLine();

            }

            Sort(matrix);
            Console.WriteLine("Ответ:");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();

            }



        }
    }
}

