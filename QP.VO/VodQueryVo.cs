namespace QP.Vo
{
    public class VodQueryVo
    {
        public int? CategoryId { get; set; }
        public string AreaName { get; set; }
        public string Year { get; set; }
        public string Language { get; set; }
        public string Letter { get; set; }
        public string Sort { get; set; }
        public int Page { get; set; } = 1;
    }
}
