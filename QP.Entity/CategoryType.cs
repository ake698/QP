namespace QP.Entity
{
    public class CategoryType : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public SeriesType SeriesType { get; set; }
        public int SeriesTypeId{get;set;}
    }
}
