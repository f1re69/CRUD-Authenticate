using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Authenticate.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        [Required]
        public char Privilege { get; set; }
    }
}
