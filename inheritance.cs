using System;

namespace cSharp_inheritance
{
    class ObjectWeWillMessAroundWith 
    {
        public void theWidth(int myWidth) // function = method. use method with C#
        {
            width = myWidth;
        }
        public void theHeight(int myHeight) 
        {
            height = myHeight;
        }

        protected int width;
        protected int height;
    }

        class Square: ObjectWeWillMessAroundWith
        // subclass created here
        {
            public int area()
            {
                return (width * height);
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            //new instance of square: mySquare
            Square mySquare = new Square();  
            mySquare.theHeight(10);
            mySquare.theWidth(10);
            Console.WriteLine("My square has a value of: {0}", mySquare.area());
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
