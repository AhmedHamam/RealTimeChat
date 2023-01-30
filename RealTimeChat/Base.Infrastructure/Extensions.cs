namespace Base.Infrastructure
{
    public static class Extensions
    {
        public static int? ToIntOrNull(this string s)
        {
            if (!int.TryParse(s, out int result))
            {
                return null;
            }

            return result;
        }
    }
}
