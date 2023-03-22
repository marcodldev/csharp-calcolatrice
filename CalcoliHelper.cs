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
       * V Moltiplicazione di due numeri double
        V Valore assoluto di un numero intero
        V Valore assoluto di un numero double
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

        public static double Somma(double num1, double num2)
        {
            double risultato = num1 + num2;

            return risultato;
        }

        public static int Differenza(int num1, int num2)
        {
            int risultato =  num1 -  num2;

            return risultato;
        }

        public static double Differenza(double num1, double num2)
        {
            double risultato = num1 - num2;

            return risultato;
        }

        public static int Moltiplicazione(int num1, int num2)
        {
            int risultato = num1 * num2;

            return risultato;
        }

        public static double Moltiplicazione(double num1, double num2)
        {
            double risultato = num1 * num2;

            return risultato;
        }

        public static int ValoreAssoluto(int num)
        {
            if (num < 0)
            {
                int risultato1 = (-num);

                return risultato1;
            };

            int risultato = num;

            return risultato;
        }

        public static double ValoreAssoluto(double num)
        {
            if (num < 0)
            {
                double risultato1 = (-num);

                return risultato1;
            };

            double risultato = num;

            return risultato;
        }

        public static int Minimo(int num1, int num2)
        {
            if(num1 < num2)
            {
                return num1;
            } 
            else
            {
                return num2;
            }
        }
    }

    
}
