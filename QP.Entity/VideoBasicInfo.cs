﻿using System.Collections.Generic;

namespace QP.Entity
{
    public class VideoBasicInfo : BaseEntity
    {
        public CategoryType CategoryType { get; set; }
        public virtual ICollection<VideoPlayInfo> VideoPlayInfos { get; set; }
        public int CategoryTypeId { get; set; }
        public string CategoryTypeNames { get; set; }
        public int SeriesTypeId { get; set; }
        public string Name { get; set; }
        public string En { get; set; }
        public string Alias { get; set; }
        public string Describes { get; set; }
        public string Image { get; set; }
        public string Dierctor { get; set; }
        public string Actor { get; set; }
        public string Remark { get; set; }
        public string AreaName { get; set; }
        public string Language { get; set; }
        public string Year { get; set; }
        public int Count { get; set; }
        public bool IsHot { get; set; }
        public float Rate { get; set; }
    }
}
