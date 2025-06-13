using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection.Models
{
    public class Coin
    {
        public string uuid { get; set; }          // Унікальний ідентифікатор
        public string country { get; set; }       // Країна
        public string name { get; set; }       // Ім'я
        public int year { get; set; }             // Рік випуску
        public decimal price { get; set; }        // Ціна
        public string metal { get; set; }         // Метал
        public long mintage { get; set; }         // Тираж
        public string description { get; set; }   // Опис
        public string path { get; set; }     // Шлях до зображення
    }
}
