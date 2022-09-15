using ERP_AWork.Web.Models;
using System.Collections.Generic;

namespace ERP_AWork.Web.Repository
{
    public class ProductsRepository : IProducts
    {
        public List<Products> GetAll()
        {
            var ListOfProducts = new List<Products>() {
            new Products { ProductId = 1, ProductName = "Baud", ProductCategory = "Sparepart" },
            new Products { ProductId = 2, ProductName = "Roller AS", ProductCategory = "Sparepart" },
            new Products { ProductId = 3, ProductName = "ShockBreaker", ProductCategory = "Sparepart" },
<<<<<<< HEAD
            new Products { ProductId = 5, ProductName = "gerandong", ProductCategory = "bolokokok" }
=======
            new Products { ProductId = 6, ProductName = "Oli", ProductCategory = "Sparepart" }
>>>>>>> ae36e0c6a156de8322bcf5e1ad7eaf11b7b825ad

        };
            return ListOfProducts;
            //throw new System.NotImplementedException();
        }
    }
}
