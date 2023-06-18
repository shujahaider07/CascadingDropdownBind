using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CascadingDropdownBind.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string? Name{ get; set; }
        public Country country { get; set; }
    }
}
