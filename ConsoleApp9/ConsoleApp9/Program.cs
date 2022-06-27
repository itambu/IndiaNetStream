// See https://aka.ms/new-console-template for more information
using ConsoleApp9;

Console.WriteLine("Hello, World!");

using(var context = new BlogDbContext())
{
    //Client client = new Client()
    //{
    //    Name = "John Smith"
    //};

    //Blog blog = new Blog()
    //{
    //    Client = client,
    //    Topic = "EF Example",
    //    Created = DateTime.Now,
    //};

    //context.Blogs.Add(blog);

    //context.SaveChanges();

    var clients = context.Clients.Where(client => client.Name.Contains("John"));
    foreach(var client in clients)
    {
        Console.WriteLine(client.Name);
    }
}
