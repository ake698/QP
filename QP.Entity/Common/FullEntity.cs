using QP.Entity.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QP.Entity
{
    public abstract class FullEntity<T> : BaseEntity<T>, IHasActionTime, IHasSoftDelete
    {
        public virtual DateTime CreationTime { get; set; }
        public virtual DateTime LastModificationTime { get; set; }
    }
}
