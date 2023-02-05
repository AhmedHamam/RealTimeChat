namespace Base.Extensions;

public static class ReferenceGenerator
{
    public static string Generator(string code)
    {
        Random rd = new Random();
        return code + DateTime.Now.ToString("yyyyMMddfff" + rd.Next(0, 9) + rd.Next(0, 9));
    }
}