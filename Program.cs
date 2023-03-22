// See https://aka.ms/new-console-template for more information
using csharp_calcolatrice;

Console.WriteLine("Test metodi classe statica CalcoliHelper");
Console.WriteLine("Numeri utilizzati per i test con due valori: 2 , 5");
Console.WriteLine("Numero utilizzato per i test con un valore: 2");

Console.WriteLine(System.Environment.NewLine);




Console.WriteLine("Test metodo Somma");
Console.WriteLine(CalcoliHelper.Somma(2,5));
Console.WriteLine(System.Environment.NewLine);


Console.WriteLine("Test metodo Differenza");
Console.WriteLine(CalcoliHelper.Differenza(2, 5));
Console.WriteLine(System.Environment.NewLine);


Console.WriteLine("Test metodo Moltiplicazione");
Console.WriteLine(CalcoliHelper.Moltiplicazione(2, 5));
Console.WriteLine(System.Environment.NewLine);


Console.WriteLine("Test metodo Valore Assoluto con numero positivo");
Console.WriteLine(CalcoliHelper.ValoreAssoluto(2));
Console.WriteLine(System.Environment.NewLine);


Console.WriteLine("Test metodo Valore Assoluto con numero negativo");
Console.WriteLine(CalcoliHelper.ValoreAssoluto(-2));
Console.WriteLine(System.Environment.NewLine);


Console.WriteLine("Test metodo per calcolare il valore minimo");
Console.WriteLine(CalcoliHelper.Minimo(2, 5));
Console.WriteLine(System.Environment.NewLine);


Console.WriteLine("Test metodo per calcolare il valore massimo");
Console.WriteLine(CalcoliHelper.Massimo(2, 5));
Console.WriteLine(System.Environment.NewLine);