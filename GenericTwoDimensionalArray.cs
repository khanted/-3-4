
using System;
using System.Linq;
namespace Задание3_4
{
    public class GenericTwoDimensionalArray<T> : BaseArray<T>
    {
        private T[,] array;

        public GenericTwoDimensionalArray(int rows, int columns) : base(rows * columns)
        {
            array = new T[rows, columns];
        }

        public override void Initialize(bool userFill)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (userFill)
                    {
                        Console.Write($"Введите элемент [{i}, {j}] типа {typeof(T).Name}: ");
                        string input = Console.ReadLine();
                        array[i, j] = ConvertUtils.ConvertToType<T>(input);
                    }
                    else
                    {
                        array[i, j] = RandomValueGenerator.GenerateRandomValue<T>();
                    }
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Двумерный массив типа {typeof(T).Name}:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        
        public override object Average()
        {
            return AverageCalculator.CalculateAverage(array.Cast<T>().ToArray());
        }
    }
}