using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection.Models
{
    public class User
    {
        public string Uuid { get; set; }               // Унікальний ідентифікатор
        public string Country { get; set; }            // Країна
        public string Name { get; set; }               // Ім'я
        public ContactInfo Contacts { get; set; }      // Контактні дані
        public List<string> Coins { get; set; }        // Список UUID монет
    }
}
