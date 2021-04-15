using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zad5.Model;

namespace zad5.Servises
{
    public class DataBaseProductService
    {
        private readonly DbProductContext _context;
        public DataBaseProductService(DbProductContext context)
        {
            _context = context;
        }

        public IEnumerable<DbProducts> GetProducts()
        {
            var DbProductQuerry = from DbProduct in _context.DbProduct select DbProduct;
            return DbProductQuerry.ToList();
        }
    }
}
