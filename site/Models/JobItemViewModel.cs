using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
namespace site
{
    public partial class JobItemViewModel
    {
        public Job Job {get; set;}
        public Item JobItem { get; set; }
        public List<Job> RecentJob {get;set;}
    }
}

