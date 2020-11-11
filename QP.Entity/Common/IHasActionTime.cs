using System;
using System.Collections.Generic;
using System.Text;

namespace QP.Entity.Common
{
    public interface IHasActionTime
    {
        public DateTime CreationTime { get; set; }
        public DateTime LastModificationTime { get; set; }
    }
}
