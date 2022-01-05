namespace ExamDemo.Common
{
    public static class Utils
    {
        public static string TrimIfNonEmpty(this string value)
        {
            return string.IsNullOrEmpty(value) ? string.Empty : value.Trim();
        }
    }
}
