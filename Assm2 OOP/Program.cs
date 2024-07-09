using Assm2_OOP.Encapsulation;

namespace Assm2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ENCapsu
            //Employee employee = new Employee( 10 , "Ahmed" , 3000);
            //Console.WriteLine(employee);

            //////employee.Id = 1;
            //////Console.WriteLine(employee.Id);

            ////employee.SetName("Hany Makram"); //set
            ////Console.WriteLine(employee.GetName()); //Get


            ////employee.Salary = 1000;
            ////Console.WriteLine(employee.Salary);

            //employee.Salary = 2000;
            ////Console.WriteLine(employee.Salary);

            ////employee.Age = 25;
            ////Console.WriteLine(employee.Age);

            //Console.WriteLine(employee.Deducation);
            #endregion


            #region indexer
            //phonebook Note = new phonebook(3);
            //Note.AddPerson(0, "ahmed", 123);
            //Note.AddPerson(1, "hany", 512);
            //Note.AddPerson(2, "makram", 248);



            //int AhmedNumber = Note.GetNumber("Ahmed"); ;
            //Console.WriteLine(AhmedNumber == 123 ? "Person not found" : AhmedNumber);

            //Console.WriteLine(Note["Amr"]);
            //Note["Amr"] = 500;
            //Console.WriteLine(Note["Amr"]);

            //Console.WriteLine(Note);

            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}



            #endregion

            Car C1;
            C1 = new Car(10 ,"BMW" , 290);
            Console.WriteLine(C1);

            //Car C2;
            // C2 = new Car(10 , "Hyndai");
            //Console.WriteLine(C2);

            //Car C3 = new Car(10);
            //Console.WriteLine(C3);

        }
    }
}
