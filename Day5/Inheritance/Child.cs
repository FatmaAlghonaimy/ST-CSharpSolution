using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Inheritance
{
    class Child : Parent
    {
        //inheritance happens through ctor
        #region Properties
        //public int X { get; set; } //do you want to hide?
        //public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region Ctor
        public Child(int x,int y, int z):base(x, y) //base class ctor --chaining
        {
            Z = z;
            Console.WriteLine("Child constructor");
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Child X:{X}, Y:{Y}, Z:{Z}";
        }

        //method hiding -- new keyword
        public new int Product()
        {
            return base.Product() * Z ; //call parent method
            //return X * Y * Z;
        }
        #endregion
    }
}
