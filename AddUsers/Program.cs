using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddUsers;

namespace AddUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input fullName:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Input email:");
            string email = Console.ReadLine();
            Console.WriteLine("Input password:");
            string password = Console.ReadLine();

            using (ModelUser users = new ModelUser())
            {
                User user = new User(fullName, email, password);
                users.Users.Add(user);
                users.SaveChanges();

            }

        }

    }
}
