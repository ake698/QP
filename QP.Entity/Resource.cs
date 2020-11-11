using System;
using System.Collections.Generic;
using System.Text;

namespace QP.Entity
{
    public class Resource : Entity<int>
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
