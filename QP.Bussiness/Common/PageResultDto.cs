using System.Collections.Generic;

namespace QP.Bussiness
{
    public class PageResultDto<R>
    {
        public List<R> Datas { get; set; }
        public int DataCounts { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int MaxPage { get; set; }
        public int[] Pages { get; set; }
    }
}
