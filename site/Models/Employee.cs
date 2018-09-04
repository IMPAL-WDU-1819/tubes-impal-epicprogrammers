using System;
using System.Collections.Generic;

namespace site
{
    public partial class Employee
    {
        public Employee()
        {
            Job = new HashSet<Job>();
        }

        public string Email { get; set; }
        public string Pass { get; set; }
        public string Address { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public decimal Notel { get; set; }
        public DateTime Lastlogin { get; set; }

        public ICollection<Job> Job { get; set; }
    }
}
