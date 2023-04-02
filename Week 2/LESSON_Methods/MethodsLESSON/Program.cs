namespace MethodsLESSON
{//Method made up of signature and body

    /*  public:	the same assembly and other assemblies that reference it
        private:	the same class or struct
        protected:	the same class, or a class derived from it
        internal:	the same assembly
   
        private is the default*/

    //visibility, return type, name, parameters
    internal class Program
    {
        static void Main(string[] args)
        {
            Method(2, "hi");

            //named parameters
            Console.WriteLine(OrderPizza(pineapple: false, anchovies: true));

            var myTuple = (firstName: "John", lastName: "Smith", age: 33);
            Console.WriteLine(myTuple.firstName);

            //bool success = MyTryParse("5", out int myOutput);

            //method returning tuple of days and weeks
            Console.WriteLine($"(weeks, days) = {CalculateDaysAndWeeks(15)}");

        }

        private static (int weeks, int days) CalculateDaysAndWeeks(int days)
        {
            int noWeeks = days / 7;
            int remainingDays = days % 7;
            return (weeks: noWeeks, days: remainingDays);
        }

        private static bool MyTryParse(string v, out int myOutput)
        {
            throw new NotImplementedException();
        }




        //Default values must be last
        private static int Method(int x, string y = "Default")
        {
            Console.WriteLine(y);
            return x;
             
        }
        public static string OrderPizza(bool anchovies, bool pineapple, bool mushrooms = false)
        {
            var pizza = "Pizza with tomato sauce, cheese, ";
            if (anchovies) pizza += "anchovies, ";
            if (pineapple) pizza += "pineapple, ";
            if (mushrooms) pizza += "mushrooms, ";
            return pizza;
        }

        private static (string firstName, string lastName, int age) CreateHuman(string fName, string lName, int a)
        {
            return (firstName: fName, lastName: lName, age: a);
        }


    }

}