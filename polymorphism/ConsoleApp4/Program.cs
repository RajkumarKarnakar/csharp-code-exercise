namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Shape[] objshape= new Shape[3];
            objshape[0] = new Shape();
            objshape[1] = new Circle();
            objshape[2] = new Rectangle();
            foreach (Shape shape in objshape)
            {
                shape.draw();
            }
        }
    }
    public class Shape
    {
        public virtual void draw()=> Console.WriteLine("in shape draw");
    }
    public class Circle : Shape
    {
        public override void draw()=> Console.WriteLine("in draw of circle");
    }
    public class Rectangle : Shape
    { 
    public override void draw() => Console.WriteLine("in rectangle draw");
    }
}
