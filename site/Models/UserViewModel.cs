using System.ComponentModel.DataAnnotations;

namespace site
{
    public partial class UserViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Pass { get; set; }
    }
}
