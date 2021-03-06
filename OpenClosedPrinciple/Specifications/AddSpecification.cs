using System;

namespace OpenClosedPrinciple.Specifications
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> scond)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(second));
            this.second = first ?? throw new ArgumentNullException(paramName: nameof(second));
        }
        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}