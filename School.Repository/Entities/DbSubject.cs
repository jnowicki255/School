using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Repository.Entities
{
    public class DbSubject
    {
        [Key]
        public int SubjectId { get; set; }
        
        [Required, StringLength(25)]
        public string Name { get; set; }

        public ICollection<DbTeacher> Teachers { get; set; }
    }
}
