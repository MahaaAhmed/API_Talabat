using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications
{
    public class SpecificationsEvalutor<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> IntialQuery , ISpecifications<T> specification)
        {
            var Query = IntialQuery;
            if (specification.criteria != null)
            {
                Query = Query.Where(specification.criteria);

            }
            Query = specification.Includes.Aggregate(Query , (CurrentQuery , include) => CurrentQuery.Include(include));
            return Query;

        }

    }
}
