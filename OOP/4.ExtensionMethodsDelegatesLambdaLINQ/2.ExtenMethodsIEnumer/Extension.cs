using System;
using System.Collections.Generic;

namespace _2.ExtenMethodsIEnumer
{
    public static class Extension
    {
        public static T Sum<T>(this IEnumerable<T> input) where T: IComparable
        {
            dynamic sum = 0;
            foreach (var item in input)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic product = 1;
            foreach (var item in input)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic min = int.MaxValue;
            foreach (var item in input)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> input)
        {
            dynamic max = int.MinValue;
            foreach (var item in input)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic sum = 0;
            dynamic number = 0;

            foreach (var item in input)
            {
                sum += item;
                number++;
            }

            double result = sum / (double)number;
            return result;
        }
    }
}
