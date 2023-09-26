using System.Collections.Generic;
using System.Linq;
namespace ChatApi.Services
{
    public class ChatService
    {
        private static readonly Dictionary<string, string> Users = new Dictionary<string,string>();
        public bool AddUserToLis(string userToAdd)
        {
            lock(Users)
            {
                foreach(var user in Users)
                {
                    if(user.Key.ToLower()==userToAdd.ToLower())
                    {
                        return false;
                    }
                }
                Users.Add(userToAdd, null);
                return true;
            }

        }
    }
}
