using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Authenticate.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [Required]
        [MaxLength(255)]
        public string PostalAddress { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        [MaxLength(255)]
        public string City { get; set; }
        [Required]
        [MaxLength(255)]
        public string Country { get; set; }

    }
}
