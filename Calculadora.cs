using System;
using Aritmeticas;

class Calcula
{
	public static void Main(string[] args)
    {
		Console.WriteLine("Llamando metodos de BioOprs.DLL");
		if(args.Length != 2)
        {
			Console.WriteLine("Uso: Calculadora <mul> <mul2>");
			return;
		}
		long num1 = long.Parse(args[0]);
		long num2 = long.Parse(args[1]);
		long suma = ClaseSuma.suma(num1, num2);
		long resta = ClaseResta.resta(num1, num2);
		long producto = ClaseMult.mult(num1, num2);
		double division = ClaseDiv.div(num1, num2);
		Console.WriteLine("{0} + {1} = {2}", num1, num2, suma);
		Console.WriteLine("{0} - {1} = {2}", num1, num2, resta);
		Console.WriteLine("{0} * {1} = {2}", num1, num2, producto);
		Console.WriteLine("{0} / {1} = {2}", num1, num2, division);
	}

}