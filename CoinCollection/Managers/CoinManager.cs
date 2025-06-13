using CoinCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoinCollection.Managers
{
    public class CoinsManager
    {
        private readonly string _filePath;
        public List<Coin> Coins { get; private set; } = new List<Coin>();

        public CoinsManager(string filePath)
        {
            _filePath = filePath;
        }

        public async Task LoadAsync()
        {
            if (File.Exists(_filePath))
            {
                var json = await File.ReadAllTextAsync(_filePath);
                Coins = JsonSerializer.Deserialize<List<Coin>>(json) ?? new List<Coin>();
            }
        }

        public async Task SaveAsync()
        {
            var json = JsonSerializer.Serialize(Coins, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_filePath, json);
        }

        public void AddCoin(Coin coin)
        {
            Coins.Add(coin);
        }

        public void RemoveCoin(string uuid)
        {
            bool compare(Coin c)
            {
                return c.uuid == uuid;
            }

            Coins.RemoveAll(compare);

        }

        public Coin? GetCoin(string uuid)
        {
            return Coins.Find(c => c.uuid == uuid);
        }
    }
}
