namespace OpenClosedPrinciple.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}