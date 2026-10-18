using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Intro_till_OOP
{
    public class Circle
    {
        float _pi = 3.141f;
        int Radius;


        public Circle(int radius)
        {
            Radius = radius;
        }
    

    public float GetArea()
        {
            return Radius * Radius * _pi;
        }
    }
}