using System.Collections.Generic;

namespace QP.Bussiness
{
    public class IndexTypeViewDto
    {
        public List<BasicInfoDto> Recommends { get; set; }
        public List<BasicInfoDto> RecommendsForMoblie { get; set; }
        public List<BasicInfoDto> RecommendTops { get; set; }

        public List<CategoryTypeDto> CategoryTypes { get; set; }
        public SeriesTypeDto SeriesType { get; set; }
    }
}
