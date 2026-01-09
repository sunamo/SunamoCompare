// variables names: ok
namespace SunamoCompare._sunamo.SunamoValues.Constants;

/// <summary>
/// Contains numeric constants used throughout the application.
/// </summary>
internal class NumConsts
{
    #region For easy copy
    /// <summary>
    /// Constant value for -1.
    /// </summary>
    internal const int MinusOne = -1;
    #endregion

    /// <summary>
    /// Default SMTP port if the port cannot be parsed from configuration.
    /// </summary>
    internal const int DefaultPortIfCannotBeParsed = 587;

    /// <summary>
    /// Minimum age is 18 due to GDPR - below 18 requires parent agreement.
    /// </summary>
    internal const int MinAge = 18;

    /// <summary>
    /// Minimum DateTime value represented as short (format: yMMdd, year 1010, month 1, day 1).
    /// </summary>
    internal static short DateTimeMinValue = 10101;

    /// <summary>
    /// Maximum DateTime value represented as short (format: yMMdd, year 3227, month 1, day 1).
    /// </summary>
    internal static short DateTimeMaxValue = 32271;

    /// <summary>
    /// One thousand (1000).
    /// </summary>
    internal static int OneThousand = 1000;

    /// <summary>
    /// Number of bytes in a kilobyte (1024).
    /// </summary>
    internal const long KiloByte = 1024;

    /// <summary>
    /// Zero represented as double.
    /// </summary>
    internal const double ZeroDouble = 0;

    /// <summary>
    /// Zero represented as float.
    /// </summary>
    internal const float ZeroFloat = 0;

    /// <summary>
    /// Constant value for 1 (no postfix for int).
    /// </summary>
    internal const int One = 1;

    /// <summary>
    /// Zero represented as int.
    /// </summary>
    internal const int ZeroInt = 0;
}