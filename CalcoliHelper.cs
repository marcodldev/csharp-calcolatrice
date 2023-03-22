using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    /*
     *  
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

        public static double Minimo(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public static int Massimo(int num1,int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public static double Massimo(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        //BONUS

        public static int Potenza(int num1, int num2)
        {


            if( num1 == 0 & num2 == 0)
            {
                return 1;
            }


            for(int i = 0; i < num2; i++)
            {
                int risultato = num1 * num1;
            }
           

            return risultato;
        }
    }

    
}
