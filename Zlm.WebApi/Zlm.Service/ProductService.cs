using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zlm.Domain;
using Zlm.Domain.Entities;

namespace Zlm.Service
{
    public class ProductService
    {
        private ProductDomain _pd = new ProductDomain();
        public IList<Product> GetCustomerList(Expression<Func<Product, bool>> where)
        {
            return _pd.GetCustomerList(where);
        }
    }
}
