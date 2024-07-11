using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm2_OOP.Encapsulation
{


    internal struct Employee
    {
        #region Attrabute
        public int Id;
        private string? Name;
        private decimal salary;
        #endregion

        #region Apply EN

        //Get
        public string? GetName() 
        { 
            return Name;
        }
        //Set
        public void SetName(string _name)
        {
            Name = _name?.Length > 5 ? _name.Substring(0 , 5) : _name;
        }
        #endregion

        #region EX02 App En
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value < 3000 ? 3000 : value;
            }

        }

        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}



        public int Age { get; set; }


        //private decimal deducation;

        public decimal Deducation
        {
            get { return Salary * 0.2M; }
        }


   

        #endregion

        #region const
        public Employee(int id, string? name, decimal salary , int age)
        {
            Id = id;
            Name = name;
            this.salary = salary;
            this.Age = age;
        }

        #endregion


        #region mEthoud
        public override String ToString()
        {
            return $"Id = {Id} \nName = {Name} \nSalary = {salary:c} \n Age = {Age}";
        }

        #endregion
    }


}
