using Microsoft.AspNetCore.Mvc;
using Modelo;
using Repository;

namespace Aula05.Controllers
{
    public class ProductsController : Controller
    {
        private ProductRepository _productRepository;

        public ProductsController()
        {
            _productRepository = new ProductRepository();
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<Product> customers =
                _productRepository.RetrieveAll();

            return View(customers);
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            _productRepository.Save(p);

            List<Product> customers =
                _productRepository.RetrieveAll();

            return View("Index", customers);
        }
    }
}
