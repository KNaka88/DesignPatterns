using System.Collections.Generic;
using OpenClosedPrinciple.Specifications;

namespace OpenClosedPrinciple.Filters
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}