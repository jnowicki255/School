using School.Repository.Entities;
using School.Repository.Repos.Interfaces;

namespace School.Repository.Repos
{
    public class Repository : IRepository
    {
        private readonly SchoolDbContext dbContext;

        public Repository()
        {
            dbContext = new SchoolDbContext();
        }

        public void AddSubject(DbSubject newSubject)
        {
            dbContext.Subjects.Add(newSubject);
            dbContext.SaveChanges();
        }

        public void DeleteSubject(int subjectId)
        {
            var subject = dbContext.Subjects
                .SingleOrDefault(x => x.SubjectId == subjectId);

            dbContext.Subjects.Remove(subject);
            dbContext.SaveChanges();
        }

        public DbSubject GetSubject(int subjectId)
        {
            var subject = dbContext.Subjects
                .SingleOrDefault(x => x.SubjectId == subjectId);

            return subject;
        }

        public DbSubject[] GetSubjects()
        {
            var subjects = dbContext.Subjects.ToArray();
            return subjects;
        }

        public void UpdateSubject(DbSubject updatedSubject)
        {
            var subject = dbContext.Subjects
                .SingleOrDefault(x => x.SubjectId == updatedSubject.SubjectId);

            if (subject == null)
                return;

            dbContext.Entry(subject).CurrentValues.SetValues(updatedSubject);
            dbContext.SaveChanges();
        }
    }
}
