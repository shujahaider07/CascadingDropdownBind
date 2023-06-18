using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CascadingDropdownBind.Models
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string? Name{ get; set; }
    }
}
