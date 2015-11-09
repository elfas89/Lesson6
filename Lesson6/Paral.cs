using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Paral
    {
        int X1;
        int Y1;

        int X2;
        int Y2;

        public Paral(int a, int b, int c, int d)
        {
            this.X1 = a;
            this.Y1 = b;
            this.X2 = c;
            this.Y2 = d;
        }

        public override string ToString()
        {
            //return base.ToString();
            return X1 + " " + Y1 + " " + X2 + " " + Y2; 
        }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            if (obj.GetType() != this.GetType())    //проверка на принадлежность к одному классу
            {
                return false;
            }
            Paral p2 = (Paral)obj;
            return (this.X1 == p2.X1 
                 && this.Y1 == p2.Y1
                 && this.X2 == p2.X2
                 && this.Y2 == p2.Y2);

        }

        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return X1 * Y1 * X2 * Y2;

        }
    }
}
