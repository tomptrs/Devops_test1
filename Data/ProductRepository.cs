using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ProductRepository : IProductRepository
    {
        MyDbContext myContext;
        public ProductRepository(MyDbContext context)
        {
            myContext = context;
        }
        public void Save(Product product)
        {
            myContext.Add(product);
        }

        public void SaveChanges()
        {
            myContext.SaveChanges();
        }
    }
}
