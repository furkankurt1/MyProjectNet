using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryProductDal : IProductDal
    {

        private List<Product> _products;

        public InMemoryProductDal(){
            _products = new List<Product>()
            {
                new Product() {CategoryId = 1, ProductId = 1, ProductName = "Bardak", UnitsInStock = 150, UnitPrice = 100},
                new Product() {CategoryId = 1, ProductId = 2, ProductName = "Kamera", UnitsInStock = 10, UnitPrice = 100},
                new Product() {CategoryId = 2, ProductId = 3, ProductName = "At", UnitsInStock = 5, UnitPrice = 75},
                new Product() {CategoryId = 2, ProductId = 4, ProductName = "Eşek", UnitsInStock = 2, UnitPrice = 1000},
                new Product() {CategoryId = 3, ProductId = 5, ProductName = "Katır", UnitsInStock = 15, UnitPrice = 50}
            };
        }

        public List<Product> GetAll(){
            return _products;
        }

        public void Add(Product product){
            _products.Add(product);
        }

        public void Update(Product product){
            Product obj = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            obj.CategoryId = product.CategoryId;
            obj.ProductId = product.ProductId;
            obj.ProductName = product.ProductName;
            obj.UnitsInStock = product.UnitsInStock;
            obj.UnitPrice = product.UnitPrice;
        }

        //2.10 7.d
        public void Delete(Product product){
            _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GetAllByCategory(int categoryID){
            return _products.Where(p => p.CategoryId == categoryID).ToList();
        }

    }

}
