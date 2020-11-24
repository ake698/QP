namespace QP.Entity
{
    public class Message : FullEntity
    {
        public string Content { get; set; }
        public bool IsResolved { get; set; } = false;
    }
}
