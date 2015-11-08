using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Geometrical
    {
        protected int x;
        protected int y;

        public Geometrical() { }
        public Geometrical(int x, int y) {
            this.x = x;
            this.y = y;
        }

    }


    class Triangle : Geometrical
    {   
        private int angle1;
        private int angle2;
        private int angle3;

        public Triangle(int x, int y, int angle1, int angle2) : base (x, y) { 
        this.angle1 = angle1;
        this.angle2 = angle2;
        this.angle3 = 180 - (angle1 + angle2);
        }

        public void Draw()
        {
            Console.WriteLine("Метод якобы рисует треугольник с углами " + angle1 + " " + angle2 + " " + angle3);
        }
    }


    class Krug : Geometrical
    {
        private int radius;

        public Krug(int x, int y, int radius)
            : base(x, y)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Рисуем круг с радиусом " + radius);
        }
    }

}
