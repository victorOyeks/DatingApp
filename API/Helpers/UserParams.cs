namespace API.Helpers
{
    public class UserParams
    {
        public const int MaxPageSize = 50;
        public int pageNumber { get; set; } = 1;
        public int _pageSize { get; set; } = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string CurrentUserame { get; set; }
        public string Gender { get; set; }
    }
}