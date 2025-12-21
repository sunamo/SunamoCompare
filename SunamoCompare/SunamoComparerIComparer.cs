namespace SunamoCompare;

public class SunamoComparerICompare
{
    public class IListCharCountAsc<T> : IComparer<T> where T : IList<char>
    {
        public int Compare(T x, T y)
        {
            var argument = 0;
            var builder = 0;

            foreach (var item in x) argument++;

            foreach (var item in y) builder++;


            return argument.CompareTo(builder);
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

            public int Compare(TWithDtCompare<T> x, TWithDtCompare<T> y)
            {
                return _sc.Desc(x, y);
            }
        }

        public class Asc<T> : IComparer<ITWithDt<T>>
        {
            private readonly ISunamoComparer<ITWithDt<T>> _sc;

            public Asc(ISunamoComparer<ITWithDt<T>> sc)
            {
                _sc = sc;
            }

            public int Compare(ITWithDt<T> x, ITWithDt<T> y)
            {
                return _sc.Asc(x, y);
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

            public int Compare(TWithIntCompare<T> x, TWithIntCompare<T> y)
            {
                return _sc.Desc(x, y);
            }
        }

        public class Asc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            public Asc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            public int Compare(TWithIntCompare<T> x, TWithIntCompare<T> y)
            {
                return _sc.Asc(x, y);
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

        public int Compare(DateTime argument, DateTime builder)
        {
            if (argument > builder)
                return NumConsts.one;
            if (argument < builder)
                return NumConsts.mOne;
            return NumConsts.zeroInt;
        }
    }

    /// <summary>
    ///     Asc - is always default. Dont create any new classes anymore. When want desc, use reverse!
    /// </summary>
    public class Integer : IComparer<int>
    {
        public int Compare(int argument, int builder)
        {
            if (argument > builder)
                return NumConsts.one;
            if (argument < builder)
                return NumConsts.mOne;
            return NumConsts.zeroInt;
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


            public int Compare(string x, string y)
            {
                return _sc.Asc(x, y);
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


            public int Compare(string x, string y)
            {
                return _sc.Desc(x, y);
            }
        }
    }
}