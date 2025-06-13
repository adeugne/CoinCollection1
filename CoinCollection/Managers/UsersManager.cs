using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CoinCollection.Models;

namespace CoinCollection.Managers
{
    public class UsersManager 
    {
        private readonly string _filePath;
        public List<User> Users { get; private set; } = new List<User>();

        public UsersManager(string filePath)
        {
            _filePath = filePath;
        }

        public async Task LoadAsync()
        {
            if (File.Exists(_filePath))
            {
                var json = await File.ReadAllTextAsync(_filePath);
                Users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
        }

        public async Task SaveAsync()
        {
            var json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_filePath, json);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUser(string uuid)
        {
            Users.RemoveAll(u => u.uuid == uuid);
        }

        public void RemoveUserByIndex(int index)
        {
            Users.RemoveAt(index);  
        }

        public User? GetUser(string uuid)
        {
            return Users.Find(u => u.uuid == uuid);
        }
    }
}
