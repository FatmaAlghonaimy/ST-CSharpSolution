using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Inheritance
{
    class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Ctor
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Parent constructor called with X:{0}, Y:{1}", x, y);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Parent X:{X}, Y:{Y}";
        }
        public int Product()
        {
            return X * Y;
        }
        #endregion
    }
}
