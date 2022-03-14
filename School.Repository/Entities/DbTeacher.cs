using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Repository.Entities
{
    public class DbTeacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        public int? ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public DbClass Class { get; set; }

        public ICollection<DbSubject> Subjects { get; set; }
    }
}
