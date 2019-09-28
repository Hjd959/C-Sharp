using System;



namespace Detemine_my_age

{
    class Test
    {
        static void Main(string[] args)
        {

            // n حساب العمر
            // Determin my age

            DateTime MyAge;

            // n البيانات المدخله نوع سترنق وانا ابيها داتا تايم لذالك لازم احولها الى نوع داتا تايب
            // Type ReadLine is string and me whent DataTime .. Must be transformation to DataTime
            MyAge =Convert.ToDateTime(Console.ReadLine());





            // n عشان اعرف عمرك لازم اعرف الوقت الحالي
            // when i now how old are you must be konw persent time

            // n بعد ذالك لازم ننقصها من العمر تقسيم ٣٦٠ يوم
            // after that must be subtract from my age and dvide 360 days

            // n بعد ذالك لازم نحولها
            // after that must be convert 
            int year =Convert.ToInt32(DateTime.Now.Subtract(MyAge).TotalDays / 360);
            Console.WriteLine("YYYY-MM-DD");
            Console.WriteLine("Your age is : ");

        }
    }
}