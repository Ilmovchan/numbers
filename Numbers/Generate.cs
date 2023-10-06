using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers;

public class Generate
{

    private static Random random = new Random();

    //Simple array
    public static T[] Array<T>(int length)
    {
        T[] arr = new T[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = GetRandomValue<T>();
        }

        return arr;
    }

    //Key-value pairs array
    public static KeyValuePair<TKey, TValue>[] KeyValuePairArray<TKey, TValue>(int length)
    {
        var keyValuePair = new KeyValuePair<TKey, TValue>[length];

        for (int i = 0; i < length; i++)
        {
            TKey key;
            TValue value;

            key = GetRandomValue<TKey>();
            value = GetRandomValue<TValue>();

            keyValuePair[i] = new KeyValuePair<TKey, TValue>(key, value);
        }

        return keyValuePair;
    }

    //Random value
    public static T GetRandomValue<T>()
    {
        Type type = typeof(T);

        if (type == typeof(int))
        {
            return (T)(object)random.Next();
        }

        else if (type == typeof(double))
        {
            return (T)(object)(random.NextDouble());
        }

        else if (type == typeof(string))
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int min = 1;
            int max = 50;

            return (T)(object)new string(Enumerable.Repeat(chars, random.Next(min, max))
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        else if (type == typeof(bool))
        {
            return (T)(object)((random.Next(0, 2) == 1) ? true : false);
        }

        else
        {
            return default(T);
        }
    }
}




        


