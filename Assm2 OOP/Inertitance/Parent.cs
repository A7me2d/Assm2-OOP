using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm2_OOP.Inertitance
{
    internal class Parent
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";

        }

        public int Prodict()
        {

            return X * Y;
        }
    }
}
