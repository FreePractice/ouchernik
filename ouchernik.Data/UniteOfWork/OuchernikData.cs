namespace ouchernik.Data.UniteOfWork
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Repositories;
    using Models;

    public class OuchernikData : IOuchernikData
    {
        private readonly DbContext dbContext;

        private readonly IDictionary<Type, object> repositories;

        private IUserStore<User> userStore;

        public OuchernikData()
            : this(new OuchernikDbContext())
        {
        }

        public OuchernikData(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Answer> Answers
        {
            get { return this.GetRepository<Answer>(); }
        }

        public IRepository<Media> Media
        {
            get { return this.GetRepository<Media>(); }
        }

        public IRepository<News> News
        {
            get { return this.GetRepository<News>(); }

        }

        public IRepository<Question> Questions
        {
            get { return this.GetRepository<Question>(); }
        }

        public IRepository<Resource> Resources
        {
            get { return this.GetRepository<Resource>(); }
        }

        public IRepository<Rubric> Rubrics
        {
            get { return this.GetRepository<Rubric>(); }
        }

        public IRepository<SchoolClass> SchoolClasses
        {
            get { return this.GetRepository<SchoolClass>(); }
        }

        public IRepository<SchoolSubject> SchoolSubjects
        {
            get { return this.GetRepository<SchoolSubject>(); }
        }

        public IRepository<Vote> Votes
        {
            get { return this.GetRepository<Vote>(); }
        }

       

        public IUserStore<User> UserStore
        {
            get
            {
                if (this.userStore == null)
                {
                    this.userStore = new UserStore<User>(this.dbContext);
                }

                return this.userStore;
            }
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(EntityFrameworkRepository<T>);
                this.repositories.Add(
                    typeof(T),
                    Activator.CreateInstance(type, this.dbContext));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
