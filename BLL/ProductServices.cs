using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
  public  class ProductServices
    {

        private readonly Context _context;

        public ProductServices(Context context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.products.Include(p => p.Catigory).ToList();
        }

        public Product GetById(int id)
        {

            return _context.products.Include(p => p.Catigory).FirstOrDefault(p => p.ProductId == id);
        }

        public void Add(Product product)
        {
            _context.products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.products.Find(id);
            if (product != null)
            {
                _context.products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
