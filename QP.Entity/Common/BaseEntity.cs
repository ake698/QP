using QP.Entity.Common;

namespace QP.Entity
{
    public abstract class BaseEntity : IHasSoftDelete
    {
        public virtual int Id { get; set; }
        public virtual bool IsDelete { get; set; }
    }
}
