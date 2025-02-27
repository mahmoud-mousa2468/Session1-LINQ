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

            #region Extension Methods
            // use it through object of type (int,long or any type based on the fun return type)
            //int Number = 12345;
            //var result = Number.Reverse();
            //Console.WriteLine(result);

            //long Lnumber = 12345;
            //var Lresult = Lnumber.Reverse();
            //Console.WriteLine(Lresult);
            #endregion

            #region LINQ
            // LINQ: Language Integrated Query
            //     : 40+ Extension Methods (LINQ operators) Against Any Data [Data in Sequence]
            //     : Regardless Data Store
            //     : 13 Category
            //     : LINQ Operators Exists in Built-in Class "Enumerable"


            // Sequence : Object From Class Implement Interface "IEnumerable"
            // Local Sequence : L2O,L2XML
            // Remote Sequence: L2EF

            // Input Sequence -> LINQ Operator -> OutPut Sequence
            // Input Sequence -> LINQ Operator -> One Value
            //                -> LINQ Operator -> OutPut Sequence

            // Input Sequence -> LINQ Operator -> OutPut Sequence
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            // Input Sequence -> LINQ Operator -> One Value
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Enumerable.Any(Numbers, N => N % 2 == 0);
            //Console.WriteLine(Result);

            //                -> LINQ Operator -> OutPut Sequence
            //var Result = Enumerable.Range(1,100);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region LINQ Syntax
            // 1- Fluent Syntax
            // use LINQ Methods

            // 1.1 LINQ Operator as=> Class Member Method Through Class "Enumerable"
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            // 1.2. LINQ Operator as => Extension Method Through Sequence [Recommended]
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Numbers.Where(N => N % 2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            // 2. Query Syntax [Query Expression] Like SQL Style
            // Start with From
            // End Select or group By
            // Query Syntax easier than Fluent (join, into,Group By,Into)

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = from X in Numbers
            //             where X % 2 == 0
            //             select X;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region LINQ Execution Ways
            // LINQ Execution Ways 
            // 1. Differed Execution Way : 10 Category 
            // 2. Immediate Execution Way: 3 Category [Elements Operator, Casting Operators, Aggregate Operators]

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Numbers.Where(N => N % 2 == 0); // Differed
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (var item in Result) // here
            //{
            //    Console.WriteLine($"{item}");
            //}

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Numbers.Where(N => N % 2 == 0).ToList(); // Immediate
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (var item in Result) 
            //{
            //    Console.WriteLine($"{item}");
            //}

            #endregion

            #region Setup Data
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);
            ////var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);
            //var Result = ListGenerator.CustomerList.Where(C => C.City == "Cairo");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
