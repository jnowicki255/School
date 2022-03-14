using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Repository.Entities
{
    public class DbClass
    {
        [Key]
        public int ClassId { get; set; }

        [Required, StringLength(5)]
        public string Name { get; set; }

        public int? TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public DbTeacher Teacher { get; set; }

        public ICollection<DbStudent> Students { get; set; }
    }
}
