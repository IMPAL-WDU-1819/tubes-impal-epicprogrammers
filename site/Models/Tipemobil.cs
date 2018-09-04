using System;
using System.Collections.Generic;

namespace site
{
    public partial class Tipemobil
    {
        public Tipemobil()
        {
            Item = new HashSet<Item>();
        }

        public int Tipeno { get; set; }
        public string Tipe { get; set; }

        public ICollection<Item> Item { get; set; }
    }
}
