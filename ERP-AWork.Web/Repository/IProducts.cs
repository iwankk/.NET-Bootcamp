using ERP_AWork.Web.Models;
using System.Collections.Generic;

namespace ERP_AWork.Web.Repository
{
    public interface IProducts
    {
        public List<Products> GetAll();
    }
}
