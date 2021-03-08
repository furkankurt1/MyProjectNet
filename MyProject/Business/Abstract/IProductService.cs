using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{

    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllbyProductId(int id);

        List<Product> GetByProductPrice(decimal min, decimal max);
    }

}
