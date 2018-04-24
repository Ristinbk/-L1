using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НомеL1
{
    public static class Star
    {
        public static void GetNumber()
        {
            const int n = 10;
            const int MaxElemVal = 20;
            int[] Mass = new int[n];
            Mass = Enumerable.Range(0, n).Select(s => new Random(s).Next(MaxElemVal)).ToArray();
            Console.Write("Введите число: ");
            int A = int.Parse(Console.ReadLine());
            int index = System.Array.IndexOf(Mass, A);
            if (index > 0)
                Console.WriteLine("Yes!");
            else
                Console.WriteLine("No!");
            Console.WriteLine("Массив: {0}", string.Join(" ", Mass));
        }

        public static void Sort()
        {
            int N = 4, M = 6;
            int[,] Matrix = new int[N, M];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    Matrix[i, j] = rnd.Next(100);
            Console.WriteLine("Матрица:");
            GetArray(Matrix);
            GetArrayMin(Matrix);

            void GetArrayMin(int[,] iValue)
            {
                int min = Matrix[0, 0];

                int[] Arr = new int[N];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                        if (min > Matrix[i, j])
                            min = Matrix[i, j];
                    Arr[i] = min;
                    min = Matrix[1, 0];
                }
                Array.Sort(Arr);
                Console.WriteLine("Результат: {0}", string.Join("\t", Arr.Reverse()));
            }

            void GetArray(int[,] iValue)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                        Console.Write(iValue[i, j] + "\t");
                    Console.WriteLine();
                }
            }
        }

        public static void Calculator()
        {
            char again = 'Y';
            while (again == 'Y')
            {
                double a, b, total;
                char oper;
                try
                {
                    Console.Write("Введите первое число: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите оператор: ");
                    oper = Convert.ToChar(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    switch (oper)
                    {
                        case '+':
                            total = a + b;
                            Console.WriteLine(a + " + " + b + " = " + total);
                            break;
                        case '-':
                            total = a - b;
                            Console.WriteLine(a + " - " + b + " = " + total);
                            break;
                        case '*':
                            total = a * b;
                            Console.WriteLine(a + " * " + b + " = " + total);
                            break;
                        case '/':
                            if (b != 0)
                            {
                                total = a / b;
                                Console.WriteLine(a + " / " + b + " = " + total);
                            }
                            else
                                Console.WriteLine("Sub-zero is coming soon!");
                            break;
                        default:
                            Console.WriteLine("Неизвестная операция!");
                            break;
                    }
                    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (Y/N)");
                    again = Convert.ToChar(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ошибка! Попробуйте сначала.");
                }
            }
        }
    }
}
