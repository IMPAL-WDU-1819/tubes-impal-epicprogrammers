using System;
using site.Models;
using System.Collections.Generic;

namespace site
{
    public partial class User2item
    {
        public int No { get; set; }
        public string Emailuser { get; set; }
        public int Itemno { get; set; }

        public Consumer EmailuserNavigation { get; set; }
        public Item ItemnoNavigation { get; set; }
    }
}
