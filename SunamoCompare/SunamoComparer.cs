namespace SunamoCompare;

public class SunamoComparer
{
    public class Float : ISunamoComparer<float>
    {
        public static Float Instance = new();

        public int Desc(float firstValue, float secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        public int Asc(float firstValue, float secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    public class StringLength : ISunamoComparer<string>
    {
        public static StringLength Instance = new();

        public int Desc(string firstValue, string secondValue)
        {
            var firstLength = firstValue.Length;
            var secondLength = secondValue.Length;
            return firstLength.CompareTo(secondLength) * -1;
        }

        public int Asc(string firstValue, string secondValue)
        {
            var firstLength = firstValue.Length;
            var secondLength = secondValue.Length;
            return firstLength.CompareTo(secondLength);
        }
    }

    public class Integer64 : ISunamoComparer<long>
    {
        public static Integer64 Instance = new();

        public int Desc(long firstValue, long secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        public int Asc(long firstValue, long secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    public class Integer : ISunamoComparer<int>
    {
        public static Integer Instance = new();

        public int Desc(int firstValue, int secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        public int Asc(int firstValue, int secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    public class DT : ISunamoComparer<DateTime>
    {
        public static DT Instance = new();

        // ToList() here must be - sorted still contains reference to original collection
        public int Desc(DateTime firstValue, DateTime secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        public int Asc(DateTime firstValue, DateTime secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }


    public class IListCharLength : ISunamoComparer<IList<char>>
    {
        public static IListCharLength Instance = new();

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


    public class TWithIntSunamoComparer<T> : ISunamoComparer<TWithIntCompare<T>>
    {
        public int Desc(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
        {
            var firstCount = firstValue.Count;
            var secondCount = secondValue.Count;
            return firstCount.CompareTo(secondCount) * -1;
        }

        public int Asc(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
        {
            var firstCount = firstValue.Count;
            var secondCount = secondValue.Count;
            return firstCount.CompareTo(secondCount);
        }
    }

    public class TWithDtSunamoComparer<T> : ISunamoComparer<ITWithDt<T>>
    {
        public int Desc(ITWithDt<T> firstValue, ITWithDt<T> secondValue)
        {
            var firstDateTime = firstValue.Dt;
            var secondDateTime = secondValue.Dt;
            return firstDateTime.CompareTo(secondDateTime) * -1;
        }

        public int Asc(ITWithDt<T> firstValue, ITWithDt<T> secondValue)
        {
            var firstDateTime = firstValue.Dt;
            var secondDateTime = secondValue.Dt;
            return firstDateTime.CompareTo(secondDateTime);
        }
    }
}