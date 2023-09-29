using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class User
    {
        public int UserId { get; private set; }
        public string Login { get; private set; }
        public string PaswordUser { get; private set; }
        public bool IsAdmin { get; private set; }
        public List<Basket> basketList;

        public User(int userId, string login, string paswordUser, string isAdmin)
        {
            UserId = userId;
            Login = login;
            PaswordUser = paswordUser;
            IsAdmin = Convert.ToBoolean(isAdmin);
            basketList = new List<Basket>();
        }

        public void RemoveBasket(int productId)
        {
            foreach (var item in basketList)
            {
                if (item.ProductId == productId)
                {
                    basketList.Remove(item);
                    break;
                }
                    
            }
            
        }

        public void AddBasket(int productId)
        {
            bool isRepeated = false;
            foreach (var item in basketList) 
            {
                if(item.ProductId == productId)
                    isRepeated = true;
            }
            if (!isRepeated)
            {
                basketList.Add(new Basket(productId, 1));
            }
        }

        public bool CheckAddBasket(int productId)
        {
            bool isRepeated = false;
            foreach (var item in basketList)
            {
                if (item.ProductId == productId)
                    isRepeated = true;
            }
            if (!isRepeated)
            {
                return true;
            }
            return false;
        }

    }
}
