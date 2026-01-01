namespace SunamoCompare;

/// <summary>
/// Contains IComparer implementations for various data types.
/// </summary>
public class SunamoComparerICompare
{
    /// <summary>
    /// Comparer for IList&lt;char&gt; based on count in ascending order.
    /// </summary>
    /// <typeparam name="T">The type that implements IList&lt;char&gt;.</typeparam>
    public class IListCharCountAsc<T> : IComparer<T> where T : IList<char>
    {
        /// <summary>
        /// Compares two character lists by count.
        /// </summary>
        /// <param name="firstValue">The first list to compare.</param>
        /// <param name="secondValue">The second list to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Compare(T? firstValue, T? secondValue)
        {
            if (firstValue == null) return secondValue == null ? 0 : -1;
            if (secondValue == null) return 1;

            var firstCount = 0;
            var secondCount = 0;

            foreach (var item in firstValue) firstCount++;

            foreach (var item in secondValue) secondCount++;


            return firstCount.CompareTo(secondCount);
        }
    }

    /// <summary>
    /// Contains comparers for TWithDtCompare objects.
    /// </summary>
    public class TWithDtComparer
    {
        /// <summary>
        /// Comparer for TWithDtCompare in descending order.
        /// </summary>
        /// <typeparam name="T">The type of the value in TWithDtCompare.</typeparam>
        public class Desc<T> : IComparer<TWithDtCompare<T>>
        {
            private readonly ISunamoComparer<TWithDtCompare<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the Desc comparer.
            /// </summary>
            /// <param name="sc">The comparer to use for comparison.</param>
            public Desc(ISunamoComparer<TWithDtCompare<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compares two TWithDtCompare objects.
            /// </summary>
            /// <param name="firstValue">The first object to compare.</param>
            /// <param name="secondValue">The second object to compare.</param>
            /// <returns>A comparison result for descending order.</returns>
            public int Compare(TWithDtCompare<T>? firstValue, TWithDtCompare<T>? secondValue)
            {
                if (firstValue == null) return secondValue == null ? 0 : -1;
                if (secondValue == null) return 1;
                return _sc.Desc(firstValue, secondValue);
            }
        }

