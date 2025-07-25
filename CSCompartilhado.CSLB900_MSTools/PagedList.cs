namespace CSLB900.MSTools
{
    public class PagedList<T> : List<T> where T : class
    {
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public bool HasPrevius => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPage;

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalPage = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(items);
        }
        //teste


        public static PagedList<T> ToPagedList(List<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null");
            }

            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }

        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null");
            }

            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }



        public static PagedList<T> ToPagedList(List<T> source, int count, int pageNumber, int pageSize)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null");
            }
            return new PagedList<T>(source, count, pageNumber, pageSize);
        }

        public static PagedList<T> ToPagedList(IEnumerable<T> source, int count, int pageNumber, int pageSize)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null");
            }
            return new PagedList<T>(source.ToList(), count, pageNumber, pageSize);
        }

    }
}
