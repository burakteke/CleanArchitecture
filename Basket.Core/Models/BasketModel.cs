using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Core.Models
{
    public class BasketModel
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
    }
}
