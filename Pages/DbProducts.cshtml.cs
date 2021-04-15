using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using zad5.Servises;
using zad5.Model;

namespace zad5.Pages
{
    public class DbProductsModel : PageModel
    { 
        public DataBaseProductService ProductService;
        public IEnumerable<DbProducts> Products { get; private set; }
        public DbProductsModel(DataBaseProductService productService)
        {
            ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
