using System;
namespace Задание3_4
{
    public class GenericOneDimensionalArray<T> : BaseArray<T>
    {
        public GenericOneDimensionalArray(int size) : base(size) { }

        public override void Initialize(bool userFill)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (userFill)
                {
                    Console.Write($"Введите элемент {i + 1} типа {typeof(T).Name}: ");
                    string input = Console.ReadLine();
                    data[i] = ConvertUtils.ConvertToType<T>(input);
                }
                else
                {
                    data[i] = RandomValueGenerator.GenerateRandomValue<T>();
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Одномерный массив типа {typeof(T).Name}:");
            foreach (var item in data)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public override object Average()
        {
            return AverageCalculator.CalculateAverage(data);
        }
    }
}