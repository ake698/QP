using QP.Entity.Common;
using System;

namespace QP.Entity
{
    public abstract class BaseEntity : IHasSoftDelete, IHasActionTime
    {
        public virtual int Id { get; set; }
        public virtual bool IsDelete { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual DateTime LastModificationTime { get; set; } = DateTime.Now;
    }
}
