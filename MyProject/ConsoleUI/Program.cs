using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI {
    class Program {

        static void Main(string[] args){
            ProductManager newManager = new ProductManager(new EfProductDal());
            foreach (var VARIABLE in newManager.GetAll())
            {
                Console.WriteLine(VARIABLE.ProductName);
            }
        }

    }
}
