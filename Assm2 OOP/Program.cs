using Assm2_OOP.Encapsulation;
using Assm2_OOP.Inertitance;

namespace Assm2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 :: Define a struct "Person" with properties "Name" and "Age"
            //Person[] people = new Person[3];

            //people[0] = new Person("Ahmed", 25);
            //people[1] = new Person("Hany", 30);
            //people[2] = new Person("Makram", 40);

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region Q2 ::  the oldest person

            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++) { 
            //Console.WriteLine($"Enter Name For Person number {i+1}");
            //   string name =  Console.ReadLine();
            //Console.WriteLine($"Enter Age Person Number {i+1}");
            //    int age = int.Parse(Console.ReadLine());
            //    people[i] = new Person(name, age);
            //}

            //Person oldperson = people[0];

            //for (int i = 1 ; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldperson.Age) { 
            //    oldperson = people[i];
            //    }
            //}

            //Console.WriteLine("The Oldest person is : ");
            //Console.WriteLine(oldperson);
            #endregion

            #region Q3 Part03 :: Design and implement a Class for the employees

            //Employee[] EmpArr = new Employee[3];

            //HiringDate hireDate1 = new HiringDate(11, 7, 2024);
            //HiringDate hireDate2 = new HiringDate(12, 8, 2024);
            //HiringDate hireDate3 = new HiringDate(13, 9, 2024);

            //EmpArr[0] = new Employee(1, "Ahmed Hany", SecurityPrivilege.DBA, 7500, hireDate1, 'M');
            //EmpArr[1] = new Employee(2, "Non Non", SecurityPrivilege.Guest, 4000, hireDate2, 'F');
            //EmpArr[2] = new Employee(3, "Omer Matter", SecurityPrivilege.Developer, 6000, hireDate3, 'M');

            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}

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

            #region Car
            //Car C1;
            //C1 = new Car(10 ,"BMW" , 290);
            //Console.WriteLine(C1);

            ////Car C2;
            // C2 = new Car(10 , "Hyndai");
            //Console.WriteLine(C2);

            //Car C3 = new Car(10);
            //Console.WriteLine(C3);
            #endregion


            #region Parent
            //Parent P = new Parent( 1 , 2 );
            //Console.WriteLine(P);
            //Console.WriteLine(P.Prodict());

            //Child C = new Child( 3 , 4 , 5);
            //Console.WriteLine(C.ToString());
            //Console.WriteLine(C.Prodict());

            #endregion

            #region AccessMod

            TypeA ObjA = new TypeA();
            //ObjA.X = 10;
            //ObjA.Y = 20;
            //ObjA.Z = 40;

            TypeB ObjB = new TypeB();
            //ObjB.M = 30;
            //ObjB.X = 10;
            //ObjB.Y = 20;
            //ObjB.Z = 40;

            #endregion

        }
    }
}
