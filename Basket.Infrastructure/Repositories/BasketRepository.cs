using Basket.Core.Models;
using Basket.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Infrastructure.Repositories
{
    public class BasketRepository: IBasketRepository
    {
        private readonly BasketDbContext _context;

        public BasketRepository(BasketDbContext context)
        {
            _context = context;
        }

        public BasketModel Get(int id)
        {
            return _context.Basket.FirstOrDefault(b => b.Id == id);
        }

        public BasketModel Create(BasketModel model)
        {
            _context.Basket.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void Update(BasketModel model)
        {
            _context.Basket.Update(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var basket = _context.Basket.FirstOrDefault(b => b.Id == id);
            if(basket != null)
            {
                _context.Basket.Remove(basket);
                _context.SaveChanges();
            }
        }
    }
}
