using System;

namespace LiskovSubstitutionPrinciple
{

    // The Liskov Substitution Principle (LSP): 
    //      functions that use pointers to base classes 
    //      must be able to use objects of derived classes without knowing it.
    // https://codeburst.io/understanding-solid-principles-liskov-substitution-principle-e7f35277d8d5
    class Program
    {
        // You should be able 

        static public int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

            Rectangle square = new Square();
            square.Width = 4;
            Console.WriteLine($"{square} has area {Area(square)}");
        }
    }
}
