namespace OpenF1.Queries;

internal static class EqualityTransformExtensions
{
    /// <summary>
    /// Converts a value of <see cref="Equality"/> into its string representation.
    /// </summary>
    public static string ToEqualityString(this Equality equality)
    {
        return equality switch
        {
            Equality.Equals => "=",
            Equality.LessThan => "<",
            Equality.LessThanOrEqual => "<=",
            Equality.GreaterThan => ">",
            Equality.GreaterThanOrEqual => ">=",
            _ => throw new ArgumentOutOfRangeException($"Unrecognized {nameof(Equality)} value: {equality}. Could not convert to string representation.")
        };
    }
}
