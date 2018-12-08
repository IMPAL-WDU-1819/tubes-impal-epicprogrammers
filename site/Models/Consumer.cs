using System;
using System.Collections.Generic;

namespace site
{
    public partial class Consumer
    {
        public Consumer()
        {
            Item = new HashSet<Item>();
            User2item = new HashSet<User2item>();
        }

        public string Email { get; set; }
        public string Username { get; set; }
        public decimal Notel { get; set; }
        public string Address { get; set; }
        public string Nama { get; set; }
        public string Pass { get; set; }

        public ICollection<Item> Item { get; set; }
        public ICollection<User2item> User2item { get; set; }
    }
}
