using System.Collections.Generic;

namespace QP.Bussiness
{
    public class BasePageResulDto<R>
    {
        public List<R> Datas { get; set; }
        public int DataCounts { get; set; }
    }
}
