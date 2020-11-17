namespace QP.Bussiness
{
    public class PlayInfoDto : FullDto
    {
        public int BasicInfoId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string Kuyun { get; set; }
        public string Mp4 { get; set; }
        public string[] PlayAddresses => Kuyun.Split("#");
    }
}
