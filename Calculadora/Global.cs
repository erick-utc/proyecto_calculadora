using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora
{
    public static class Global
    {
        public static float num1 { get; set; }
        public static float num2 { get; set; }
        public static float resultado { get; set; }

        public static bool operacionActiva;

        public static string operacionActual;
    }
}