using System;

namespace InterfaceSegregationPrinciple
{

    // Interface Segregation Principle
    // Keep your interfaces thin or fine-grained and don’t attach to them unused methods.
    // https://codeburst.io/understanding-solid-principles-interface-segregation-principle-b2d57026cf6c

    public class Document
    {
    }

    // Bad Practice: Violates the Interface Segregation Principle
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {
            //Some Implementation
        }

        public void Scan(Document d)
        {
            // Old Fashioned Printer doesn't have Scanning function
            // So just throw error
            throw new System.NotImplementedException();
        }

        public void Fax(Document d)
        {
            // Old Fashioned Printer doesn't have Fax function
            // So just throw error
            throw new System.NotImplementedException();
        }
    }


    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        public void Print(Document d)
        {
            // some implementation
        }

        public void Scan(Document d)
        {
            // some implementation

        }

        public void Fax(Document d)
        {
            // some implementation
        }
    }

    // Good Practice
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            // Some Implementation
        }

        public void Scan(Document d)
        {
            // Some Implementation
        }
    }

    // Good Practice
    public class MutilFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public MutilFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if (printer == null)
            {
                throw new ArgumentNullException(paramName: nameof(printer));
            }
            if (scanner == null)
            {
                throw new ArgumentNullException(paramName: nameof(scanner));
            }
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
