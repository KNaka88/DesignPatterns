using System;

namespace DependencyInversionPrinciple
{

    // Dependency Inversion Principle:
    // High-level modules should not depend upon low-level modules. Both should depend upon abstractions.
    // Abstractions should not depend upon details. Details should depend upon abstractions.
    // https://www.intertech.com/Blog/the-dependency-inversion-principle-with-c-examples/
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new Person {Name = "John"};
            var child1 = new Person {Name = "Chris"};
            var child2 = new Person {Name = "Matt"};

            // low-level module
            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);
            new Research(relationships);
        }
    }
}
