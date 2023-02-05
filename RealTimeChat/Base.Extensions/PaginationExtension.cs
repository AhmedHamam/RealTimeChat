namespace Base.Extensions;

public static class PaginationExtension
{
    public static (List<T> list, int total) Paginate<T>(this IQueryable<T> query, int pageSize, int pageNumber)
    {
        var paginatedList = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        return (paginatedList.ToList(), query.Count());
    }
}