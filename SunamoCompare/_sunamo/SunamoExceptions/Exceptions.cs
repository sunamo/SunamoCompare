namespace SunamoCompare._sunamo.SunamoExceptions;

/// <summary>
/// Contains exception handling utilities and shared resources.
/// </summary>
internal sealed partial class Exceptions
{
    #region Other

    #region IsNullOrWhitespace
    /// <summary>
    /// StringBuilder for inner additional information in exception messages.
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoInnerStringBuilder = new();

    /// <summary>
    /// StringBuilder for additional information in exception messages.
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoStringBuilder = new();
    #endregion
    #endregion
}
