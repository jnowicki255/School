using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Repository.Entities
{
    public class DbStudent
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Precision(0)]
        public DateTime BirthDate { get; set; }

        [StringLength(15)]
        public string Telephone { get; set; }

        public int? ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public DbClass Class { get; set; }
    }
}
