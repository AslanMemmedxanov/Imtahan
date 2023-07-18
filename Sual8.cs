using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iiimitahhan
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
