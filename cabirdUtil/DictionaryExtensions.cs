using System;
using System.Collections.Generic;
using System.Text;

namespace cabirdUtil
{
    public static class DictionaryExtensions
    {
        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key) where TValue : class, new()
        {
            if (dict.TryGetValue(key, out TValue value))
            {
                return value;
            }

            TValue newValue = new TValue();
            dict[key] = newValue;
            return newValue;
        }
    }
}
