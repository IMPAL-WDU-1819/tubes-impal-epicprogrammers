using System;
using System.Collections.Generic;

namespace site
{
    public partial class Item2sell
    {
        public Item2sell()
        {
            Item = new HashSet<Item>();
            Part2item = new HashSet<Part2item>();
        }

        public int Item2sellno { get; set; }
        public string Namamobil { get; set; }
        public string Description { get; set; }
        public string Imgurl { get; set; }
        public string Warna { get; set; }
        public string Harga { get; set; }

        public ICollection<Item> Item { get; set; }
        public ICollection<Part2item> Part2item { get; set; }
    }
}
