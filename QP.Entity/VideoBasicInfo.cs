﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QP.Entity
{
    public class VideoBasicInfo : FullEntity<int>
    {
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
        public string Country { get; set; }
        public string Language { get; set; }
        public int Year { get; set; }
    }
}
