using Basket.Application.Interfaces;
using Basket.Core.Models;
using Basket.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Services
{
    public class BasketService: IBasketService
    {
        private readonly IBasketRepository _basketRepository;

        public BasketService(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public BasketModel Get(int id)
        {
            return _basketRepository.Get(id);
        }

        public BasketModel Create(BasketModel model)
        {
            return _basketRepository.Create(model);
        }

        public void Update(BasketModel model)
        {
            _basketRepository.Update(model);
        }

        public void Delete(int id)
        {
            _basketRepository.Delete(id);
        }
    }
}
