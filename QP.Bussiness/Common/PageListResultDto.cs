using System.Collections.Generic;

namespace QP.Bussiness
{
    public class PageListResultDto<T>
    {
        public List<T> Datas { get; set; }
        public int Count { get; set; }
    }
}
