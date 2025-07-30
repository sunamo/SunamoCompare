namespace SunamoCompare;

public class SunamoComparer
{
    public class Float : ISunamoComparer<float>
    {
        public static Float Instance = new();

        public int Desc(float x, float y)
        {
            return x.CompareTo(y) * -1;
        }

        public int Asc(float x, float y)
        {
            return x.CompareTo(y);
        }
    }

    public class StringLength : ISunamoComparer<string>
    {
        public static StringLength Instance = new();

        public int Desc(string x, string y)
        {
            var a = x.Length;
            var b = y.Length;
            return a.CompareTo(b) * -1;
        }

        public int Asc(string x, string y)
        {
            var a = x.Length;
            var b = y.Length;
            return a.CompareTo(b);
        }
    }

    public class Integer64 : ISunamoComparer<long>
    {
        public static Integer64 Instance = new();

        public int Desc(long x, long y)
        {
            return x.CompareTo(y) * -1;
        }

        public int Asc(long x, long y)
        {
            return x.CompareTo(y);
        }
    }

    public class Integer : ISunamoComparer<int>
    {
        public static Integer Instance = new();

        public int Desc(int x, int y)
        {
            return x.CompareTo(y) * -1;
        }

        public int Asc(int x, int y)
        {
            return x.CompareTo(y);
        }
    }

    public class DT : ISunamoComparer<DateTime>
    {
        public static DT Instance = new();

        // ToList() here must be - sorted still contains reference to original collection
        public int Desc(DateTime x, DateTime y)
        {
            return x.CompareTo(y) * -1;
        }

        public int Asc(DateTime x, DateTime y)
        {
            return x.CompareTo(y);
        }
    }


    public class IListCharLength : ISunamoComparer<IList<char>>
    {
        public static IListCharLength Instance = new();

        public int Desc(IList<char> x, IList<char> y)
        {
            var lx = new List<char>();

            foreach (var item in x) lx.Add(item);

            var ly = new List<char>();
            foreach (var item in y) ly.Add(item);

            var a = lx.Count;
            var b = ly.Count;
            return a.CompareTo(b) * -1;
        }

        public int Asc(IList<char> x, IList<char> y)
        {
            var lx = new List<char>();

            foreach (var item in x) lx.Add(item);

            var ly = new List<char>();
            foreach (var item in y) ly.Add(item);

            var a = lx.Count;
            var b = ly.Count;
            return a.CompareTo(b);
        }
    }


    public class TWithIntSunamoComparer<T> : ISunamoComparer<TWithIntCompare<T>>
    {
        public int Desc(TWithIntCompare<T> x, TWithIntCompare<T> y)
        {
            var a = x.count;
            var b = y.count;
            return a.CompareTo(b) * -1;
        }

        public int Asc(TWithIntCompare<T> x, TWithIntCompare<T> y)
        {
            var a = x.count;
            var b = y.count;
            return a.CompareTo(b);
        }
    }

    public class TWithDtSunamoComparer<T> : ISunamoComparer<ITWithDt<T>>
    {
        public int Desc(ITWithDt<T> x, ITWithDt<T> y)
        {
            var a = x.Dt;
            var b = y.Dt;
            return a.CompareTo(b) * -1;
        }

        public int Asc(ITWithDt<T> x, ITWithDt<T> y)
        {
            var a = x.Dt;
            var b = y.Dt;
            return a.CompareTo(b);
        }
    }
}