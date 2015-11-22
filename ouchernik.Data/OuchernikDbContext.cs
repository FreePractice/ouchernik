namespace ouchernik.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class OuchernikDbContext : IdentityDbContext<User>
    {
        public OuchernikDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static OuchernikDbContext Create()
        {
            return new OuchernikDbContext();
        }

        public IDbSet<Answer> Answers { get; set; }
        public IDbSet<Media> Media { get; set; }
        public IDbSet<News> News { get; set; }
        public IDbSet<Question> Questions { get; set; }
        public IDbSet<Resource> Resources { get; set; }
        public IDbSet<Rubric> Rubrics { get; set; }
        public IDbSet<SchoolClass> SchoolClasses { get; set; }
        public IDbSet<SchoolSubject> SchoolSubjects { get; set; }
        public IDbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vote>()
                .HasRequired(vote => vote.Question)
                .WithMany(question => question.Votes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vote>()
              .HasRequired(vote => vote.User)
              .WithMany(question => question.Votes)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
             .HasRequired(question => question.Author)
             .WithMany(user => user.Questions)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Media>()
            .HasOptional(media => media.User)
            .WithOptionalPrincipal(user=>user.Media);

            modelBuilder.Entity<User>()
                .HasMany<SchoolSubject>(s => s.SchoolSubjects)
                .WithMany(c => c.Users)
                .Map(cs =>
                {
                    cs.MapLeftKey("UserId");
                    cs.MapRightKey("SchoolSubjectId");
                    cs.ToTable("UserSubjects");
                });


            base.OnModelCreating(modelBuilder);
        }
    }
}

