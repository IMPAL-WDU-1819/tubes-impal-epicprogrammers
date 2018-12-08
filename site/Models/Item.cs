using System;
using System.Collections.Generic;

namespace site
{
    public partial class Item
    {
        public Item()
        {
            User2item = new HashSet<User2item>();
        }

        public int Itemno { get; set; }
        public int Jobid { get; set; }
        public string Imgurl { get; set; }
        public string Description { get; set; }
        public int? Item2sellno { get; set; }
        public string Email { get; set; }

        public Consumer EmailNavigation { get; set; }
        public Item2sell Item2sell { get; set; }
        public Job Job { get; set; }
        public ICollection<User2item> User2item { get; set; }
    }
}
