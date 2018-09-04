using System;
using System.Collections.Generic;

namespace site
{
    public partial class Part2item
    {
        public int No { get; set; }
        public int Itemnoitem { get; set; }
        public int Itemnopart { get; set; }

        public Item ItemnoitemNavigation { get; set; }
        public Part ItemnopartNavigation { get; set; }
    }
}
