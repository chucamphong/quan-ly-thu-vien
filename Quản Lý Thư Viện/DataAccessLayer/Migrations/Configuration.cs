namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Data;
    using DataTransferObject.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryManagementSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LibraryManagementSystemContext context)
        {
            string password = "e10adc3949ba59abbe56e057f20f883e"; // 123456

            context.Users.AddOrUpdate(col => col.Id,
                new User { Name = "Chu Cẩm Phong", Email = "chucamphong@gmail.com", Password = password },
                new User { Name = "Trần Duy Anh", Email = "tranduyanh@gmail.com", Password = password }
            );
        }
    }
}
