using System;



namespace TypeConversion

{
    class TypeConversion
    {
        static void Main(string[] args)
        {

            // n الان عندي هذا الكود نوع سترنق وحطيته في متغير انتجر لو اشغل البرنامج يطلع لي خطاء لذالك لازم احوله الى نفس النوع
            // i have value type string and another type intger when i run project is faill you must be transformation sme type


            // this Error
            // n هذا الكود غير صحيح
            // string sAge = "26";
            // int age;
            //  age = sAge;



            // this is true
            // n هذا الكود صحيح
            string sAge = "26";
            int age;
            age =Convert.ToInt32( sAge);
        }
    }
}