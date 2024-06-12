using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class DataModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string Name { get; set; }

        [Column(TypeName = "Varchar(30)")]
		[Required(ErrorMessage = "The Email field is required.")]
		[EmailAddress(ErrorMessage = "Invalid Email Address.")]
		public string Email { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string Address { get; set; }
		[Required(ErrorMessage = "The DOB field is required.")]
		[DataType(DataType.Date)]
		public DateTime DOB { get; set; }
		
    }
}
