using QP.Entity.Common;
using System;

namespace QP.Entity
{
    public abstract class FullEntity : BaseEntity, IHasActionTime, IHasSoftDelete
    {
        //public virtual DateTime CreationTime { get; set; }
        //public virtual DateTime LastModificationTime { get; set; } = DateTime.Now;
    }
}
