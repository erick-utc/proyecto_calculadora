using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora
{
    public static class Operaciones
    {
        public static float suma(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float resta(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float multiplicacion(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float division(float num1, float num2)
        {
            if(num2 != 0)
            {
                return num1 / num2;
            }

            return 0;
        }

        public static float pow2(float num1)
        {
            return (float)Math.Pow(num1, 2);
        }

        public static float log(float num1)
        {
            return (float)Math.Log(num1);
        }

        public static float pow10(float num1) {
            return (float)Math.Pow(10, num1);
        }

        public static float pow(float num1, float num2)
        {
            return (float)Math.Pow(num1, num2);
        }

        public static float sqrt(float num1)
        {
            return (float)Math.Sqrt(num1);
        }

        public static float factorial(float num1)
        {
            if((int)num1 > 0)
            {
                return (float)Enumerable.Range(1, (int)num1).Aggregate(1, (p, item) => p * item);
            }

            return 0;
            
        }

        public static float inverse(float num1)
        {
            return -1 * num1;
        }
    }
}