using System;
using System.Linq;
namespace Задание3_4
{
    public static class AverageCalculator
    {
        public static object CalculateAverage<T>(T[] data)
        {
            Type type = typeof(T);
            if (type == typeof(int))
            {
                return data.Cast<int>().Average();
            }
            else if (type == typeof(double))
            {
                return data.Cast<double>().Average();
            }
            else if (type == typeof(bool))
            {
                // Считаем процент истинных значений
                return "Считаем процент истинных значений " + data.Cast<bool>().Count(b => b) / (double)data.Length * 100 + "%";
            }
            else if (type == typeof(string))
            {
                // Считаем среднюю длину строк
                return data.Cast<string>().Select(s => s.Length).Average();
            }
            else
            {
                throw new NotImplementedException($"Неверный тип значений. Введите снова.");
            }
        }
    }
}