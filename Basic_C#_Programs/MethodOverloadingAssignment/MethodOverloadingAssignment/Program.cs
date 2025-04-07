using System;


namespace MethodOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class called MathMethods that contains 3 methods

            MathMethods math = new MathMethods();


            //Calling first method with int parameter
            
            
            //int math1 = MathMethods.MathOp(9); could be used if we added static prefix to MathOp method then we would not in to instantiate above
            
            Console.WriteLine(math.MathOp(12));

            //Calling second method with decimal parameter
            //int math2 = MathMethods.MathOp(144m);
            Console.WriteLine(math.MathOp(90m));

            //Calling thirsd method with string parameter
            //int math3 = MathMethods.MathOp("12");
            Console.WriteLine(math.MathOp("4"));
        }
    }
}
