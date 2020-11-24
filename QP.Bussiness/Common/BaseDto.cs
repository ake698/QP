using System;

namespace QP.Bussiness
{
    public class BaseDto
    {
        public int Id { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual DateTime LastModificationTime { get; set; }
    }
}
