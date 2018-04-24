using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НомеL1
{
    public static class Task
    {
        public static void Sum()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }

        public static void BitValue()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите j: ");
            int j = int.Parse(Console.ReadLine());
            if (((n >> j) & 1) == 1)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }

        public static void SetToZero()
        {
            Console.Write("Введите число: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат = {0}", f &= ~0 << 1);
        }

        public static void Math()
        {
            Console.Write("Введите числа: ");
            int[] Mass = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Сумма всех чисел = = {0}", Mass.Sum());
            Console.WriteLine("Минимальное число = {0}", Mass.Min());
            Console.WriteLine("Максимальное = {0}", Mass.Max());
            Console.WriteLine("Количество четных чисел = {0}", Mass.Where(n => n > 0 && (n & 1) != 1).Count());
            Console.WriteLine("Количество не четных чисел = {0}", Mass.Where(x => (x & 1) == 1).Count());
            Console.WriteLine("Произведение не четных чисел = {0}", GetOddNumbers(Mass));

            int GetOddNumbers(int[] iValue)
            {
                int Length = 1;
                foreach (var t in iValue)
                    if (t % 2 > 0)
                        Length *= t;
                return Length;
            }
        }

        public static void TwoMatrix()
        {
            int N = 2;
            int[,] Matrix1 = new int[N, N];
            int[,] Matrix2 = new int[N, N];
            int[,] Matrix3 = new int[N, N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    Matrix1[i, j] = rnd.Next(100);
                    Matrix2[i, j] = rnd.Next(100);
                    Matrix3[i, j] = Matrix1[i, j] + Matrix2[i, j];
                }

            Console.WriteLine("Матрица 1: ");
            GetArray(Matrix1);
            Console.WriteLine("\nМатрица 2: ");
            GetArray(Matrix2);
            Console.WriteLine("\nРезультат: ");
            GetArray(Matrix3);

            void GetArray(int[,] iValue)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                        Console.Write(iValue[i, j] + "\t");
                    Console.WriteLine();
                }
            }
        }
    }
}
