using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    abstract class Human
    {
       // private string name;
        public string Name { get; set; }

        //public Human(string name)
        //{
        //    Name = name;
        //}

        abstract public void SayHello();
    }

    class Ukr : Human
    {
        public override void SayHello()
        {
            Console.WriteLine("Україна - привіт");
        }
    }

    class Ger : Human
    {
        public override void SayHello()
        {
            Console.WriteLine("Deutchland - Guten Tag");
        }
    }
}
