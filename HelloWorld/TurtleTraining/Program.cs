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
        static void WriteT(int size)
        {
            // Буква Т начало
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move(size / 3 * 2);
            // Буква Т конец
        }
        
        static void WriteO(int size)
        {
            // Буква О начало
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
            // Буква О конец
        }

        static void WriteP(int size)
        {
            // Буква Р начало
            Turtle.Angle = 0;
            Turtle.Move(size);
            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(size / 2);
            }
            // Буква Р конец
        }

        static void Main(string[] args)
        {
            Turtle.Speed = 9;

            // Торт

            Turtle.X = 220;
            Turtle.Y = 200;

            WriteT(60);

            Turtle.X = 260;
            Turtle.Y = 200;

            WriteO(30);

            Turtle.X = 340;
            Turtle.Y = 200;

            WriteP(30);

            Turtle.X = 400;
            Turtle.Y = 200;

            WriteT(30);
        }
    }
}
