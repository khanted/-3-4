using System;
public static class ConvertUtils
{
    // Метод для конвертации строки в нужный тип
    public static T ConvertToType<T>(string input)
    {
        if (typeof(T) == typeof(int))
        {
            return (T)(object)int.Parse(input);
        }
        else if (typeof(T) == typeof(double))
        {
            return (T)(object)double.Parse(input);
        }
        else if (typeof(T) == typeof(bool))
        {
            return (T)(object)bool.Parse(input.ToLower());
        }
        else if (typeof(T) == typeof(string))
        {
            return (T)(object)input;
        }
        else
        {
            throw new InvalidOperationException("Неподдерживаемый тип данных");
        }
    }
}