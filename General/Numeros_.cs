using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    /// <summary>
    /// 
    /// </summary>
    public static class Numeros
    {
        /// <summary>
        /// Redondea un número de tipo decimal, a un determinado número de decimales pasados como parámetro
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="decimales"></param>
        /// <returns></returns>
        public static decimal Redondea(decimal numero, int decimales)
        {
            return Math.Round(numero, decimales, MidpointRounding.AwayFromZero);
        }
        /// <summary>
        /// Quita el formateo numérico a la cadena pasada como parametro
        /// </summary>
        /// <param name="sNumero">Cadena a quitar formato</param>
        /// <returns>Una cadena sin formato, salvo el separador decimal.</returns>
        public static string QuitaFormatoNumero(string sNumero)
        {
            int i = 0;
            string sResultado = "";
            if (sNumero != null)
            {
                for (i = 0; i <= sNumero.Length - 1; i++)
                {
                    if (sNumero[i] >= 48 && sNumero[i] <= 57)
                        sResultado = sResultado + sNumero[i];

                    if (sNumero[i] == FuncionesGenerales.DecimalSeparator)
                        sResultado = sResultado + sNumero[i];

                    if (sNumero[i] == 45)
                        sResultado = sResultado + sNumero[i];
                }
            }
            return sResultado;
        }

        /// <summary>
        /// Convierte un numero a cadena formateada 
        /// </summary>
        /// <param name="num">número a formatear</param>
        /// <returns>cadena formateada</returns>
        public static string FormateaNumero(int num)
        {
            string Numero = string.Empty;
            string sCadena = string.Empty;
            try
            {
                if (num == 0)
                {
                    return Numero;
                }
                sCadena = "{0:###,##0}";
                if (num == 0)
                    Numero = string.Empty;
                else
                    Numero = String.Format(sCadena, num);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Numero = "";
            }
            finally
            {
                ;
            }
            return (Numero);
        }

        /// <summary>
        /// Convierte un numero a cadena formateada 
        /// </summary>
        /// <param name="num">número a formatear</param>
        /// <param name="dec">número de decimales a pasar</param>
        /// <returns>cadena formateada</returns>
        public static string FormateaNumero(double num, int dec)
        {
            string Numero = string.Empty;
            string Decimales = ".";
            string sCadena = string.Empty;
            try
            {
                if (num == 0)
                {
                    return Numero;
                }
                if (dec != 0)
                    Decimales = Decimales.PadRight(dec + 1, '0');

                if (dec > 0)
                    sCadena = "{0:###,##0" + Decimales + "}";
                else
                    sCadena = "{0:###,##0}";

                if (num == 0)
                    Numero = string.Empty;
                else
                    Numero = String.Format(sCadena, num);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Numero = string.Empty;
            }
            finally
            {
                ;
            }
            return (Numero);
        }

        /// <summary>
        /// Convierte un número decimal a cadena formateada 
        /// </summary>
        /// <param name="num">Número a formatear</param>
        /// <param name="dec">Número de decimales a pasar</param>
        /// <returns>Cadena formateada</returns>
        public static string FormateaNumero(decimal num, int dec)
        {
            string Numero = string.Empty;
            string Decimales = ".";
            string sCadena = string.Empty;
            try
            {
                if (num == 0)
                {
                    return Numero;
                }
                if (dec != 0)
                    Decimales = Decimales.PadRight(dec + 1, '0');

                if (dec > 0)
                    sCadena = "{0:###,##0" + Decimales + "}";
                else
                    sCadena = "{0:###,##0}";

                if (num == 0)
                    Numero = string.Empty;
                else
                    Numero = String.Format(sCadena, num);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Numero = string.Empty;
            }
            return (Numero);
        }
        /// <summary>
        /// Convierte un numero a cadena formateada 
        /// </summary>
        /// <param name="num">número a formatear</param>
        /// <param name="dec">número de decimales a pasar</param>
        /// <returns>cadena formateada</returns>
        public static string FormateaNumero(string num, int dec)
        {
            string Numero = String.Empty;
            string Decimales = ".";
            string sCadena = String.Empty;
            try
            {
                if (num.Trim() == String.Empty)
                {
                    return Numero;
                }
                if (dec != 0)
                    Decimales = Decimales.PadRight(dec + 1, '0');

                if (dec > 0)
                    sCadena = "{0:###,##0" + Decimales + "}";
                else
                    sCadena = "{0:###,##0}";

                if (num.Trim() == String.Empty)
                    Numero = String.Empty;
                else
                    Numero = String.Format(sCadena, StrToDecimalDef(num, 0));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Numero = String.Empty;
            }
            finally
            {
                ;
            }
            return (Numero);
        }
        /// <summary>
        /// Convierte un número decimal a cadena con formato contabilidad (Separador Miles / 2 decimales)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string FormateaNumeroConta(object num)
        {
            return FormateaNumero(Numeros.StrToDecimalDef(num, 0), 2);
        }
        /// <summary>
        /// Convierte un número decimal a cadena formateada sin indicar los miles
        /// </summary>
        /// <param name="num">Número a formatear</param>
        /// <param name="dec">Número de decimales a pasar</param>
        /// <returns>Cadena formateada</returns>
        public static string FormateaNumeroNoMiles(decimal num, int dec)
        {
            string Numero = string.Empty;
            string Decimales = ".";
            string sCadena = string.Empty;
            try
            {
                if (num == 0)
                {
                    return Numero;
                }
                if (dec != 0)
                    Decimales = Decimales.PadRight(dec + 1, '0');

                if (dec > 0)
                    sCadena = "{0:##0" + Decimales + "}";
                else
                    sCadena = "{0:##0}";

                if (num == 0)
                    Numero = string.Empty;
                else
                    Numero = String.Format(sCadena, num);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Numero = string.Empty;
            }
            return (Numero);
        }
        /// <summary>
        /// Convierte un número decimal a cadena formateada sin indicar los miles y con punto para separar los decimales
        /// </summary>
        /// <param name="num">Número a formatear</param>
        /// <param name="dec">Número de decimales a pasar</param>
        /// <returns>Cadena formateada</returns>
        public static string FormateaNumeroNoMilesSeparadorPunto(decimal num, int dec)
        {
            string numero = FormateaNumeroNoMiles(num, dec);
            if (numero != string.Empty)
                return numero.Replace(",", ".");
            return numero;
        }

        /// <summary>
        /// Retorna la cadena con el formato actual general para los porcentajes de IVA
        /// La conversión se haría así: PorcIVA.ToString(FormatoPorcIVA())
        /// </summary>
        /// <returns></returns>
        public static string FormatoPorcIVA()
        {
            string Decimales = ".";
            string sCadena = string.Empty;
            try
            {
                Decimales = Decimales.PadRight(FuncionesGenerales.LongMaxDecPorcIVA + 1, '#');
                //importante: si no se pone entre comillas el porcentaje, multiplica el nº por 100
                sCadena = "###,##0" + Decimales + "'%'";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                sCadena = string.Empty;
            }
            return sCadena;
        }

        /// <summary>
        /// Retorna la cadena con el formato actual general para los porcentajes de IVA SIN el signo %
        /// La conversión se haría así: PorcIVA.ToString(FormatoPorcIVASin())
        /// </summary>
        /// <returns></returns>
        public static string FormatoPorcIVASin()
        {
            string Decimales = ".";
            string sCadena = string.Empty;
            try
            {
                Decimales = Decimales.PadRight(FuncionesGenerales.LongMaxDecPorcIVA + 1, '#');
                //importante: si no se pone entre comillas el porcentaje, multiplica el nº por 100
                sCadena = "###,##0" + Decimales;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                sCadena = string.Empty;
            }
            return sCadena;
        }
        /// <summary>
        /// Quita los decimales y la coma si son ,00
        /// </summary>
        /// <param name="sporc"></param>
        /// <returns></returns>
        public static string LimpiaPorcentaje(string sporc)
        {
            if (sporc.IndexOf(",00") != -1)
            {
                sporc = sporc.Remove(sporc.IndexOf(','), 3);
                //sporc = String.Format("{0,2}", Convert.ToInt16(sporc).ToString());
                sporc = String.Format("{0,2}", Convert.ToDecimal(sporc).ToString());
            }
            return sporc;
        }

        /// <summary>
        /// Retorna la cadena con el formato actual general para los importes
        /// La conversión se haría así: Importe.ToString(FormatoImporteConta())
        /// </summary>
        /// <returns></returns>
        public static string FormatoImporteConta()
        {
            string Decimales = ".";
            string sCadena = string.Empty;
            try
            {
                Decimales = Decimales.PadRight(FuncionesGenerales.LongMaxDecImporteConta + 1, '#');
                sCadena = "###,##0" + Decimales;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                sCadena = string.Empty;
            }
            return sCadena;
        }

        #region Conversiones a Número

        /// <summary>
        /// Pasa una cadena a byte
        /// </summary>
        /// <param name="sNumero">cadena que desea pasar a byte. </param>
        /// <param name="bDef">Número que se desea en caso de error. </param>
        /// <returns>Devuelve sNúmero pasado a byte, y en caso de error devuelve bDef.</returns>
        public static byte StrToByteDef(string sNumero, byte bDef)
        {
            byte bResult = bDef;
            try
            {
                bResult = Convert.ToByte(sNumero.Trim());
            }
            catch
            {
                bResult = bDef;
            }
            return bResult;
        }

        /// <summary>
        /// Pasar una cadena a doble
        /// </summary>
        /// <param name="sNumero">Cadena a pasar a doble</param>
        /// <param name="dDef">numero en caso de error</param>
        /// <returns>sNumero transformado a doble o en su defecto el valor dDef</returns>
        public static double StrToFloatDef(string sNumero, double dDef)
        { //Funcion: Igual que StrToFloat pero devuelve Def cuando se produzca una
            //exception.
            double dResult = dDef;
            try
            {
                dResult = Convert.ToDouble(sNumero.Trim());
            }
            catch
            {
                dResult = dDef;
            }
            return dResult;
        }

        /// <summary>
        /// Pasar una cadena a Int16
        /// </summary>
        /// <param name="sNumero">Cadena a pasar a Int16</param>
        /// <param name="dDef">Valor por defecto a asignar en caso de error</param>
        /// <returns>sNumero transformado a Int16 o en su defecto el valor dDef</returns>
        public static Int16 StrToInt16Def(string sNumero, Int16 dDef)
        {
            //Función: Igual que StrToInt pero devuelve Def cuando se produzca una
            //exception.
            Int16 dResult = dDef;
            try
            {
                dResult = Convert.ToInt16(sNumero.Trim());
            }
            catch
            {
                dResult = dDef;
            }
            return dResult;
        }
        /// <summary>
        /// Pasa un objeto a int16; si es nulo, devuelve el valor por defecto iDef
        /// </summary>
        /// <param name="Numero">Objeto a pasar a entero</param>
        /// <param name="iDef">Valor por defecto a asignar en caso de error</param>
        /// <returns>Numero transformado a entero o en su defecto el valor iDef</returns>
        public static Int16 StrToInt16Def(object Numero, Int16 iDef)
        {
            //Función: Igual que StrToInt16 pero devuelve Def cuando se produzca una
            //exception.
            Int16 iResult = iDef;
            try
            {
                if (Numero == null || Numero is DBNull)
                {
                    iResult = iDef;
                }
                else
                {
                    iResult = Convert.ToInt16(Numero.ToString().Trim());
                }
            }
            catch
            {
                iResult = iDef;
            }
            return iResult;
        }

        /// <summary>
        /// Pasa un objeto a decimal; si es nulo, devuelve el valor por defecto dDef
        /// </summary>
        /// <param name="Numero">Objeto a pasar a decimal</param>
        /// <param name="dDef">Valor por defecto a asignar en caso de error</param>
        /// <returns>Numero transformado a decimal o en su defecto el valor dDef</returns>
        public static decimal StrToDecimalDef(object Numero, decimal dDef)
        {
            //Función: Igual que StrToFloat pero devuelve Def cuando se produzca una
            //exception.
            decimal dResult = dDef;
            try
            {
                if (Numero == null || Numero is DBNull)
                {
                    dResult = dDef;
                }
                else
                {
                    // Esto da error al convertir un float con decimales, lo cambio por el que debería ser.
                    //dResult = Convert.ToDecimal(Numero.ToString().Trim());
                    if (Numero is String) { LimpiaCadena(ref Numero); }
                    dResult = Convert.ToDecimal(Numero);
                }
            }
            catch
            {
                dResult = dDef;
            }
            return dResult;
        }
        /// <summary>
        /// Pasar una cadena a decimal
        /// </summary>
        /// <param name="sNumero">Cadena a pasar a decimal</param>
        /// <param name="dDef">Valor por defecto a asignar en caso de error</param>
        /// <returns>sNumero transformado a decimal o en su defecto el valor dDef</returns>
        public static decimal StrToDecimalDef(string sNumero, decimal dDef)
        {
            //Función: Igual que StrToFloat pero devuelve Def cuando se produzca una
            //exception.
            decimal dResult = dDef;
            try
            {
                if (String.IsNullOrEmpty(sNumero))
                {
                    dResult = dDef;
                }
                else
                {
                    dResult = Convert.ToDecimal(sNumero.Trim());
                }
            }
            catch
            {
                dResult = dDef;
            }
            return dResult;
        }

        /// <summary>
        /// Pasa un objeto a int; si es nulo, devuelve el valor por defecto iDef
        /// </summary>
        /// <param name="Numero">Objeto a pasar a entero</param>
        /// <param name="iDef">Valor por defecto a asignar en caso de error</param>
        /// <returns>Numero transformado a entero o en su defecto el valor iDef</returns>
        public static int StrToIntDef(object Numero, int iDef)
        {
            //Función: Igual que StrToInt pero devuelve Def cuando se produzca una
            //exception.
            int iResult = iDef;
            try
            {
                if (Numero == null || Numero is DBNull)
                {
                    iResult = iDef;
                }
                else
                {
                    // Esto da error al convertir un float con decimales, lo cambio por el que debería ser.
                    //iResult = Convert.ToInt32(Numero.ToString().Trim());
                    if (Numero is String) { LimpiaCadena(ref Numero); }
                    iResult = Convert.ToInt32(Numero);
                }
            }
            catch
            {
                iResult = iDef;
            }
            return iResult;
        }
        /// <summary>
        /// Pasa una cadena a Entero
        /// </summary>
        /// <param name="sNumero">cadena que se desea pasar a número</param>
        /// <param name="dDef">Numero que se desea en caso de error</param>
        /// <returns>Devuelve sNumero pasado a entero, y en caso de error
        ///          devuelve dDef </returns>
        public static int StrToIntDef(string sNumero, int dDef)
        { //Funcion: Igual que StrToFloat pero devuelve Def cuando se produzca una
            //exception.
            int dResult = dDef;
            try
            {
                if (String.IsNullOrEmpty(sNumero))
                {
                    dResult = dDef;
                }
                else
                {
                    dResult = Convert.ToInt32(sNumero.Trim());
                }
            }
            catch
            {
                dResult = dDef;
            }
            return dResult;
        }

        /// <summary>
        /// Pasar un objeto a long
        /// </summary>
        /// <param name="Numero">Objeto a pasar a long</param>
        /// <param name="dDef">Valor por defecto a asignar en caso de error</param>
        /// <returns>Numero transformado a long o en su defecto el valor dDef</returns>
        public static long StrToInt64Def(object Numero, long dDef)
        {
            //Función: Igual que StrToFloat pero devuelve Def cuando se produzca una
            //exception.
            long dResult = dDef;
            try
            {
                if (Numero == null || Numero is DBNull)
                {
                    dResult = dDef;
                }
                else
                {
                    // Esto da error al convertir un float con decimales, lo cambio por el que debería ser.
                    //iResult = Convert.ToInt32(Numero.ToString().Trim());
                    if (Numero is String) { LimpiaCadena(ref Numero); }
                    dResult = Convert.ToInt64(Numero);
                }
            }
            catch
            {
                dResult = dDef;
            }
            return dResult;
        }
        /// <summary>
        /// Pasar una cadena a long
        /// </summary>
        /// <param name="sNumero">Cadena a pasar a long</param>
        /// <param name="dDef">Valor por defecto a asignar en caso de error</param>
        /// <returns>sNumero transformado a long o en su defecto el valor dDef</returns>
        public static long StrToInt64Def(string sNumero, long dDef)
        {
            //Función: Igual que StrToFloat pero devuelve Def cuando se produzca una
            //exception.
            long dResult = dDef;
            try
            {
                if (String.IsNullOrEmpty(sNumero))
                {
                    dResult = dDef;
                }
                else
                {
                    dResult = Convert.ToInt64(sNumero.Trim());
                }
            }
            catch
            {
                dResult = dDef;
            }
            return dResult;
        }

        #endregion

        #region Conversión de Números Arabes a Romanos y viceversa
        /// <summary>
        /// Transforma números romanos a Árabes.
        /// </summary>
        /// <param name="Romano">Cadena con el número romano</param>
        /// <returns>Número árabe equivalente al pasado como parámetro(romano)</returns>
        public static int ConvertirRomanToArabe(string Romano)
        {
            int Numero = 0;
            int Valor1 = 1;
            int Valor2 = 0;
            //int i = 0;
            string Cadena = null;

            if (Romano.Trim().Length == 0)
                return 0;
            Cadena = Romano.Trim();
            while (Cadena.Length != 0)
            {
                Valor1 = VerValor(Cadena[0].ToString());
                Cadena = Cadena.Substring(1, Cadena.Length - 1);
                if (Cadena.Trim().Length == 0)
                    Valor2 = 0;
                else
                    Valor2 = VerValor(Cadena[0].ToString());
                if (Valor1 >= Valor2)
                    Numero = Numero + Valor1;
                else
                    Numero = Numero - Valor1;
            }
            return Numero;
        }


        /// <summary>
        /// Transforma números árabes a romanos
        /// </summary>
        /// <param name="Numero">número árabe a transformar.</param>
        /// <returns>número romano equivalente al pasado como parámetro</returns>
        public static string ConvertirArabeToRoman(int Numero)
        {
            string Romano = "";
            int I = 0;
            int Digito = 0;
            int x = 0;
            string Cadena = string.Empty;
            string CadenaTmp = string.Empty;
            string Simbolo1 = string.Empty;
            string Simbolo2 = string.Empty;
            string Simbolo3 = string.Empty;

            Cadena = Convert.ToString(Numero);
            for (x = 0; x <= Cadena.Length; x++)
            {
                if (Cadena.Length == 4)
                {
                    Simbolo1 = "M";
                    Simbolo2 = "Q";
                    Simbolo3 = "H";
                    Digito = Convert.ToInt32(Cadena.Substring(0, 1));
                    Cadena = Cadena.Substring(1, 3);
                }
                else
                    if (Cadena.Length == 3)
                    {
                        Simbolo1 = "C";
                        Simbolo2 = "D";
                        Simbolo3 = "M";
                        Digito = Convert.ToInt32(Cadena.Substring(0, 1));
                        Cadena = Cadena.Substring(1, 2);
                    }
                    else
                        if (Cadena.Length == 2)
                        {
                            Simbolo1 = "X";
                            Simbolo2 = "L";
                            Simbolo3 = "C";
                            Digito = Convert.ToInt32(Cadena.Substring(0, 1));
                            Cadena = Cadena.Substring(1, 1);
                        }
                        else
                            if (Cadena.Length == 1)
                            {
                                Simbolo1 = "I";
                                Simbolo2 = "V";
                                Simbolo3 = "X";
                                Digito = Convert.ToInt32(Cadena.Substring(0, 1));
                                Cadena = "";
                            }
                if (Digito <= 3)
                {
                    for (I = 1; I <= Digito; I++)
                        CadenaTmp = CadenaTmp + Simbolo1;
                }
                else
                    if (Digito < 5)
                    {
                        CadenaTmp = Simbolo1 + Simbolo2;
                    }
                    else
                        if (Digito == 5)
                        {
                            CadenaTmp = Simbolo2;
                        }
                        else
                            if (Digito <= 8)
                            {
                                CadenaTmp = CadenaTmp + Simbolo2;
                                for (I = 1; I <= Digito - 5; I++)
                                {
                                    CadenaTmp = CadenaTmp + Simbolo1;
                                }
                            }
                            else
                                if (Digito == 9)
                                    CadenaTmp = CadenaTmp + Simbolo3;

                Romano = Romano + CadenaTmp;
                CadenaTmp = "";
            }

            return Romano;

        }

        private static int VerValor(string Simbolo)
        {
            int resultValue = 0;
            switch (Simbolo)
            {
                case "I": resultValue = 1; break;
                case "V": resultValue = 5; break;
                case "X": resultValue = 10; break;
                case "L": resultValue = 50; break;
                case "C": resultValue = 100; break;
                case "D": resultValue = 500; break;
                case "M": resultValue = 1000; break;
                default:
                    resultValue = 0; break;
            }
            return resultValue;
        }
        #endregion

        #region Operaciones Matemáticas

        /// <summary>
        /// Devuelve la suma de los objetos contenidos en el array pasado como parametro. Si el objeto, no es un Array, intenta devolver su valor.
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Por defecto devuelve 0.</returns>
        public static decimal SumaDec(object valores)
        {
            decimal resultado = 0;

            if (valores is Array)
            {
                foreach (object valor in (Array)valores)
                {
                    resultado += StrToDecimalDef(valor, 0);
                }
            }
            else
            {
                resultado = StrToDecimalDef(valores, 0);
            }
            return resultado;
        }
        /// <summary>
        /// Devuelve la suma de los objetos contenidos en el array pasado como parametro. Si el objeto, no es un Array, intenta devolver su valor.
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Por defecto devuelve 0.</returns>
        public static decimal Suma(object valores)
        {
            return SumaDec(valores);
        }

        /// <summary>
        /// Devuelve la suma de los parámetros especificados.
        /// </summary>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static decimal SumaDec(params object[] valores)
        {
            decimal resultado = 0;

            foreach (object valor in valores)
            {
                resultado += SumaDec(valor);
            }
            return resultado;
        }
        #endregion

        #region Funciones auxiliares

        /// <summary>
        /// Efectua un Trim() a la cadena, si es que lo fuera, pasada como parametro.
        /// </summary>
        /// <param name="numero"></param>
        private static void LimpiaCadena(ref object numero)
        {
            if (numero is String) { numero = ((string)numero).Trim(); }
        }

        #endregion

        #region Fracciones
        /// <summary>
        /// Convierte una cadena de tipo fracción (1/4) en su valor numérico (0.25)
        /// </summary>
        /// <param name="sFraccion"></param>
        /// <returns></returns>
        public static decimal ConvierteFraccionEnValor(string sFraccion)
        {
            decimal dValor = 0;
            char[] separador = { '/' };
            decimal iNumerador = 0;
            decimal iDenominador = 0;

            if (sFraccion.Contains("/"))
            {
                string[] fraccion = sFraccion.Split(separador);
                if (fraccion.Length > 0)
                {
                    iNumerador = Numeros.StrToDecimalDef(fraccion[0].ToString(), 0);
                    iDenominador = Numeros.StrToDecimalDef(fraccion[1].ToString(), 0);

                    if (iDenominador > 0)
                        dValor = (iNumerador / iDenominador);
                }
            }
            return dValor;
        }

        #endregion
    }
}
