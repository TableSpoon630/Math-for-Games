﻿using System;

namespace MathsFormula
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test for F when x = 4: " + F(4));
            float[] b = F(4, 7, 2);
            Console.WriteLine("Test for F when a = 4, b = 7, and c = 2: " + b[0] + ", " + b[1]);
            Console.WriteLine("Test for L when s = 2, e = 18, and t = 0.7f: " + L(2, 18, 0.75f));
            Console.WriteLine("Test for D when P1 = (2, 4), and P2 = (5, 9): " + D(new Vector2(2, 4), new Vector2(5, 9)));
            Console.WriteLine("Test for Inner when P = (2, 4, 5), and Q = (5, 9, 2): " + Inner(new Vector3(2, 4, 5), new Vector3(5, 9, 2)));
            Console.WriteLine("Test for Inner when P = (2, 4, 5, 17), and X = (5, 9, 2): " + D(new Plane(2, 4, 5, 17), new Vector3(5, 9, 2)));
            Console.WriteLine("Test for B when t = 2, P0 = 18, P1 = 3, P2 = 7, and P3 = 9: " + B(2, 18, 3, 7, 9));
        }

        static float F(float x)
        {
            return (x * x) + (2 * x) - 7;
        }

        static float[] F(float a, float b, float c)
        {
            float tmp = MathF.Sqrt((b * b) - (4 * a * c));

            if (tmp < 0)
                return null;

            return new float[]
            {
                ((-b + tmp) / (2 * a)),
                ((-b - tmp) / (2 * a))
            };
        }

        static float L(float s, float e, float t)
        {
            return s + (t * (e - s));
        }

        static float D(Vector2 P1, Vector2 P2)
        {
            return MathF.Sqrt(MathF.Pow(P2.x - P1.x, 2) + MathF.Pow(P2.y - P1.y, 2));
        }

        static float Inner(Vector3 P, Vector3 Q)
        {
            return (P.x * Q.x) + (P.y * Q.y) + (P.z * Q.z);
        }

        static float D(Plane P, Vector3 X)
        {
            float toReturn = (P.a * X.x) + (P.b * X.y) + (P.c * X.z) + P.d;
            toReturn /= MathF.Sqrt((P.a * P.a) + (P.b * P.b) + (P.c * P.c));
            return toReturn;
        }
        static float B(float t, float P0, float P1, float P2, float P3)
        {
            float toReturn = MathF.Pow(1 - t, 3) * P0;
            toReturn += 3 * MathF.Pow(1 - t, 2) * t * P1;
            toReturn += 3 * (1 - t) * t * t * P2;
            toReturn += t * t * t * P3;
            return toReturn;
        }
    }

    struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    struct Plane
    {
        public float a;
        public float b;
        public float c;
        public float d;

        public Plane(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }
}
