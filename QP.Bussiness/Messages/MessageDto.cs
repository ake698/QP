namespace QP.Bussiness.Messages
{
    public class MessageDto : FullDto
    {
        public string Content { get; set; }
        public bool IsResolved { get; set; }
    }
}
