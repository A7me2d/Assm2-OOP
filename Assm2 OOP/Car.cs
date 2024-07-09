using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm2_OOP
{
    internal struct Car
    {



        #region Consturact

        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public Car(int id , string model , double speed)
        {
            Console.WriteLine("one ");
            Id = id;
            Model = model;
            Speed = speed;

        }

        public Car(int id , string model):this(id , model , 190)
        {
            Console.WriteLine("two ");

        }

        public Car(int id) {
            Console.WriteLine("three ");

            Id = id;
            Model = "Audi";
            Speed = 200;
        }
        #endregion
    }
}
