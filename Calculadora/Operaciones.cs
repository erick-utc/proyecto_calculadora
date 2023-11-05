using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora
{
    public static class Operaciones

    {
        public const string SUMA = "+";
        public const string RESTA = "-";
        public const string MULTIPLICACION = "x";
        public const string DIVISION = "/";
        public const string POW2 = "^2";
        public const string LOG = "log";
        public const string POW10 = "10^";
        public const string POW = "^";
        public const string SQRT = "sqrt";
        public const string FACTORIAL = "!";
        public const string INVERSO = "-1*";
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
            if (num2 != 0)
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

        public static float pow10(float num1)
        {
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
            if ((int)num1 > 0)
            {
                return (float)Enumerable.Range(1, (int)num1).Aggregate(1, (p, item) => p * item);
            }

            return 0;

        }

        public static float inverso(float num1)
        {
            return -1 * num1;
        }

        public static float seleccionarOperacion(string operacion)
        {
            switch (operacion)
            {
                case Operaciones.SUMA:
                    return Operaciones.suma(Global.num1, Global.num2);
                case Operaciones.RESTA:
                    return Operaciones.resta(Global.num1, Global.num2);
                case Operaciones.MULTIPLICACION:
                    return Operaciones.multiplicacion(Global.num1, Global.num2);
                case Operaciones.DIVISION:
                    return Operaciones.division(Global.num1, Global.num2);
                case Operaciones.POW2:
                    return Operaciones.pow2(Global.num1);
                case Operaciones.LOG:
                    return Operaciones.log(Global.num1);
                case Operaciones.POW10:
                    return Operaciones.pow10(Global.num1);
                case Operaciones.POW:
                    return Operaciones.pow(Global.num1, Global.num2);
                case Operaciones.SQRT:
                    return Operaciones.sqrt(Global.num1);
                case Operaciones.FACTORIAL:
                    return Operaciones.factorial(Global.num1);
                case Operaciones.INVERSO:
                    return Operaciones.inverso(Global.num1);
                default: return 0;
            }
        }
    }
}