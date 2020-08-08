using System.Linq;

namespace MiniFacebook.Shared.Helper
{
    public static class PagedList
    {
        public static QueryResult<object> Create(IQueryable<object> source, PaginationObject paginationObject)
        {
            var Result = new QueryResult<object>();
            Result.Totalcount = source.Count();
            source = source.ApplyPaging(paginationObject);
            Result.Items = source;
            Result.PaginationCount = source.Count();
            return Result;
        }
    }
}
