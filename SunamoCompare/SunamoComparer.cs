// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

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
            var argument = x.Length;
            var builder = y.Length;
            return argument.CompareTo(builder) * -1;
        }

        public int Asc(string x, string y)
        {
            var argument = x.Length;
            var builder = y.Length;
            return argument.CompareTo(builder);
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

            var argument = lx.Count;
            var builder = ly.Count;
            return argument.CompareTo(builder) * -1;
        }

        public int Asc(IList<char> x, IList<char> y)
        {
            var lx = new List<char>();

            foreach (var item in x) lx.Add(item);

            var ly = new List<char>();
            foreach (var item in y) ly.Add(item);

            var argument = lx.Count;
            var builder = ly.Count;
            return argument.CompareTo(builder);
        }
    }


    public class TWithIntSunamoComparer<T> : ISunamoComparer<TWithIntCompare<T>>
    {
        public int Desc(TWithIntCompare<T> x, TWithIntCompare<T> y)
        {
            var argument = x.count;
            var builder = y.count;
            return argument.CompareTo(builder) * -1;
        }

        public int Asc(TWithIntCompare<T> x, TWithIntCompare<T> y)
        {
            var argument = x.count;
            var builder = y.count;
            return argument.CompareTo(builder);
        }
    }

    public class TWithDtSunamoComparer<T> : ISunamoComparer<ITWithDt<T>>
    {
        public int Desc(ITWithDt<T> x, ITWithDt<T> y)
        {
            var argument = x.Dt;
            var builder = y.Dt;
            return argument.CompareTo(builder) * -1;
        }

        public int Asc(ITWithDt<T> x, ITWithDt<T> y)
        {
            var argument = x.Dt;
            var builder = y.Dt;
            return argument.CompareTo(builder);
        }
    }
}