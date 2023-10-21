using Basket.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Interfaces
{
    public interface IBasketService
    {
        BasketModel Create(BasketModel model);
        void Delete(int id);
        BasketModel Get(int id);
        void Update(BasketModel model);
    }
}
