namespace SunamoCompare;

/// <summary>
/// Represents the sunamo comparer type.
/// </summary>
public class SunamoComparer
{
    /// <summary>
    /// Represents the float type.
    /// </summary>
    public class Float : ISunamoComparer<float>
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static Float Instance = new();

        /// <summary>
        /// Desc.
        /// </summary>
        /// <returns>The desc result.</returns>
        public int Desc(float firstValue, float secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The asc result.</returns>
        public int Asc(float firstValue, float secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Represents the string length type.
    /// </summary>
    public class StringLength : ISunamoComparer<string>
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static StringLength Instance = new();

        /// <summary>
        /// Desc.
        /// </summary>
        /// <returns>The desc result.</returns>
        public int Desc(string firstValue, string secondValue)
        {
            var firstLength = firstValue.Length;
            var secondLength = secondValue.Length;
            return firstLength.CompareTo(secondLength) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <param name="secondLength">The second length.</param>
        /// <returns>The asc result.</returns>
        public int Asc(string firstValue, string secondValue)
        {
            var firstLength = firstValue.Length;
            var secondLength = secondValue.Length;
            return firstLength.CompareTo(secondLength);
        }
    }

    /// <summary>
    /// Represents the integer 64 type.
    /// </summary>
    public class Integer64 : ISunamoComparer<long>
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static Integer64 Instance = new();

        /// <summary>
        /// Desc.
        /// </summary>
        /// <returns>The desc result.</returns>
        public int Desc(long firstValue, long secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <returns>The asc result.</returns>
        public int Asc(long firstValue, long secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Represents the integer type.
    /// </summary>
    public class Integer : ISunamoComparer<int>
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static Integer Instance = new();

        /// <summary>
        /// Desc.
        /// </summary>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The desc result.</returns>
        public int Desc(int firstValue, int secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <returns>The asc result.</returns>
        public int Asc(int firstValue, int secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Represents the DT type.
    /// </summary>
    public class DT : ISunamoComparer<DateTime>
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static DT Instance = new();

        /// <summary>
        /// Desc.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The desc result.</returns>
        public int Desc(DateTime firstValue, DateTime secondValue)
        {
            return firstValue.CompareTo(secondValue) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <returns>The asc result.</returns>
        public int Asc(DateTime firstValue, DateTime secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }

    /// <summary>
    /// Represents the i list char length type.
    /// </summary>
    public class IListCharLength : ISunamoComparer<IList<char>>
    {
        /// <summary>
        /// The instance.
        /// </summary>
        public static IListCharLength Instance = new();

        /// <summary>
        /// Desc.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The desc result.</returns>
        public int Desc(IList<char> firstValue, IList<char> secondValue)
        {
            return firstValue.Count.CompareTo(secondValue.Count) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The asc result.</returns>
        public int Asc(IList<char> firstValue, IList<char> secondValue)
        {
            return firstValue.Count.CompareTo(secondValue.Count);
        }
    }

    /// <summary>
    /// Represents the t with int sunamo comparer t type.
    /// </summary>
    public class TWithIntSunamoComparer<T> : ISunamoComparer<TWithIntCompare<T>>
    {
        /// <summary>
        /// Desc.
        /// </summary>
        /// <returns>The desc result.</returns>
        public int Desc(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
        {
            var firstCount = firstValue.Count;
            var secondCount = secondValue.Count;
            return firstCount.CompareTo(secondCount) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <param name="secondValue.Count">The second value count.</param>
        /// <returns>The asc result.</returns>
        public int Asc(TWithIntCompare<T> firstValue, TWithIntCompare<T> secondValue)
        {
            var firstCount = firstValue.Count;
            var secondCount = secondValue.Count;
            return firstCount.CompareTo(secondCount);
        }
    }

    /// <summary>
    /// Represents the t with dt sunamo comparer t type.
    /// </summary>
    public class TWithDtSunamoComparer<T> : ISunamoComparer<ITWithDt<T>>
    {
        /// <summary>
        /// Desc.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The desc result.</returns>
        public int Desc(ITWithDt<T> firstValue, ITWithDt<T> secondValue)
        {
            var firstDateTime = firstValue.Dt;
            var secondDateTime = secondValue.Dt;
            return firstDateTime.CompareTo(secondDateTime) * -1;
        }

        /// <summary>
        /// Asc.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>The asc result.</returns>
        public int Asc(ITWithDt<T> firstValue, ITWithDt<T> secondValue)
        {
            var firstDateTime = firstValue.Dt;
            var secondDateTime = secondValue.Dt;
            return firstDateTime.CompareTo(secondDateTime);
        }
    }
}
