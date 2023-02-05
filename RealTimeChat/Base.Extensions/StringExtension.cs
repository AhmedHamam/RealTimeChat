namespace Base.Extensions;

public static class StringExtension
{
    public static string AsNotNull(this string original)
    {
        return original ?? string.Empty;
    }
}