namespace DataAccessLayer.Migrations
{
    using Bogus;
    using DataAccessLayer.Data;
    using DataTransferObject;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryManagementSystemContext>
    {
        private readonly List<User> Users;
        private readonly List<Book> Books;
        private readonly List<Author> Authors;
        private readonly List<Publisher> Publishers;
        private readonly List<Category> Categories;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.Authors = this.AuthorsTableData();
            this.Publishers = this.PublishersTableData();
            this.Categories = this.CategoriesTableData();
            // Đặt cuối cùng vì nó cần các data ở trên
            this.Books = this.BooksTableData();
            this.Users = this.UsersTableData();
        }

        protected override void Seed(LibraryManagementSystemContext context)
        {
            // Users Table Seeder
            context.Users.AddRange(this.Users);

            // Authors Table Seeder
            context.Authors.AddRange(this.Authors);

            // Publishers Table Seeder
            context.Publishers.AddRange(this.Publishers);

            // Categories Table Seeder
            context.Categories.AddRange(this.Categories);

            // Books Table Seeder
            context.Books.AddRange(this.Books);

            // Save
            context.SaveChanges();
        }

        private List<User> UsersTableData()
        {
            string password = "e10adc3949ba59abbe56e057f20f883e"; // 123456

            User chuCamPhong = new User { Name = "Chu Cẩm Phong", Email = "chucamphong@gmail.com", Password = password };
            User tranDuyAnh = new User { Name = "Trần Duy Anh", Email = "tranduyanh@gmail.com", Password = password };
            User nguyenXuanHoa = new User { Name = "Nguyễn Xuân Hòa", Email = "nguyenxuanhoa@gmail.com", Password = password };

            chuCamPhong.UserBooks = new List<UserBook> {
                new UserBook {
                    User = chuCamPhong,
                    Book = this.Books.Find(book => book.Name.Equals("Doraemon - Chú mèm máy đến từ tương lai")),
                    FromDate = new System.DateTime().AddDays(12).AddMonths(5).AddYears(2019),
                    ToDate = new System.DateTime().AddDays(14).AddMonths(5).AddYears(2019)
                }
            };

            return new List<User> {
                chuCamPhong,
                tranDuyAnh,
                nguyenXuanHoa
            };
        }

        private List<Book> BooksTableData()
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Name = "Thám tử lừng danh Conan",
                    Authors = this.Authors.FindAll(c => c.Name.Equals("Aoyama Goushou")),
                    Publishers = new List<Publisher> {
                        this.Publishers.Find(p => p.Name == "Viz Media"),
                        this.Publishers.Find(p => p.Name == "Funimation")
                    },
                    Thumbnail = "Image Conan",
                    Categories = new List<Category>
                    {
                        this.Categories.Find(c => c.Name == "Trinh thám")
                    }
                },
                new Book
                {
                    Name = "Doraemon - Chú mèm máy đến từ tương lai",
                    Authors = this.Authors.FindAll(c => c.Name.Equals("Fujiko Fujio")),
                    Publishers = new List<Publisher> {
                        this.Publishers.Find(p => p.Name == "Nhà xuất bản Kim Đồng")
                    },
                    Thumbnail = "ImageDoraemon",
                    Categories = new List<Category>
                    {
                        this.Categories.Find(c => c.Name == "Hành động")
                    }
                }
            };

            return books;
        }

        private List<Author> AuthorsTableData()
        {
            //int orderIds = 0;

            //var faker = new Faker<Author>("vi")
            //                    .RuleFor(t => t.Id, f => orderIds++)
            //                    .RuleFor(t => t.Name, f => f.Random.Hash(10).ToString() + f.Name.FullName());

            //return faker.UseSeed(Randomizer.Seed.Next()).Generate(100);

            return new List<Author> {
                new Author { Name = "Aoyama Goushou" },
                new Author { Name = "Fujiko Fujio" },
            };
        }

        private List<Publisher> PublishersTableData()
        {
            return new List<Publisher> {
                new Publisher { Name = "Nhà xuất bản Kim Đồng" },
                new Publisher { Name = "Viz Media" },
                new Publisher { Name = "Funimation" }
            };
        }

        private List<Category> CategoriesTableData()
        {
            return new List<Category> {
                new Category { Name = "Trinh thám" },
                new Category { Name = "Hành động" }
            };
        }
    }
}
