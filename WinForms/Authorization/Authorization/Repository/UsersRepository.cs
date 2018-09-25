using Authorization.UsersInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Authorization.Repository
{
    public static class UsersRepository
    {
        public static string filePath = "data.dat";
        private static BindingList<UserInfo> users;
        static UsersRepository()
        {
            users = new BindingList<UserInfo>() { };
        }

        public static void AddUser(UserInfo user)
        {
            users.Add(user);
        }
        public static void Save()
        {            
            using (FileStream file = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(file, users);
            }
        }
        /// <summary>
        /// Load users list for checking
        /// </summary>
        /// <returns></returns>
        public static BindingList<UserInfo> LoadForChecking()
        {            
            if (File.Exists(filePath))
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    users = binFormatter.Deserialize(file) as BindingList<UserInfo>;
                    
                }
            }
            else
            {               
                using (FileStream file = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    binFormatter.Serialize(file, "");
                }
            }
            return users;            
        }
    }
}
