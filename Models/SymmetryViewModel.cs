using System.ComponentModel.DataAnnotations;

namespace test2.Models
{
    public class SymmetryViewModel
    {
        [Required]
        public int Number { get; set; }
        public bool? IsSymmetrical { get; set; }
    }
}
