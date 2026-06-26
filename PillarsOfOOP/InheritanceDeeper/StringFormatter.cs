static class StringFormatter
{
    public static string? ToLowerSentence(this string? str)
    {
        if (string.IsNullOrEmpty(str)) return str;

        return char.ToLower(str[0]) + string.Concat(
            str.Skip(1).Select((x, i) => char.IsUpper(x) ? " " + char.ToLower(x) : x.ToString())
        );
    }
}