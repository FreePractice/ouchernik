namespace ouchernik.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;

    public sealed class Configuration : DbMigrationsConfiguration<OuchernikDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ouchernik.Data.OuchernikDbContext";
        }

        protected override void Seed(OuchernikDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
                var roleTeacher = new IdentityRole { Name = "Teacher" };
                var roleStudent = new IdentityRole { Name = "Student" };

                manager.Create(role);
                manager.Create(roleTeacher);
                manager.Create(roleStudent);
            }

            if (!context.Users.Any(u => u.UserName == "Admin"))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var user = new User { UserName = "Admin", Email = "yunay@abv.bg" };

                manager.Create(user, "AdminPass123");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.SchoolSubjects.Any())
            {
                var schoolSubjects = new SchoolSubject();

                HashSet<string> subjects = new HashSet<string>();
                subjects.Add("География");
                subjects.Add("Физика");
                subjects.Add("Информационни технологии");
                subjects.Add("Информатика");
                subjects.Add("Химия");
                subjects.Add("Английски език");
                subjects.Add("Немски език");
                subjects.Add("Руски език");
                subjects.Add("Музика");
                subjects.Add("Български език");
                subjects.Add("История");
                subjects.Add("Час на класния");
                subjects.Add("Изобразително изкуство");
                subjects.Add("Биология");
                subjects.Add("Труд и техника");

                foreach (var subject in subjects)
                {
                    schoolSubjects.Name = subject;
                    context.SchoolSubjects.Add(schoolSubjects);

                    context.SaveChanges();
                }
            }
        }
    }
}
