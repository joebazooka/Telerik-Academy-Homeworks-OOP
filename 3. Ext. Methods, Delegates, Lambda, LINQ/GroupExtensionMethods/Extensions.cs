using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupExtensionMethods
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> values)
        {
            dynamic sum = 0;

            foreach (T item in values)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> values)
        {
            dynamic product = 1;

            foreach (T item in values)
            {
                product *= (dynamic)item;
                if (product == 0)
                {
                    break;
                }
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> values) where T : IComparable
        {
            T min = values.First();

            foreach (T item in values)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> values) where T : IComparable
        {
            T max = values.First();

            foreach (T item in values)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> values)
        {
            dynamic sum = 0;
            dynamic count = 0;

            foreach (T item in values)
            {
                sum += item;
                count++;
            }

            return sum / count;
        }
    }
}
