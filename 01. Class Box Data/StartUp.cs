using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{ 
    public class StartUp
    {
        static void Main()
        {

            try
            {
                double height = double.Parse(Console.ReadLine());
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                Box box = new Box(height, lenght, width);

                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

        }
    }
}
