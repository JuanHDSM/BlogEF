using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

// var user = new User
// {
//     Name = "Juan Holy",
//     Email = "juan@holy.io",
//     PasswordHash = "123456",
//     Bio = "12X Microsoft MVP",
//     Image = "https://balta.io",
//     Slug = "juanholy"
// };

// var category = new Category
// {
//     Name = "Backend",
//     Slug = "backend"
// };

// var post = new Post
// {
//     Body = "<p>Hello world</p>",
//     Slug = "comecando-com-ef-core",
//     Summary = "Neste artigo vamos aprender EF core",
//     Title = "Começando com EF Core",
//     CreateDate = DateTime.Now,
//     LastUpdateDate = DateTime.Now,
//     Author = user,
//     Category = category
// };

// context.Posts.Add(post);
// context.SaveChanges();

context.Posts.ToList().ForEach(p => Console.WriteLine(p.Title));