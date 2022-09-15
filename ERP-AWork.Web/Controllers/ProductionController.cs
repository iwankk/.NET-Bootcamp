using ERP_AWork.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ERP_AWork.Web.Controllers
{
    public class ProductionController : Controller
    { 
        private readonly IProducts _IProducts;

        public ProductionController(IProducts iProducts)
        {
            _IProducts = iProducts;
        }

        public IActionResult ListProduction()
        {
            return View("ListProduction",_IProducts.GetAll());
        }
    }
}
