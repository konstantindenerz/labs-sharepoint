using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Heroes.Core.Utility
{
    public static class DictionaryExtensions
    {
        public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> target, IDictionary<TKey, TValue> source)
        {
            foreach (var element in source)
            {
                target[element.Key] = element.Value;
            }
        }

    }
}
