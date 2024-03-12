using System;
using System.Linq;
namespace Задание3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип данных массива:");
            Console.WriteLine("1: int");
            Console.WriteLine("2: double");
            Console.WriteLine("3: bool");
            Console.WriteLine("4: string");
            Console.Write("Вы выбрали:");
            string typeChoice = Console.ReadLine();

            Console.WriteLine("Выберите тип массива:");
            Console.WriteLine("1: Одномерный массив");
            Console.WriteLine("2: Двумерный массив");
            Console.Write("Вы выбрали:");
            string arrayTypeChoice = Console.ReadLine();

            bool userFill = AskUserForFillMethod();

            switch (typeChoice)
            {
                case "1":
                case "int":
                    HandleArrayType<int>(userFill, arrayTypeChoice);
                    break;
                case "2":
                case "double":
                    HandleArrayType<double>(userFill, arrayTypeChoice);
                    break;
                case "3":
                case "bool":
                    HandleArrayType<bool>(userFill, arrayTypeChoice);
                    break;
                case "4":
                case "string":
                    HandleArrayType<string>(userFill, arrayTypeChoice);
                    break;
                default:
                    Console.WriteLine("Incorrect data type choice.");
                    break;
            }
        }

        static void HandleArrayType<T>(bool userFill, string arrayTypeChoice)
        {
            switch (arrayTypeChoice)
            {
                case "1":
                    Console.Write("Введите размер одномерного массива");
                    int size = Convert.ToInt32(Console.ReadLine());
                    var oneDimArray = new GenericOneDimensionalArray<T>(size);
                    oneDimArray.Initialize(userFill);
                    oneDimArray.Print();
                    Console.WriteLine($"Среднее значение: {oneDimArray.Average()}");
                    break;
                case "2":
                    Console.Write("Введите количество строк двумерного массива:");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество столбцов двумерного массива:");
                    int columns = Convert.ToInt32(Console.ReadLine());
                    var twoDimArray = new GenericTwoDimensionalArray<T>(rows, columns);
                    twoDimArray.Initialize(userFill);
                    twoDimArray.Print();
                    Console.WriteLine($"Среднее значение: {twoDimArray.Average()}");
                    break;
                default:
                    Console.WriteLine("Неверный тип массива. Введите снова.");
                    break;
            }
        }

        static bool AskUserForFillMethod()
        {
            Console.WriteLine("Хотите ввести значения вручную? (true/false)");
            string answer = Console.ReadLine();
            return answer?.Trim().ToLower() == "true";
        }
    }
}