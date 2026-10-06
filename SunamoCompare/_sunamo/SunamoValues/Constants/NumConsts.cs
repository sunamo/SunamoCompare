namespace SunamoCompare._sunamo.SunamoValues.Constants;

internal class NumConsts
{
    #region For easy copy
    internal const int MinusOne = -1;
    #endregion

    internal const int DefaultPortIfCannotBeParsed = 587;

    // Minimum age is 18 due to GDPR - below 18 requires parent agreement.
    internal const int MinAge = 18;

    // Minimum DateTime value represented as short (format: yMMdd, year 1010, month 1, day 1).
    internal static short DateTimeMinValue = 10101;

    // Maximum DateTime value represented as short (format: yMMdd, year 3227, month 1, day 1).
    internal static short DateTimeMaxValue = 32271;

    internal static int OneThousand = 1000;

    internal const long KiloByte = 1024;

    internal const double ZeroDouble = 0;

    internal const float ZeroFloat = 0;

    internal const int One = 1;

    internal const int ZeroInt = 0;
}
