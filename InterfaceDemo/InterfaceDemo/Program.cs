namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Paint paint = new Paint();
            paint.Draw(new Circle());
            paint.Draw(new Rectangle());
            paint.Draw(new Square());
        }
    }
}
