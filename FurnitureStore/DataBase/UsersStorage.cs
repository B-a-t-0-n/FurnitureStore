using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class UsersStorage
    {
        private List<User> ListUsers;

        private static UsersStorage instance = new UsersStorage();

        public UsersStorage() 
        {
            ListUsers = new List<User>();
        }

        public UsersStorage(List<User> users)
        {
            this.ListUsers = users;
        }

        public static UsersStorage GetInstance()
        {
            return instance;
        }

        public List<User> GetListUsers()
        {
            return ListUsers;   
        }
    }
}
