using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection.Models
{
    public class User
    {
        public string uuid { get; set; }               // Унікальний ідентифікатор
        public string country { get; set; }            // Країна
        public string name { get; set; }               // Ім'я

        public string email { get; set; }

        public string phone { get; set; }      // Контактні дані
        public List<string> coins { get; set; }        // Список UUID монет
    }
}
