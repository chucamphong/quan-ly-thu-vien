namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Data;
    using DataTransferObject.Models;
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
            this.Users = this.UsersTableData();
            this.Books = this.BooksTableData();
            this.Publishers = this.PublishersTableData();
            this.Authors = this.AuthorsTableData();
            this.Categories = this.CategoriesTableData();
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

            return new List<User> {
                new User { Name = "Chu Cẩm Phong", Email = "chucamphong@gmail.com", Password = password },
                new User { Name = "Trần Duy Anh", Email = "tranduyanh@gmail.com", Password = password },
                new User { Name = "Nguyễn Xuân Hòa", Email = "nguyenxuanhoa@gmail.com", Password = password }
            };
        }

        private List<Book> BooksTableData()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book
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
            });

            books.Add(new Book
            {
                Name = "Doraemon - Chú mèm máy đến từ tương lai",
                Authors = this.Authors.FindAll(c => c.Name.Equals("Fujiko Fujio")),
                Publishers = new List<Publisher> {
                    this.Publishers.Find(p => p.Name == "Nhà xuất bản Kim Đồng")
                },
                Thumbnail = "Image Doraemon",
                Categories = new List<Category>
                {
                    this.Categories.Find(c => c.Name == "Hành động")
                }
            });

            return books;
        }

        private List<Author> AuthorsTableData()
        {
            return new List<Author> {
                new Author { Name = "Aoyama Goushou" },
                new Author { Name = "Fujiko Fujio" }
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
