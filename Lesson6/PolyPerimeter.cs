using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Kva
    {
        protected int sideKva;
        public int SideKva
        {
            get { return SideKva;}
            set { SideKva = value;}
        }

        public void SetSide(int x)
        {
            sideKva = x;
        }

        public virtual int Perim()
        {
            return sideKva * 4;
        }
    }


    class Cube : Kva
    {

        public override int Perim()
        {
            return sideKva * 12;
        }
    }

}
