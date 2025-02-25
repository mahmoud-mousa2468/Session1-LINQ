namespace Session1
{
    internal class Program
    {
        #region Implicitly-Type Local Variables [var - dynamic]
        // can't use var as return type or Parameter
        //public static var Print(var X)
        //{
        //    return X;
        //} 
        // can use var as return type or Parameter
        //public static dynamic Print(dynamic X)
        //{
        //    return X;
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Implicitly-Type Local Variables [var - dynamic]
            //// Implicitly-Type Local Variables [Var-Dynamic]

            //// Var
            //var Data01 = 1;

            //// Compiler Can Detect The Datatype of the local variable based on initial value, At Compilation Time
            //// must be initialization
            //// can't initialization the local variable with null
            //// can't use var as return type or Parameter
            //// can't change datatype of the local variable after initialization

            //// Data01=12;//Invalid

            //// dynamic : like var in JS
            //dynamic Data02 = "Ahmed";

            //// CLR Detect the Datatype of the local variable based on last value, At Runtime
            //// Don't Need To Be Initialized
            //// Can initialized the local variable with Null
            //// can change datatype of the local variable after initialization
            //// can use dynamic keyword as return type or Parameter
            //// Be Carefull when use Dynamic
            //// Like var in JS Or Object in C#

            ////Data02 = null;
            ////Console.WriteLine(Data02.GetType().Name);  // Unhandling Exeption

            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4;
            //Data02 = 1.5f;
            //Data02 = true;

            ////var x=()=> Console.WriteLine("hello World");
            //var x = delegate () { Console.WriteLine("hello world"); };

            //// can't use it in delegate
            ////dynamic x = delegate(){ Console.WriteLine("hello world"); }; 
            #endregion

            #region 02 Anonymous Type
            //// Anonymous type
            ////Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 1200 };

            //var E01 = new { Id = 1, Name = "Ahmed", Salary = 1200.0m };
            //var E02 = new { Name = "Ahmed", Id = 1, Salary = 1200.0m };
            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            ////E01.Id = 2;//Invalid Cause Anonymous type is immutable so can't change it's value after creation

            //Console.WriteLine(E01.GetType().Name);//<>f__AnonymousType0`3
            //Console.WriteLine(E02.GetType().Name);//<>f__AnonymousType0`3
            //Console.WriteLine(E01.GetHashCode());// 123859993
            //Console.WriteLine(E02.GetHashCode());// 123859993
            //// The Same Anonymous Type and HashCode As Long As:
            //// 1- The Same property name [Case Sensitive]
            //// 1- The Same property order

            //Console.WriteLine(E01); // { Id = 1, Name = Ahmed, Salary = 1200.0 }
            //// compiler will override on Tostring
            #endregion
        }
    }
}
