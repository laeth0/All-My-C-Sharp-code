using FinalAdvancedC_.Delegates;

namespace FinalAdvancedC_
{
    public class Program
    {
        #region BuiltIn Delegate
        //public delegate bool filter<in T>(T num);//Generic Delegate  
        #endregion
        #region Delegate
        //public delegate List<int> checkNumber(List<int> nums);

        ////public static void ProccessNumbers(List<int> nums, checkNumber check)
        ////{
        ////    foreach (int num in nums)
        ////    {
        ////        if (check(num))
        ////            Console.WriteLine(num);
        ////    }
        ////} 
        #endregion
        static void Main(string[] args)
        {
            #region Delegate 
            //Delegates => Container for store Functions
            //Anonymous Delegate

            //Employee[] employees = new Employee[]
            //{
            //    new Employee{Id=1,Name="Ahmed",Salary=6000},
            //    new Employee{Id=2,Name="Mona",Salary=5000},
            //    new Employee{Id=3,Name="Hazem",Salary=10000},
            //    new Employee{Id=4,Name="Marwa",Salary=8000},
            //    new Employee{Id=5,Name="Nasser",Salary=7000},
            //    new Employee{Id=6,Name="Mohamed",Salary=3000},
            //    new Employee{Id=7,Name="Karem",Salary=4000},
            //    new Employee{Id=8,Name="Rana",Salary=15000},
            //    new Employee{Id=9,Name="Salma",Salary=25000},
            //    new Employee{Id=10,Name="Mahmoud",Salary=27000},

            //};
            //Report report =new Report();

            ////report.ProccessEmployee(employees,IsGreaterThan6000);
            ////report.ProccessEmployee(employees, IsLessThan10000);
            ////Lambda Expression =>  
            // report.ProccessEmployee(employees, (Employee employee) =>  employee.Salary > 6000; );

            //  List<int> Numbers =new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };




            //List<int> Result =  CN.Invoke(Numbers);
            //  foreach(int i in Result)
            //      Console.WriteLine(i);

            //ProccessNumbers(Numbers, CN);
            #endregion

            #region Generic Delegate
            //List<int> numbers = new List<int>() { 2, 5, 6, 7, 9, 1, 3, 10, 4, 8 };

            //Console.WriteLine("Number Less than 6");
            //PrintNumber(numbers, n => n < 6);
            //Console.WriteLine("Number Less than 7");
            //PrintNumber(numbers, n => n > 7);
            //Console.WriteLine("Even Numbers");
            //PrintNumber(numbers, n => n%2==0);
            //
            //List<double> DubleNumbers = new List<double>() { 2.5, 5.4, 6.6, 7.7, 9.8, 1.9, 3.4, 10.55, 4.74, 8.88 };

            //PrintNumber(DubleNumbers, n => n >= 5.5);
            #endregion

            #region Built In Delegates
            //Built In Generic Delegates 3 (Action - Func - Predicate)
            //Action => Paramaters if exsist (from 1 to 16) || Void

            //Action<string> action = Print;
            //action("Ahmed");

            //Func =>May Have Paramters from 1 to 16  || Any Type You Need (Must)

            //Func<int, int, int> Functest = add;
            //   Console.WriteLine(Functest(1, 1)); 

            //Predicate => 1 paramter (Must) any Type ||return BOOL

            //Predicate<int> predicate = IsEvenNumber;
            //Console.WriteLine(predicate(10)); 

            // List<int> numbers = new List<int>() { 2, 5, 6, 7, 9, 1, 3, 10, 4, 8 };

            //List<int>EvenNumbers =  numbers.FindAll( N => N % 2 == 0);

            // foreach(int n in EvenNumbers) {
            //     Console.WriteLine(n);
            // }
            #endregion

            #region Extention Methods
            //Extention Methods => method 

            //string originalString = "hello, world";

            //string truncatedString = originalString.Truncate(5);

            //string ReversedString = originalString.Reverse();

            //Console.WriteLine(ReversedString); 
            #endregion

            #region Implictly Types [var /dynamic]
            //variable type is unkown
            // var Name ="John";//String =>compliation Time
            //Var Must Be Initilize Variable 
            // Inialize with Null;
            //Can't change it's Type After Inialization //Strogly Typed
            // var numbers = new[] { 1, 2, 3, 4, 5, 6, };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //dynamic Name; //not Must Be Inialize => Clr know type of it at runtime 
            //Name = null;//Weakly Typed
            //Name = 5;
            //Name = "Ahmed";
            //Console.WriteLine(Name);
            #endregion

            #region Anonymous Type
            //Anonymous Types are Read only,you Can't Modify thier Prop
            var person = new
            {
                FirstName = "Ahmed",
                LastName= "Nasser",
                Age = 30
            };
            var Person2 = new
            {
                LastName = "Nasser",
                FirstName = "Ahmed",
                Age = 30
            };
          Console.WriteLine(person.GetType().Name);
            Console.WriteLine(Person2.GetType().Name);


            /// Console.WriteLine(person.FirstName);

            #endregion

        }
        #region Delegate
        //public static bool IsGreaterThan6000(Employee employee)
        //{
        //    return employee.Salary > 6000;
        //}
        //public static bool IsLessThan10000(Employee employee)
        //{
        //    return employee.Salary < 10000;
        //}
        //public static bool IsBetween10000and20000(Employee employee)
        //{
        //    return employee.Salary > 10000 && employee.Salary < 20000 ;
        //}

        //public static List<int> GetEvenNumber(List<int> num)
        //{
        //    List<int> result =new List<int>();
        //   foreach(int i in num)
        //    {
        //        if (i % 2 == 0)
        //            result.Add(i);
        //    }

        //   return result;

        //}
        //public static List<int> GetOddNumber(List<int> num)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int i in num)
        //    {
        //        if (i % 2 == 1)
        //            result.Add(i);
        //    }

        //    return result;

        //} 
        #endregion

        #region Generic Delegate
        //static void PrintNumber<T>(List<T> numbers,Func<T, bool> func)
        //{
        //    foreach (T number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }
        //}
        #endregion

        #region BuiltIn Delegates
        //static void Print(string name) => Console.WriteLine(name);
        //static int add(int n1, int n2) => n1 + n2;
        //static bool IsEvenNumber(int n) => n % 2 == 0;  
        #endregion

        #region Extention Methods
        //public static string Truncate(string str, int MaxLength)
        //{
        //    if (str.Length > MaxLength)
        //    {
        //        return str.Substring(0, MaxLength);
        //    }
        //    return str;
        //} 
        #endregion


    }
}