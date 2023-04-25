using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications
{
    public class ProductWithTypeAndBrandSpecifictions:BaseSpecifictions<Product>
    {
        public ProductWithTypeAndBrandSpecifictions()
        {
            AddInclude(p => p.productType);
            AddInclude(p => p.productBrand);
        }


        public ProductWithTypeAndBrandSpecifictions(int id):base(p => p.Id ==id)
        {
            AddInclude(p => p.productType);
            AddInclude(p => p.productBrand);
        }
    }
}
