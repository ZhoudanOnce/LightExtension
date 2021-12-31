
using System;

namespace LightExtension
{
    public static class LightMath
    {
        public static decimal Abs(this decimal value) { return Math.Abs(value); }
        public static double Abs(this double value) { return Math.Abs(value); }
        public static short Abs(this short value) { return Math.Abs(value); }
        public static int Abs(this int value) { return Math.Abs(value); }
        public static long Abs(this long value) { return Math.Abs(value); }
        public static sbyte Abs(this sbyte value) { return Math.Abs(value); }
        public static float Abs(this float value) { return Math.Abs(value); }
    }
}