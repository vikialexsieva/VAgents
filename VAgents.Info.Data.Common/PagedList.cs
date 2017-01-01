namespace VAgents.Info.Data.Common
{
    using System;
    using System.Collections.Generic;

    public class PagedList<T>
    {
        public List<T> Content { get; set; }
        public string SortDir { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
    }

}
