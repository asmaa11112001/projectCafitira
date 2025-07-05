using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CategoryServices
    {

            private readonly Context _context;

            public CategoryServices(Context context)
            {
                _context = context;
            }

            public List<Catigory> GetAll()
            {
                return _context.Cateigorys.ToList();
            }

        public void Add(Catigory category)
        {
            _context.Cateigorys.Add(category);
            _context.SaveChanges();
        }
    }
}
