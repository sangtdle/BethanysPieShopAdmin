namespace BethanysPieShopAdmin.Utilities
{
    public class PagedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotlalNumberOfPages { get; private set; }
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotlalNumberOfPages;

        public PagedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;

            TotlalNumberOfPages = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(items);
        }
    }
}
