using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace CRUD_Authenticate.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Required]
        [MaxLength(255)]
        [Key]
        public string Email { get; set; }
        [MaxLength(255)]
        public string? FirstName { get; set; }
        [MaxLength(255)]
        public string? LastName { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        [ForeignKey("Privilege")]
        public char PrivilegeID { get; set; }
        public virtual Role Privilege { get; set; }
        public char Sex { get; set; }
        [Required]
        [MaxLength(255)]
        public string Password { get; set; }
        [MaxLength(255)]
        public string? ProfilePic { get; set; }
        [MaxLength(255)]
        [ForeignKey("PostalAddress")]
        public string PostalAddressId { get; set; }
        public Address PostalAddress { get; set; }
    }
}
