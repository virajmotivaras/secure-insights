namespace SecureInsights.Common
{
    public static class HelperExtensions
    {
        /// <summary>
        /// Indicates whether the specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or empty, or if value consists exclusively of white-space characters; otherwise, false.</returns>
        public static bool IsNullOrWhiteSpace(this string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsGuidEmpty(this Guid value)
        {
            return value == Guid.Empty;
        }
    }
}
