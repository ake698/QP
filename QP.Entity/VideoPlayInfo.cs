namespace QP.Entity
{
    public class VideoPlayInfo : FullEntity<int>
    {
        public VideoBasicInfo VideoBasicInfo { get; set; }
        public int BasicInfoId { get; set; }
        public Resource Resource { get; set; }
        public int ResourceId { get; set; }
        public int VodId { get; set; }
        public string Kuyun { get; set; }
        public string M3u8 { get; set; }
        public string Mp4 { get; set; }
    }
}
