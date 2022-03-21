using School.Repository.Entities;

namespace School.Repository.Repos.Interfaces
{
    public interface ISubjectsRepository
    {
        DbSubject GetSubject(int subjectId);
        DbSubject[] GetSubjects();
        void AddSubject(DbSubject newSubject);
        void UpdateSubject(DbSubject updatedSubject);
        void DeleteSubject(int subjectId);
    }
}
