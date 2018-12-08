using System;
using System.Collections.Generic;

namespace site
{
    public partial class Job
    {
        public int Jobid { get; set; }
        public string Progress { get; set; }
        public string Employeeemail { get; set; }
        public DateTime Lastupdated { get; set; }

        public Employee EmployeeemailNavigation { get; set; }
        public Item Item { get; set; }
    }
}
