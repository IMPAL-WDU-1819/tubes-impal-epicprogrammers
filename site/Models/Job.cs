using System;
using System.Collections.Generic;

namespace site
{
    public partial class Job
    {
        public Job()
        {
            Item = new HashSet<Item>();
        }

        public int Jobid { get; set; }
        public string Progress { get; set; }
        public string Employeeemail { get; set; }
        public DateTime Lastupdated { get; set; }

        public Employee EmployeeemailNavigation { get; set; }
        public ICollection<Item> Item { get; set; }
    }
}