        /// <summary>
        /// Comparer for ITWithDt in ascending order.
        /// </summary>
        /// <typeparam name="T">The type of the value in ITWithDt.</typeparam>
        public class Asc<T> : IComparer<ITWithDt<T>>
        {
            private readonly ISunamoComparer<ITWithDt<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the Asc comparer.
            /// </summary>
            /// <param name="sc">The comparer to use for comparison.</param>
            public Asc(ISunamoComparer<ITWithDt<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compares two ITWithDt objects.
            /// </summary>
            /// <param name="firstValue">The first object to compare.</param>
            /// <param name="secondValue">The second object to compare.</param>
            /// <returns>A comparison result for ascending order.</returns>
            public int Compare(ITWithDt<T>? firstValue, ITWithDt<T>? secondValue)
            {
                if (firstValue == null) return secondValue == null ? 0 : -1;
                if (secondValue == null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    /// <summary>
    /// Contains comparers for TWithIntCompare objects.
    /// Usage: result.Sort(new SunamoComparerICompare.TWithIntComparer.Desc&lt;string&gt;(new SunamoComparer.TWithIntSunamoComparer&lt;string&gt;()));
    /// </summary>
    public class TWithIntComparer
    {
        /// <summary>
        /// Comparer for TWithIntCompare in descending order.
        /// </summary>
        /// <typeparam name="T">The type of the value in TWithIntCompare.</typeparam>
        public class Desc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the Desc comparer.
            /// </summary>
            /// <param name="sc">The comparer to use for comparison.</param>
            public Desc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compares two TWithIntCompare objects.
            /// </summary>
            /// <param name="firstValue">The first object to compare.</param>
            /// <param name="secondValue">The second object to compare.</param>
            /// <returns>A comparison result for descending order.</returns>
            public int Compare(TWithIntCompare<T>? firstValue, TWithIntCompare<T>? secondValue)
            {
                if (firstValue == null) return secondValue == null ? 0 : -1;
                if (secondValue == null) return 1;
                return _sc.Desc(firstValue, secondValue);
            }
        }

        /// <summary>
        /// Comparer for TWithIntCompare in ascending order.
        /// </summary>
        /// <typeparam name="T">The type of the value in TWithIntCompare.</typeparam>
        public class Asc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the Asc comparer.
            /// </summary>
            /// <param name="sc">The comparer to use for comparison.</param>
            public Asc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compares two TWithIntCompare objects.
            /// </summary>
            /// <param name="firstValue">The first object to compare.</param>
            /// <param name="secondValue">The second object to compare.</param>
            /// <returns>A comparison result for ascending order.</returns>
            public int Compare(TWithIntCompare<T>? firstValue, TWithIntCompare<T>? secondValue)
            {
                if (firstValue == null) return secondValue == null ? 0 : -1;
                if (secondValue == null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    /// <summary>
    /// Comparer for DateTime values in ascending order (default).
    /// Note: Asc is always default. Don't create any new classes anymore. When you want descending order, use reverse!
    /// </summary>
    public class DT : IComparer<DateTime>
    {
        /// <summary>
        /// Singleton instance of the DT comparer.
        /// </summary>
        public static DT Instance = new();

        private DT()
        {
        }

        /// <summary>
        /// Compares two DateTime values.
        /// </summary>
        /// <param name="firstValue">The first DateTime to compare.</param>
        /// <param name="secondValue">The second DateTime to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Compare(DateTime firstValue, DateTime secondValue)
        {
            if (firstValue > secondValue)
                return NumConsts.One;
            if (firstValue < secondValue)
                return NumConsts.MinusOne;
            return NumConsts.ZeroInt;
        }
    }

    /// <summary>
    /// Comparer for integer values in ascending order (default).
    /// Note: Asc is always default. Don't create any new classes anymore. When you want descending order, use reverse!
    /// </summary>
    public class Integer : IComparer<int>
    {
        /// <summary>
        /// Compares two integer values.
        /// </summary>
        /// <param name="firstValue">The first integer to compare.</param>
        /// <param name="secondValue">The second integer to compare.</param>
        /// <returns>A comparison result for ascending order.</returns>
        public int Compare(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
                return NumConsts.One;
            if (firstValue < secondValue)
                return NumConsts.MinusOne;
            return NumConsts.ZeroInt;
        }
    }

    /// <summary>
    /// Contains comparers for strings based on their length.
    /// </summary>
    public class StringLength
    {
        /// <summary>
        /// Comparer for strings by length in ascending order.
        /// </summary>
        public class Asc : IComparer<string>
        {
            private readonly ISunamoComparer<string> _sc;

            /// <summary>
            /// Initializes a new instance of the Asc comparer.
            /// As parameter you can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength.
            /// </summary>
            /// <param name="sc">The comparer to use for comparison.</param>
            public Asc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compares two strings by length.
            /// </summary>
            /// <param name="firstValue">The first string to compare.</param>
            /// <param name="secondValue">The second string to compare.</param>
            /// <returns>A comparison result for ascending order.</returns>
            public int Compare(string? firstValue, string? secondValue)
            {
                if (firstValue == null) return secondValue == null ? 0 : -1;
                if (secondValue == null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }

        /// <summary>
        /// Comparer for strings by length in descending order.
        /// </summary>
        public class Desc : IComparer<string>
        {
            private readonly ISunamoComparer<string> _sc;

            /// <summary>
            /// Initializes a new instance of the Desc comparer.
            /// As parameter you can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength.
            /// </summary>
            /// <param name="sc">The comparer to use for comparison.</param>
            public Desc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compares two strings by length.
            /// </summary>
            /// <param name="firstValue">The first string to compare.</param>
            /// <param name="secondValue">The second string to compare.</param>
            /// <returns>A comparison result for descending order.</returns>
            public int Compare(string? firstValue, string? secondValue)
            {
                if (firstValue == null) return secondValue == null ? 0 : -1;
                if (secondValue == null) return 1;
                return _sc.Desc(firstValue, secondValue);
            }
        }
    }
}
