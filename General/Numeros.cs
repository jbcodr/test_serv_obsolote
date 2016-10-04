using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    /// <summary>
    /// Gestiona la conversión de números.
    /// </summary>
    public static class Numeros
    {
        public static int ToInt(object valor)
        {
            return ToInt(valor, 0);
        }
        public static int ToInt(object valor, int defecto)
        {
            return (int)ToNumber(TipoNumero.Int32, valor, defecto);
        }

        public static long ToLong(object valor)
        {
            return ToLong(valor, 0);
        }
        public static long ToLong(object valor, long defecto)
        {
            return (long)ToNumber(TipoNumero.Int64, valor, defecto);
        }

        public static double ToDouble(object valor)
        {
            return ToDouble(valor, 0);
        }
        public static double ToDouble(object valor, double defecto)
        {
            return (double)ToNumber(TipoNumero.Double, valor, defecto);
        }

        public static decimal ToDecimal(object valor)
        {
            return ToDecimal(valor, 0);
        }
        public static decimal ToDecimal(object valor, decimal defecto)
        {
            return (decimal)ToNumber(TipoNumero.Decimal, valor, defecto);
        }

        public static float ToFloat(object valor)
        {
            return ToFloat(valor, 0);
        }
        public static float ToFloat(object valor, float defecto)
        {
            return (float)ToNumber(TipoNumero.Single, valor, defecto);
        }

        public static bool ToBool(object valor)
        {
            return ToBool(valor, false);
        }
        public static bool ToBool(object valor, bool defecto)
        {
            return (bool)ToNumber(TipoNumero.Boolean, valor, defecto);
        }

        private static Random rnd = null;
        public static Random Rnd
        {
            get { return rnd ?? (rnd = new Random(Guid.NewGuid().GetHashCode())); }
        }
        public static void Desordena(ref Object[] array, bool desordenar)
        {
            int rndIndex;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                k++;
                array[i] = k;
            }
            if (desordenar)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        rndIndex = Convert.ToInt32(Math.Floor(Rnd.NextDouble() * array.Length));
                        Intercambia(ref array[i], ref array[rndIndex]);
                    }
                }
            }
        }
        public static void Desordena(ref Object[] array)
        {
            Desordena(ref array, true);
        }
        public static void Intercambia(ref int num1, ref int num2)
        {
            int tmpNum = num1;
            num1 = num2;
            num2 = tmpNum;
        }
        public static void Intercambia(ref object valor1, ref object valor2)
        {
            object tmpValor = valor1;
            valor1 = valor2;
            valor2 = tmpValor;
        }
    }
}
