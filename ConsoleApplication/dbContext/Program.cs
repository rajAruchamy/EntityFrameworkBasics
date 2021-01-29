using System;

namespace dbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the entity framework data base init");

            CreateNewUser();

            Console.WriteLine("Entity framework test OK");
            Console.ReadKey();
        }

        // CRUD - CREATE, READ, UPDATE, DELETE

        static void CreateNewUser()
        {
            using var context = new MyDatabaseContext();
            var newUser = new User {Name = "Raja", Email = "snow@mail.com"};
            context.Users.Add(newUser);
            context.SaveChanges();
        }

        static User ReadUser(int id)
        {
            using var context = new MyDatabaseContext();
            return context.Users.Find(id);
        }

        static void UpdateUserEmail(int id, string email)
        {
            using var context = new MyDatabaseContext();
            var user = context.Users.Find(id);
            if (user != null)
            {
                user.Email = email;
            }
            context.SaveChanges();
        }

        static void DeleteUser(int id)
        {
            using var context = new MyDatabaseContext();
            var user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
            }
        }
    }
}
