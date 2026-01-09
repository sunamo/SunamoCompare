// variables names: ok
namespace SunamoCompare;

/// <summary>
/// Contains comparer implementations for various data types.
/// </summary>
public class SunamoComparer
{
    /// <summary>
    /// Comparer for float values.
    /// </summary>
    public class Float : ISunamoComparer<float>
    {
        /// <summary>
        /// Singleton instance of the Float comparer.
        /// </summary>
        public static Float Instance = new();

        /// <summary>
        /// Compares two float values for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first value to compare.</param>
        /// <param name="secondValue">The second value to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(float firstValue, float secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Compares two float values for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first value to compare.</param>
        /// <param name="secondValue">The second value to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(float firstValue, float secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Comparer for strings based on their length.
    /// </summary>
    public class StringLength : ISunamoComparer<string>
    {
        /// <summary>
        /// Singleton instance of the StringLength comparer.
        /// </summary>
        public static StringLength Instance = new();

        /// <summary>
        /// Compares two strings by length for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first string to compare.</param>
        /// <param name="secondValue">The second string to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(string firstValue, string secondValue)
        {
            var firstLength = firstValue.Length;
            var secondLength = secondValue.Length;
            return firstLength.CompareTo(secondLength) * -1;
        }

        /// <summary>
        /// Compares two strings by length for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first string to compare.</param>
        /// <param name="secondValue">The second string to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(string firstValue, string secondValue)
        {
            var firstLength = firstValue.Length;
            var secondLength = secondValue.Length;
            return firstLength.CompareTo(secondLength);
        }
    }

    /// <summary>
    /// Comparer for long (Int64) values.
    /// </summary>
    public class Integer64 : ISunamoComparer<long>
    {
        /// <summary>
        /// Singleton instance of the Integer64 comparer.
        /// </summary>
        public static Integer64 Instance = new();

        /// <summary>
        /// Compares two long values for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first value to compare.</param>
        /// <param name="secondValue">The second value to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(long firstValue, long secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Compares two long values for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first value to compare.</param>
        /// <param name="secondValue">The second value to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(long firstValue, long secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Comparer for integer values.
    /// </summary>
    public class Integer : ISunamoComparer<int>
    {
        /// <summary>
        /// Singleton instance of the Integer comparer.
        /// </summary>
        public static Integer Instance = new();

        /// <summary>
        /// Compares two integer values for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first value to compare.</param>
        /// <param name="secondValue">The second value to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(int firstValue, int secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Compares two integer values for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first value to compare.</param>
        /// <param name="secondValue">The second value to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(int firstValue, int secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Comparer for DateTime values.
    /// </summary>
    public class DT : ISunamoComparer<DateTime>
    {
        /// <summary>
        /// Singleton instance of the DT comparer.
        /// </summary>
        public static DT Instance = new();

        /// <summary>
        /// Compares two DateTime values for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first DateTime to compare.</param>
        /// <param name="secondValue">The second DateTime to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(DateTime firstValue, DateTime secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Compares two DateTime values for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first DateTime to compare.</param>
        /// <param name="secondValue">The second DateTime to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(DateTime firstValue, DateTime secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Comparer for IList&lt;char&gt; based on their length.
    /// </summary>
    public class IListCharLength : ISunamoComparer<IList<char>>
    {
        /// <summary>
        /// Singleton instance of the IListCharLength comparer.
        /// </summary>
        public static IListCharLength Instance = new();

        /// <summary>
        /// Compares two character lists by length for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first list to compare.</param>
        /// <param name="secondValue">The second list to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(IList<char> firstValue, IList<char> secondValue)
        {
            var firstList = new List<char>();

            foreach (var item in firstValue) firstList.Add(item);

            var secondList = new List<char>();
            foreach (var item in secondValue) secondList.Add(item);

            var firstCount = firstList.Count;
            var secondCount = secondList.Count;
            return firstCount.CompareTo(secondCount) * -1;
        }

        /// <summary>
        /// Compares two character lists by length for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first list to compare.</param>
        /// <param name="secondValue">The second list to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(IList<char> firstValue, IList<char> secondValue)
        {
            var firstList = new List<char>();

            foreach (var item in firstValue) firstList.Add(item);

            var secondList = new List<char>();
            foreach (var item in secondValue) secondList.Add(item);

            var firstCount = firstList.Count;
            var secondCount = secondList.Count;
            return firstCount.CompareTo(secondCount);
        }
    }

    /// <summary>
    /// Comparer for TWithIntCompare objects based on their Count property.
    /// </summary>
    /// <typeparam name="T">The type of the value in TWithIntCompare.</typeparam>
    public class TWithIntSunamoComparer<T> : ISunamoComparer<TWithIntCompare<T>>
    {
        /// <summary>
        /// Compares two TWithIntCompare objects by Count for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first object to compare.</param>
        /// <param name="secondValue">The second object to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
        {
            var firstCount = firstValue.Count;
            var secondCount = secondValue.Count;
            return firstCount.CompareTo(secondCount) * -1;
        }

        /// <summary>
        /// Compares two TWithIntCompare objects by Count for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first object to compare.</param>
        /// <param name="secondValue">The second object to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
        {
            var firstCount = firstValue.Count;
            var secondCount = secondValue.Count;
            return firstCount.CompareTo(secondCount);
        }
    }

    /// <summary>
    /// Comparer for ITWithDt objects based on their DateTime property.
    /// </summary>
    /// <typeparam name="T">The type of the value in ITWithDt.</typeparam>
    public class TWithDtSunamoComparer<T> : ISunamoComparer<ITWithDt<T>>
    {
        /// <summary>
        /// Compares two ITWithDt objects by DateTime for descending order sorting.
        /// </summary>
        /// <param name="firstValue">The first object to compare.</param>
        /// <param name="secondValue">The second object to compare.</param>
        /// <returns>A comparison result for descending order.</returns>
        public int Desc(ITWithDt<T> firstValue, ITWithDt<T> secondValue)
        {
            var firstDateTime = firstValue.Dt;
            var secondDateTime = secondValue.Dt;
            return firstDateTime.CompareTo(secondDateTime) * -1;
        }

        /// <summary>
        /// Compares two ITWithDt objects by DateTime for ascending order sorting.
        /// </summary>
        /// <param name="firstValue">The first object to compare.</param>
        /// <param name="secondValue">The second object to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Asc(ITWithDt<T> firstValue, ITWithDt<T> secondValue)
        {
            var firstDateTime = firstValue.Dt;
            var secondDateTime = secondValue.Dt;
            return firstDateTime.CompareTo(secondDateTime);
        }
    }
}