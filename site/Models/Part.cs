using System;
using System.Collections.Generic;

namespace site
{
    public partial class Part
    {
        public Part()
        {
            Part2item = new HashSet<Part2item>();
        }
        
        public int Itemno { get; set; }
        public string Namapart { get; set; }
        public double Harga { get; set; }
        public int Qty { get; set; }

        public ICollection<Part2item> Part2item { get; set; }
    }
}
