using System;



namespace Operators

{
    class Test
    {
        static void Main(string[] args)
        {
            // n طريقة جمع عددين

            double x, y, r;


            Console.Write("this is Calcution \n X: ");



            // n البانات القادمه من نوع سترنق الان لازم احولها الى نوع دبل
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            r = x + y;
            Console.WriteLine(Convert.ToSingle(r)); 

        }
    }
}