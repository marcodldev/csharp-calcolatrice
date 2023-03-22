using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    /*
     *  V Somma di due numeri interi
        V Somma di due numeri double
        V Differenza tra due numeri interi
        V Differenza tra due numeri double
        V Moltiplicazione di due numeri interi
        - Moltiplicazione di due numeri double
        - Valore assoluto di un numero intero
        - Valore assoluto di un numero double
        - Minimo tra due numeri interi
        - Minimo tra due numeri double
        - Massimo tra due numeri interi
        - Massimo tra due numeri double
     * 
     * 
     *
     */
    public static class CalcoliHelper
    {
        public static int Somma(int num1, int num2)
        {
           int risultato = num1 + num2;

           return risultato;
        }

        public static double SommaDouble(double num1, double num2)
        {
            double risultato = num1 + num2;

            return risultato;
        }

        public static int Differenza(int num1, int num2)
        {
            int risultato =  num1 -  num2;

            return risultato;
        }

        public static double DifferenzaDouble(double num1, double num2)
        {
            double risultato = num1 - num2;

            return risultato;
        }

        public static int Moltiplicazione(int num1, int num2)
        {
            int risultato = num1 * num2;

            return risultato;
        }
    }
}
