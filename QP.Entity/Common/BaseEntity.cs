using QP.Entity.Common;

namespace QP.Entity
{
    public abstract class BaseEntity<T> : IHasSoftDelete
    {
        public virtual T Id { get; set; }
        public virtual bool IsDelete { get; set; }
    }
}
