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
        private readonly AddressRepository _addressRepository;

        public PropertyController(IWebHostEnvironment environment)
        {
            this._environment = environment;
            _propertyRepository = new PropertyRepository();
            _categoryRepository = new CategoryRepository();
            _addressRepository = new AddressRepository();
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
                Property = new Property(),
                Addresses = _addressRepository.RetrieveAll()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Property imovel)
        {
            // Recupera a categoria selecionada
            if (imovel.CategoriaId > 0)
            {
                imovel.Categoria = _categoryRepository.Retrieve(imovel.CategoriaId);
            }
            if (imovel.AddressId > 0)
            {
                imovel.Address = _addressRepository.Retrieve(imovel.AddressId);
            }

            _propertyRepository.Save(imovel);

            List<Property> imoveis = _propertyRepository.RetrieveAll();

            return View("Index", imoveis);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _propertyRepository.DeleteById(id);
            var imoveis = _propertyRepository.RetrieveAll();
            return View("Index", imoveis);
        }
    }
}
