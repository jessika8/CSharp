using System;

namespace cSharp_encapsulation
{
    class AreaClass
    {
        
        public double width;
        public double length;
        public double age = 30.2;
        public string userInput;
        public double Area()
        {
            return width * length;
        }

        public void InsormationDisplayed()
        {
            Console.WriteLine("Width = {0}", width);
            Console.WriteLine("Length = {0}", length);
            Console.WriteLine("Our area is {0}", Area());
        }
        
        public void userDetails()
        {
            double myDouble = 44.0;
            int myInt = 44;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToSingle(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
            // Console.WriteLine("Please enter your user details");
            // userInput = Console.ReadLine();
    
            // if(Convert.ToDouble(userInput) == age)
            // {
            //     Console.WriteLine("Yes! It is true!");
            // }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            AreaClass myShape = new AreaClass();  // new instants 
            myShape.width = 12.94;
            myShape.length = 6.87;
            myShape.InsormationDisplayed();
            myShape.userDetails();
            Console.ReadKey();
        }
    }
}
}
