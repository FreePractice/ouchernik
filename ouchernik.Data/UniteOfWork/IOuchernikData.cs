namespace ouchernik.Data.UniteOfWork
{
    using Repositories;
    using Models;

    public interface IOuchernikData
    {
        IRepository<User> Users { get; }

        IRepository<Answer> Answers { get; }

        IRepository<Media> Media { get; }

        IRepository<News> News { get; }

        IRepository<Question> Questions { get; }

        IRepository<Resource> Resources { get; }

        IRepository<Rubric> Rubrics { get; }

        IRepository<SchoolClass> SchoolClasses { get; }

        IRepository<SchoolSubject> SchoolSubjects { get; }

        IRepository<Vote> Votes { get; }

        void SaveChanges();
    }
}
