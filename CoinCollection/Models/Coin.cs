using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection.Models
{
    public class Coin
    {
        public string Uuid { get; set; }          // Унікальний ідентифікатор
        public string Country { get; set; }       // Країна
        public string Nominal { get; set; }       // Номінал
        public int Year { get; set; }             // Рік випуску
        public decimal Price { get; set; }        // Ціна
        public string Metal { get; set; }         // Метал
        public long Mintage { get; set; }         // Тираж
        public string Description { get; set; }   // Опис
        public string ImagePath { get; set; }     // Шлях до зображення
    }
}
