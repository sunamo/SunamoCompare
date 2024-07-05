namespace SunamoCompare;

public class SunamoComparerICompare
{
    public class IListCharCountAsc<T> : IComparer<T> where T : IList<char>
    {
        public int Compare(T x, T y)
        {
            int a = 0;
            int b = 0;

            foreach (var item in x)
            {
                a++;
            }

            foreach (var item in y)
            {
                b++;
            }


            return a.CompareTo(b);
        }
    }

    public class TWithDtComparer
    {
        public class Desc<T> : IComparer<TWithDtCompare<T>>
        {
            private ISunamoComparer<TWithDtCompare<T>> _sc = null;

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
            private ISunamoComparer<ITWithDt<T>> _sc = null;

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
    /// Usage:vr.Sort(new SunamoComparerICompare.TWithIntComparer.Desc<string>(new SunamoComparer.TWithIntSunamoComparer<string>()));
    /// </summary>
    public class TWithIntComparer
    {
        public class Desc<T> : IComparer<TWithIntCompare<T>>
        {
            private ISunamoComparer<TWithIntCompare<T>> _sc = null;

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
            private ISunamoComparer<TWithIntCompare<T>> _sc = null;

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
    /// Asc - is always default. Dont create any new classes anymore. When want desc, use reverse!
    /// </summary>
    public class DT : IComparer<DateTime>
    {
        public static DT Instance = new DT();

        private DT()
        {

        }

        public int Compare(DateTime a, DateTime b)
        {
            if (a > b)
            {
                return NumConsts.one;
            }
            else if (a < b)
            {
                return NumConsts.mOne;
            }
            else
            {
                return NumConsts.zeroInt;
            }
        }
    }

    /// <summary>
    /// Asc - is always default. Dont create any new classes anymore. When want desc, use reverse!
    /// </summary>
    public class Integer : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            if (a > b)
            {
                return NumConsts.one;
            }
            else if (a < b)
            {
                return NumConsts.mOne;
            }
            else
            {
                return NumConsts.zeroInt;
            }
        }
    }

    public class StringLength
    {
        public class Asc : IComparer<string>
        {
            private ISunamoComparer<string> _sc = null;

            /// <summary>
            /// As parameter I can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength
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
            private ISunamoComparer<string> _sc = null;

            /// <summary>
            /// As parameter I can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength
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
