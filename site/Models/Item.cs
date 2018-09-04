using System;
using System.Collections.Generic;

namespace site
{
    public partial class Item
    {
        public Item()
        {
            Part2item = new HashSet<Part2item>();
            User2item = new HashSet<User2item>();
        }

        public int Itemno { get; set; }
        public string Namamobil { get; set; }
        public double Harga { get; set; }
        public int Tipeno { get; set; }
        public string Warna { get; set; }
        public int Jobid { get; set; }

        public Job Job { get; set; }
        public Tipemobil TipenoNavigation { get; set; }
        public ICollection<Part2item> Part2item { get; set; }
        public ICollection<User2item> User2item { get; set; }
    }
}
