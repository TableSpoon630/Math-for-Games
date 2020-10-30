﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Vectors
{
    class Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector2()
        {
            x = 0;
            y = 0;
        }

        public float Magnitude()
        {
            return MathF.Sqrt((x * x) + (y * y));
        }
        public float MagnitudeSqr()
        {
            float mag = Magnitude();
            return mag * mag;
        }

        public float Distance(Vector2 point)
        {
            float distX = point.x - x;
            float distY = point.y - y;
            return MathF.Sqrt((distX * distX) + (distY * distY));
        }
        public float DistanceSqr(Vector2 point)
        {
            float dist = Distance(point);
            return dist * dist;
        }

        public void Normalised()
        {
            float multiplier = 1 / Magnitude();
            x *= multiplier;
            y *= multiplier;
        }

        public float Dot(Vector2 vector)
        {
            return (x * vector.x) + (y * vector.y);
        }
        public Vector2 GetPerpendicular()
        {
            return new Vector2(y, -x);
        }

        /// <summary>
        /// finds the angle between to Vectors
        /// </summary>
        public float AngleBetween(Vector2 vector)
        {
            float toReturn = MathF.Acos(Dot(vector) / (Magnitude() * vector.Magnitude()));
            return toReturn * (180 / MathF.PI);
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }
        public static Vector2 operator *(Vector2 vector, float scalar)
        {
            return new Vector2(vector.x * scalar, vector.y * scalar);
        }
        public static Vector2 operator /(Vector2 vector, float scalar)
        {
            return new Vector2(vector.x / scalar, vector.y / scalar);
        }
        public static Vector2 operator *(float scalar, Vector2 vector)
        {
            return new Vector2(vector.x * scalar, vector.y * scalar);
        }
        public static Vector2 operator /(float scalar, Vector2 vector)
        {
            return new Vector2(vector.x / scalar, vector.y / scalar);
        }
    }
}
