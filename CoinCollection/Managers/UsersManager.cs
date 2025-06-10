using CoinCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoinCollection.Managers
{
    public class UsersManager
    {
        private const string UsersFilePath = "files/users.json";
        private List<User> users;

        public UsersManager()
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            if (File.Exists(UsersFilePath))
            {
                string json = File.ReadAllText(UsersFilePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
        }

        public void SaveUsers()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(UsersFilePath, json);
        }

        public List<User> GetAllUsers() => users;

        public void AddUser(User newUser)
        {
            users.Add(newUser);
            SaveUsers();
        }

        public void UpdateUser(User updatedUser)
        {
            var index = users.FindIndex(u => u.Uuid == updatedUser.Uuid);
            if (index >= 0)
            {
                users[index] = updatedUser;
                SaveUsers();
            }
        }

        public void DeleteUser(string uuid)
        {
            users.RemoveAll(u => u.Uuid == uuid);
            SaveUsers();
        }
    }
}
