using site.Models;

using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
namespace site
{
    public partial class JobPartViewModel
    {
        public Job Job {get; set;}
        public List<Part2item> Parts { get; set; }
    }
}

