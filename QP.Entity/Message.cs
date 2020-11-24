namespace QP.Entity
{
    public class Message : BaseEntity
    {
        public string Content { get; set; }
        public bool IsResolved { get; set; } = false;
    }
}
