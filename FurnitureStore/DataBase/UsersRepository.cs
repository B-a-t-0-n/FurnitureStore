using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class UsersRepository
    {
        private List<User> usersStorage;

        public UsersRepository()
        {
            usersStorage = UsersStorage.GetInstance().GetListUsers();
        }

        public List<User> GetAll()
        {
            return usersStorage;
        }

        public User GetUser(int id)
        {
            User user = null;
            foreach (var us in usersStorage)
            {
                if (us.UserId == id)
                {
                    user = us;
                }
            }
            return user;
        }

        public int GetIdLastUser()
        {
            if(usersStorage.Count > 0)
            {
                return usersStorage[usersStorage.Count - 1].UserId;
            }
            else { return 0; }
        }

        public void Add(User user)
        {
            //можно добавить вывод информации
            usersStorage.Add(user);
        }

        public void Remove(User user)
        {
            //можно добавить вывод информации
            usersStorage.Remove(user);
        }

        public void Update(int idUser, string meaning, string inMeaning)
        {
            User user = usersStorage[idUser - 1];
            User userCopy = user;

            switch (meaning)
            {
                case "login":
                    userCopy = new User(user.UserId, inMeaning, user.PaswordUser, user.IsAdmin.ToString());
                    break;

                case "password":
                    userCopy = new User(user.UserId, user.Login, inMeaning, user.IsAdmin.ToString());
                    break;
                case "admin":
                    userCopy = new User(user.UserId, user.Login, user.PaswordUser, inMeaning);
                    break;
            }

            //добавить информацию об обновлении
            usersStorage[user.UserId - 1] = userCopy;
        }

    }
}
