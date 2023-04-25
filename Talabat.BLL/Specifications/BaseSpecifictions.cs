 using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.BLL.Specifications
{
    public class BaseSpecifictions<T> : ISpecifications<T>
    {
        public BaseSpecifictions()
        {

        }
        public Expression<Func<T, bool>> criteria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();

        public BaseSpecifictions(Expression<Func<T, bool>> criteria)
        {
            this.criteria = criteria;
        }


        public void AddInclude(Expression<Func<T, object>> Include)
        {

            Includes.Add(Include);
        }
    }
}
