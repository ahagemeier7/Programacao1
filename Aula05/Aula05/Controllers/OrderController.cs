using Aula05.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Aula05.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderRepository _orderRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly ProductRepository _productRepository;

        private readonly IWebHostEnvironment environment;
        public OrderController(
            IWebHostEnvironment environment
        )
        {
            _productRepository = new ProductRepository();
            _orderRepository = new OrderRepository();
            _customerRepository = new CustomerRepository();
            this.environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_orderRepository.RetrieveAll());
        }

        [HttpGet]
        public IActionResult Create() { 
            OrderViewModel viewModel = new();
            viewModel.Customers = _customerRepository.RetrieveAll();

            var products = _productRepository.RetrieveAll();

            List<SelectedItem> items = new();

            foreach (var product in products) {
                items.Add(new SelectedItem() { 
                    OrderItem = new() { 
                        Product = product 
                    } 
                });               
            }
            viewModel.SelectedItems = items;

            return View(viewModel);
        }
    }
}
