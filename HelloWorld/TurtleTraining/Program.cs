using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            int i = 0;
            while (i < 20)
            {
                Turtle.Move(20);
                if((i % 4) == 0 || (i % 4) == 1)
                {
                    Turtle.TurnRight();
                }
                else
                {
                    Turtle.TurnLeft();
                }
                i++;
            }

        }
    }
}
