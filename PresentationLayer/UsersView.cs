using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer
{
    public class UsersView
    {
        private DBManager<Users, int> manager;

        public UsersView()
        {
            manager = new DBManager<Users, int>(DBContextManager.CreateUsersContext(DBContextManager.CreateContext()));
        }

        public UsersView(DBManager<Users, int> manager)
        {
            this.manager = manager;
        }

        public void Create()
        {
            try
            {
                string username, password;
               

                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
                password= Console.ReadLine();


                // Validate data

                Users user = new Users(username,password,DateTime.Now);

                manager.Create(user);

                Console.WriteLine("Customer created successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Users Read()
        {
            try
            {
                Console.Write("Enter user id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Users user = manager.Read(id);

                if (user == null)
                {
                    throw new ArgumentException("User with that ID does not exist in the DB!");
                }

                Console.WriteLine("Username: {0}; Password: {1}; CreatedOn: {2}; UserId: {3}", user.UserName,
                    user.PasswordHash, user.CreatedOn, user.UserId);

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReadAll()
        {
            try
            {
                List<Users> users = (List<Users>)manager.ReadAll();

                for (int i = 0; i < users.Count; i++)
                {
                    Console.WriteLine("User #{0} Info", i + 1);
                    Console.WriteLine("Username: {0}; Password: {1}; CreatedOn: {2}; UserId: {3}", users[i].UserName,
                  users[i].PasswordHash, users[i].CreatedOn, users[i].UserId);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update()
        {
            try
            {
                Users user = Read();

                Console.Write("Change username or choose enter to leave the current value: ");
                string newUsername = Console.ReadLine();

                if (!string.IsNullOrEmpty(newUsername))
                {
                   user.UserName = newUsername;
                }

                Console.Write("Change password or choose enter to leave the current value: ");
                string password = Console.ReadLine();

                if (!string.IsNullOrEmpty(password))
                {
                    user.PasswordHash = password;
                }

                manager.Update(user);

                Console.WriteLine("Customer updated successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                Users user = Read();

                manager.Delete(user.UserId);

                Console.WriteLine("Customer deleted successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
