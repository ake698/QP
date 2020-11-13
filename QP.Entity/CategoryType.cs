namespace QP.Entity
{
    public class CategoryType : BaseEntity
    { 
        public string Name { get; set; }
        public SeriesType SeriesType { get; set; }
        public int SeriesTypeId{get;set;}
    }
}
