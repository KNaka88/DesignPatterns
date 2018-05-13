namespace LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {    
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Width = base.Height = value; }
        }


        // Violation of Liskov Substitution Principle
        // public new int Width
        // {
        //     set { base.Width = base.Height = value; }
        // }

        // public new int Height
        // {
        //     set { base.Width = base.Height = value; }
        // }
    }
}