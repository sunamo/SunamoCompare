namespace SunamoCompare;

public class SunamoComparerICompare
{
    public class IListCharCountAsc<T> : IComparer<T> where T : IList<char>
    {
        public int Compare(T? firstValue, T? secondValue)
        {
            if (firstValue is null) return secondValue is null ? 0 : -1;
            if (secondValue is null) return 1;

            return firstValue.Count.CompareTo(secondValue.Count);
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

            public int Compare(TWithDtCompare<T>? firstValue, TWithDtCompare<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
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

            public int Compare(ITWithDt<T>? firstValue, ITWithDt<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    // Usage: result.Sort(new SunamoComparerICompare.TWithIntComparer.Desc<string>(new SunamoComparer.TWithIntSunamoComparer<string>()));
    public class TWithIntComparer
    {
        public class Desc<T> : IComparer<TWithIntCompare<T>>
        {
            private readonly ISunamoComparer<TWithIntCompare<T>> _sc;

            public Desc(ISunamoComparer<TWithIntCompare<T>> sc)
            {
                _sc = sc;
            }

            public int Compare(TWithIntCompare<T>? firstValue, TWithIntCompare<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
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

            public int Compare(TWithIntCompare<T>? firstValue, TWithIntCompare<T>? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }
    }

    // Asc is always default. Don't create any new classes anymore. When you want descending order, use reverse!
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

    // Asc is always default. Don't create any new classes anymore. When you want descending order, use reverse!
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

            // As parameter you can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength.
            public Asc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }

            public int Compare(string? firstValue, string? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Asc(firstValue, secondValue);
            }
        }

        public class Desc : IComparer<string>
        {
            private readonly ISunamoComparer<string> _sc;

            // As parameter you can insert SunamoComparer.IListCharLength or SunamoComparer.StringLength.
            public Desc(ISunamoComparer<string> sc)
            {
                _sc = sc;
            }

            public int Compare(string? firstValue, string? secondValue)
            {
                if (firstValue is null) return secondValue is null ? 0 : -1;
                if (secondValue is null) return 1;
                return _sc.Desc(firstValue, secondValue);
            }
        }
    }
}
