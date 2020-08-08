using System.Collections.Generic;

namespace MiniFacebook.Shared.Helper
{
    public class QueryResult<T>
    {
        public int Totalcount { get; set; }
        public int PaginationCount { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
