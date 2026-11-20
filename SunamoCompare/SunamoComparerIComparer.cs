namespace SunamoCompare;

/// <summary>
/// Represents the sunamo comparer i compare type.
/// </summary>
public class SunamoComparerICompare
{
    /// <summary>
    /// Represents the i list char count asc t type.
    /// </summary>
    public class IListCharCountAsc<T> : IComparer<T> where T : IList<char>
    {
        /// <summary>
        /// Compare.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The compare result.</returns>
        public int Compare(T? firstValue, T? secondValue)
        {
            if (firstValue is null) return secondValue is null ? 0 : -1;
            if (secondValue is null) return 1;

            return firstValue.Count.CompareTo(secondValue.Count);
        }
    }

    /// <summary>
    /// Represents the t with dt comparer type.
    /// </summary>
    public class TWithDtComparer
    {
        /// <summary>
        /// Represents the desc t type.
        /// </summary>
        public class Desc<T> : IComparer<TWithDtCompare<T>>
        {
            private readonly ISunamoComparer<TWithDtCompare<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the desc class.
            /// </summary>
            /// <param name="sc">The sc.</param>
            public Desc(ISunamoComparer<TWithDtCompare<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compare.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <returns>The compare result.</returns>
            public int Compare(TWithDtCompare<T>? firstValue, TWithDtCompare<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Desc(firstValue, secondValue);
            }
        }

        /// <summary>
        /// Represents the asc t type.
        /// </summary>
        public class Asc<T> : IComparer<ITWithDt<T>>
        {
            private readonly ISunamoComparer<ITWithDt<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the asc class.
            /// </summary>
            /// <param name="sc">The sc.</param>
            public Asc(ISunamoComparer<ITWithDt<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compare.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <returns>The compare result.</returns>
            public int Compare(ITWithDt<T>? firstValue, ITWithDt<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    // Usage: result.Sort(new SunamoComparerICompare.TWithIntComparer.Desc<string>(new SunamoComparer.TWithIntSunamoComparer<string>()));
    /// <summary>
    /// Represents the t with int comparer type.
    /// </summary>
    public class TWithIntComparer
    {
        /// <summary>
        /// Represents the desc t type.
        /// </summary>
        public class Desc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the desc class.
            /// </summary>
            /// <param name="sc">The sc.</param>
            public Desc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compare.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <returns>The compare result.</returns>
            public int Compare(TWithIntCompare<T>? firstValue, TWithIntCompare<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Desc(firstValue, secondValue);
            }
        }

        /// <summary>
        /// Represents the asc t type.
        /// </summary>
        public class Asc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            /// <summary>
            /// Initializes a new instance of the asc class.
            /// </summary>
            /// <param name="sc">The sc.</param>
            public Asc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compare.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <returns>The compare result.</returns>
            public int Compare(TWithIntCompare<T>? firstValue, TWithIntCompare<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    // Asc is always default. Don't create any new classes anymore. When you want descending order, use reverse!
    /// <summary>
    /// Represents the DT type.
    /// </summary>
    public class DT : IComparer<DateTime>
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static DT Instance = new();

        private DT()
        {
        }

        /// <summary>
        /// Compare.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The compare result.</returns>
        public int Compare(DateTime firstValue, DateTime secondValue)
        {
            if (firstValue > secondValue)
                return NumConsts.One;
            if (firstValue < secondValue)
                return NumConsts.MinusOne;
            return NumConsts.ZeroInt;
        }
    }

    // Asc is always default. Don't create any new classes anymore. When you want descending order, use reverse!
    /// <summary>
    /// Represents the integer type.
    /// </summary>
    public class Integer : IComparer<int>
    {
        /// <summary>
        /// Compare.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The compare result.</returns>
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
    /// Represents the string length type.
    /// </summary>
    public class StringLength
    {
        /// <summary>
        /// Represents the asc type.
        /// </summary>
        public class Asc : IComparer<string>
        {
            private readonly ISunamoComparer<string> _sc;

            // As parameter you can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength.
            /// <summary>
            /// Asc.
            /// </summary>
            /// <param name="sc">The sc.</param>
            /// <returns>The asc result.</returns>
            public Asc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compare.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <returns>The compare result.</returns>
            public int Compare(string? firstValue, string? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }

        /// <summary>
        /// Represents the desc type.
        /// </summary>
        public class Desc : IComparer<string>
        {
            private readonly ISunamoComparer<string> _sc;

            // As parameter you can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength.
            /// <summary>
            /// Desc.
            /// </summary>
            /// <param name="sc">The sc.</param>
            /// <returns>The desc result.</returns>
            public Desc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }

            /// <summary>
            /// Compare.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <returns>The compare result.</returns>
            public int Compare(string? firstValue, string? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Desc(firstValue, secondValue);
            }
        }
    }
}
