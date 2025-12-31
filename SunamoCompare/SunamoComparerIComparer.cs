namespace SunamoCompare;

public class SunamoComparerICompare
{
    public class IListCharCountAsc<T> : IComparer<T> where T : IList<char>
    {
        public int Compare(T firstValue, T secondValue)
        {
            var firstCount = 0;
            var secondCount = 0;

            foreach (var item in firstValue) firstCount++;

            foreach (var item in secondValue) secondCount++;


            return firstCount.CompareTo(secondCount);
        }
    }

    public class TWithDtComparer
    {
        public class Desc<T> : IComparer<TWithDtCompare<T>>
        {
            private readonly ISunamoComparer<TWithDtCompare<T>> _sc;

            public Desc(ISunamoComparer<TWithDtCompare<T>> sc)
            {
                _sc = sc;
            }

            public int Compare(TWithDtCompare<T> firstValue, TWithDtCompare<T> secondValue)
            {
                return _sc.Desc(firstValue, secondValue);
            }
        }

        public class Asc<T> : IComparer<ITWithDt<T>>
        {
            private readonly ISunamoComparer<ITWithDt<T>> _sc;

            public Asc(ISunamoComparer<ITWithDt<T>> sc)
            {
                _sc = sc;
            }

            public int Compare(ITWithDt<T> firstValue, ITWithDt<T> secondValue)
            {
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    /// <summary>
    ///     Usage:vr.Sort(new SunamoComparerICompare.TWithIntComparer.Desc
    ///     <string>(new SunamoComparer.TWithIntSunamoComparer<string>()));
    /// </summary>
    public class TWithIntComparer
    {
        public class Desc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            public Desc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            public int Compare(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
            {
                return _sc.Desc(firstValue, secondValue);
            }
        }

        public class Asc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            public Asc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            public int Compare(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
            {
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    /// <summary>
    ///     Asc - is always default. Dont create any new classes anymore. When want desc, use reverse!
    /// </summary>
    public class DT : IComparer<DateTime>
    {
        public static DT Instance = new();

        private DT()
        {
        }

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
    ///     Asc - is always default. Dont create any new classes anymore. When want desc, use reverse!
    /// </summary>
    public class Integer : IComparer<int>
    {
        public int Compare(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
                return NumConsts.One;
            if (firstValue < secondValue)
                return NumConsts.MinusOne;
            return NumConsts.ZeroInt;
        }
    }

    public class StringLength
    {
        public class Asc : IComparer<string>
        {
            private readonly ISunamoComparer<string> _sc;

            /// <summary>
            ///     As parameter I can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength
            /// </summary>
            /// <param name="sc"></param>
            public Asc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }


            public int Compare(string firstValue, string secondValue)
            {
                return _sc.Asc(firstValue, secondValue);
            }
        }

        public class Desc : IComparer<string>
        {
            private readonly ISunamoComparer<string> _sc;

            /// <summary>
            ///     As parameter I can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength
            /// </summary>
            /// <param name="sc"></param>
            public Desc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }


            public int Compare(string firstValue, string secondValue)
            {
                return _sc.Desc(firstValue, secondValue);
            }
        }
    }
}