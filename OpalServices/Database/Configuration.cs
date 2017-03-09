namespace OpalServices.Database
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OpalServices.Database.OpalContext>
    {
        private OpalContext _context;
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = "Database\\Migrations";
        }

        protected override void Seed(OpalServices.Database.OpalContext context)
        {
            _context = context;
            SeedUsers();
        }

        private void SeedUsers()
        {
            _context.Users.AddOrUpdate(x => new { x.Name },
                new User
                {
                    Name = "Jesmond",
                    Surname = "Mifsud",
                    Username = "jesmmifs",
                    Password = "0C-6D-35-FF-54-3F-B2-C3-3D-77-A5-4C-71-FF-A4-BA",
                    Salt = "gEgWQrwC7z"
                }
                );
            _context.SaveChanges();
        }

    }
}
