using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zlm.Domain.Entities
{
    public class Product
    {
        /// <summary>
        /// 编号
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 产品描述
        /// </summary>
        public virtual string ProductDescript
        {
            get;
            set;
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public virtual string ProductName { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public virtual DateTime AddDate { get; set; }

        public virtual int IsDelete { get; set; }

    }
}
