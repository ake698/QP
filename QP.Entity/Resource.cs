﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QP.Entity
{
    public class Resource : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
