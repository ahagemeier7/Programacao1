using Microsoft.AspNetCore.Mvc;
using Modelo;
using Repository;
using TrabalhoImobiliaria.ViewModels;

namespace TrabalhoImobiliaria.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly PropertyRepository _propertyRepository;
        private readonly CategoryRepository _categoryRepository;

        public PropertyController(IWebHostEnvironment environment)
        {
            this._environment = environment;
            _propertyRepository = new PropertyRepository();
            _categoryRepository = new CategoryRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Property> imoveis = _propertyRepository.RetrieveAll();

            return View(imoveis);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new PropertyViewModel()
            {
                Categories = _categoryRepository.RetrieveAll(),
                Property = new Property()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Property imovel)
        {
            _propertyRepository.Save(imovel);

            List<Property> imoveis =
                _propertyRepository.RetrieveAll();

            return View("Index", imoveis);
        }


    }
}
