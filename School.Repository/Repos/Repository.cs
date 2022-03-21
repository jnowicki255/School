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
            throw new NotImplementedException();
        }

        public DbSubject[] GetSubjects()
        {
            throw new NotImplementedException();
        }

        public void UpdateSubject(DbSubject updatedSubject)
        {
            throw new NotImplementedException();
        }
    }
}
