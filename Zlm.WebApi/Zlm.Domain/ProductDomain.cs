using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zlm.Domain.Entities;
using Zlm.Nhibernate;
using NHibernate.Linq;

namespace Zlm.Domain
{
    public class ProductDomain
    {
        private NHibernateHelper _nhi = new NHibernateHelper();

        /// <summary>
        /// 根据条件得到客户信息集合
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns>客户信息集合</returns>
        public IList<Product> GetCustomerList(Expression<Func<Product, bool>> where)
        {
            try
            {
                ISession session = _nhi.GetSession();
                return session.Query<Product>().Where(where).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
