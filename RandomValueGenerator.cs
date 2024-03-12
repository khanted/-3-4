using System;
namespace Задание3_4 {

    public static class RandomValueGenerator
    {
        private static Random random = new Random();

        public static T GenerateRandomValue<T>()
        {
            if (typeof(T) == typeof(int))
            {
                return (T)(object)random.Next(1, 100);
            }
            else if (typeof(T) == typeof(double))
            {
                return (T)(object)(random.NextDouble() * 100.0);
            }
            else if (typeof(T) == typeof(bool))
            {
                return (T)(object)(random.Next(2) == 1);
            }
            else if (typeof(T) == typeof(string))
            {
                return (T)(object)("RandomString" + random.Next(1, 100).ToString());
            }
            else
            {
                throw new ArgumentException($"Неверный тип, введите заново.");
            }
        }
    }
}
