using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НомеL1
{
    public class Program
    {
        static void Main(string[] args)
        {
            OptionMenu();
            int selection;
            do
            {
                Console.Write("\nДля выполнения нужного действия введите, соответствующее ему, число(1-для вызова меню): ");
                selection = int.Parse(Console.ReadLine());
                Menu(selection);
            } while (selection != 0);
        }

        static void OptionMenu()
        {
            Console.WriteLine("1 - Для вызова меню.\n2 - Ввести с консоли 2 числа. Вывести их сумму на консоль.\n" +
                "3 - Ввести с консоли 2 числа n и j.Вывести значение i-того бита числа n.\n" +
                "4 - Ввести с консоли число. Обнулить последний бит этого числа.Вывести на консоль.;\n" +
                "5 - Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, " +
                "количество четных чисел, произведение нечетных чисел.\n" +
                "6 - Заполнить 2 матрицы размерности NxN случайными числами. Вывести на консоль" +
                "Сложить 2 матрицы. Вывести результат.\n" +
                "7 - *Заполнить массив длинной N случайными числами. Ввести с консоли число A. " +
                "Вывести Yes, если число А есть в массиве,No - в противном случае.\n" +
                "8 - *Заполнить матрицу NxM случайными числами. Из каждой строки выбрать минимальный элемент," +
                " занести его в массив. Отсортировать полученный массив и вывести его значения в обратном порядке.\n" +
                "9 - *Калькулятор. С консоли вводится левый операнд, операция, правый операнд. Выводится " +
                "результат операции над операндами.Реализовать как минимум 4 операции, обработку ошибок(деление на 0 и др.).\n" +
                "0 - Для выхода.");
        }

        static void Menu(int selection)
        {
            switch (selection)
            {
                case 1:
                    OptionMenu();
                    break;
                case 2:
                    Task.Sum();
                    break;
                case 3:
                    Task.BitValue();
                    break;
                case 4:
                    Task.SetToZero();
                    break;
                case 5:
                    Task.Math();
                    break;
                case 6:
                    Task.TwoMatrix();
                    break;
                case 7:
                    Star.GetNumber();
                    break;
                case 8:
                    Star.Sort();
                    break;
                case 9:
                    Star.Calculator();
                    break;
                case 0:
                    break;
            }
        }
    }
}
