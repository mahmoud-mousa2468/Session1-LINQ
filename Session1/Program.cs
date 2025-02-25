namespace Session1
{
    internal class Program
    {
        // can't use var as return type or Parameter
        //public static var Print(var X)
        //{
        //    return X;
        //} 
        static void Main(string[] args)
        {
            // Implicitly-Type Local Variables [Var-Dynamic]

            // Var
            var Data01 = 1;

            // Compiler Can Detect The Datatype of the local variable based on initial value, At Compilation Time
            // must be initialization
            // can't initialization the local variable with null
            // can't change datatype of the local variable after initialization

            // Data01=12;//Invalid

            // dynamic : like var in JS
            dynamic Data02 = "Ahmed";
             Data02 = null;

            // CLR Detect the Datatype of the local variable based on last value, At Runtime
            // Don't Need To Be Initialized
            // Can initialized the local variable with Null
            // can change datatype of the local variable after initialization
            // can use dynamic keyword as return type or Parameter
            // Be Carefull when use Dynamic
            // Like var in JS Or Object in C#
            Console.WriteLine(Data02.GetType().Name);
            Data02 = 12;
            Data02 = 1.4;
            Data02 = 1.5f;
            Data02 = true;

            //var x=()=> Console.WriteLine("hello World");
            var x = delegate(){ Console.WriteLine("hello world"); };
            
            //dynamic x = delegate(){ Console.WriteLine("hello world"); };


        }
    }
}
