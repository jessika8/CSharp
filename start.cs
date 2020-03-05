using System;

namespace cSharp
{
    class Room {
        public double length;
        public double height;
        public double width;
    }


    class Program
    {
       static void Main(string[] args)   // cant run withouth Main  //
        {
            // declared room1 & room2 to be instances/versions of the Room class
            Room Room1 = new Room();
            Room Room2 = new Room();
            double total = 0.0;
            String name = "Maarja";

            // room1 details
            Room1.height = 5.0;
            Room1.length = 20.0;
            Room1.width = 40.9;

            //room2 details
            Room2.height = 30.2;
            Room2.length = 12.6;
            Room2.width = 26.8;

            total = Room1.height + Room1.length + Room1.width;

            Console.WriteLine("The total is: {0} and my name is {1}", total, name);
            // Console.WriteLine("The total is " + total + ".");
            Console.ReadKey();  // waits me to press enter good for debuging

            Console.WriteLine("Hello World!");
        }
    }
}
