using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Circle nullC = new Circle();
            //Circle FirstC = new Circle(5,6,22.4);

            //Console.WriteLine(FirstC.Get());
            //Console.WriteLine(FirstC.Get(3));

            //Console.WriteLine(FirstC.GetObj());
            //Console.WriteLine(FirstC.GetObj(2,3,14));

            //Console.WriteLine(FirstC.Point(7,8));
            //Console.WriteLine(FirstC.ToString());

            //2
            //Triangle FirstTr = new Triangle(2,3,60,70);
            //FirstTr.Draw();

            //Krug FirstKrug = new Krug(4, 7, 43);
            //FirstKrug.Draw();

            //3
            //Kva firstKva = new Kva();
            //firstKva.SetSide(5);
            //Console.WriteLine(firstKva.Perim());

            //Cube firstCube = new Cube();
            //firstCube.SetSide(12);
            //Console.WriteLine(firstCube.Perim());

            //4
            //Ukr Petro = new Ukr();
            //Petro.SayHello();

            //Ger Hans = new Ger();
            //Hans.SayHello();

            //Human [] humans = new Human[2];
            //humans[0] = new Ukr();
            //humans[1] = new Ger();

            //foreach (Human h in humans) {
            //    h.SayHello();
            //}

            //5
            Paral Pram1 = new Paral(2, 3, 6, 7);
            Paral Pram2 = new Paral(2, 3, 6, 7);

            Console.WriteLine(Pram1.ToString());
            Console.WriteLine(Pram2.ToString());

            Console.WriteLine(Pram1.Equals(Pram2));

            Console.WriteLine(Pram1.GetHashCode());
            Console.WriteLine(Pram2.GetHashCode());

            //6
            //object[] arrObj = new object[6];
            //arrObj[0] = 5;
            //arrObj[1] = "a";
            //arrObj[2] = 's';
            //arrObj[3] = 4.5;
            //arrObj[4] = new object();
            //arrObj[5] = (long)200;

            //int a1 = (int) arrObj[0];
            //string a2 = (string) arrObj[1];
            //char a3 = (char) arrObj[2];
            //double a4 = (double) arrObj[3];
            //object a5 = arrObj[4];
            //byte a6 = (byte)(long) arrObj[5];

            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a3);
            //Console.WriteLine(a4);
            //Console.WriteLine(a5);
            //Console.WriteLine(a6);

        }
    }
}
