using Assm2_OOP.Encapsulation;

namespace Assm2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ENCapsu
            Employee employee = new Employee( 10 , "Ahmed" , 3000);
            Console.WriteLine(employee);

            ////employee.Id = 1;
            ////Console.WriteLine(employee.Id);

            //employee.SetName("Hany Makram"); //set
            //Console.WriteLine(employee.GetName()); //Get


            //employee.Salary = 1000;
            //Console.WriteLine(employee.Salary);

            employee.Salary = 2000;
            //Console.WriteLine(employee.Salary);

            employee.Age = 25;
            //Console.WriteLine(employee.Age);

            Console.WriteLine(employee.Deducation);
            #endregion


        }
    }
}
