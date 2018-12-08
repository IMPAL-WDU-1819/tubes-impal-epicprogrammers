using System;
using System.Collections.Generic;

namespace site
{
    public partial class Part2item
    {
        public int No { get; set; }
        public int Itemnoitem { get; set; }
        public int Itemnopart { get; set; }

        public Item2sell Item2sellNavigation { get; set; }
        public Part Part { get; set; }
    }
}
