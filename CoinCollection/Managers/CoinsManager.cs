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
        private const string CoinsFilePath = "files/coins.json";
        private List<Coin> coins;

        public CoinsManager()
        {
            LoadCoins();
        }

        public void LoadCoins()
        {
            if (File.Exists(CoinsFilePath))
            {
                string json = File.ReadAllText(CoinsFilePath);
                coins = JsonSerializer.Deserialize<List<Coin>>(json) ?? new List<Coin>();
            }
            else
            {
                coins = new List<Coin>();
            }
        }

        public void SaveCoins()
        {
            string json = JsonSerializer.Serialize(coins, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(CoinsFilePath, json);
        }

        public List<Coin> GetAllCoins() => coins;

        public void AddCoin(Coin newCoin)
        {
            coins.Add(newCoin);
            SaveCoins();
        }

        public void UpdateCoin(Coin updatedCoin)
        {
            var index = coins.FindIndex(c => c.Uuid == updatedCoin.Uuid);
            if (index >= 0)
            {
                coins[index] = updatedCoin;
                SaveCoins();
            }
        }

        public void DeleteCoin(string uuid)
        {
            coins.RemoveAll(c => c.Uuid == uuid);
            SaveCoins();
        }
    }
}
