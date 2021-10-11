using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CalculadoraSimples
{
    class Calculadora
    {
        public double soma, sub, mult, div;



        public void Soma(double num1, double num2) 
        {
            soma = num1 + num2;
            Console.WriteLine("Soma: " + soma);
        }
        public void Sub(double num1, double num2)
        {
            sub = num1 - num2;
            Console.WriteLine("Subtração: " + sub);
        }
        public void Div(double num1, double num2)
        {
            if(num2 != 0)
            {
                div = num1 / num2;
                Console.WriteLine("Divisão: " + div.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("\nDivisão não efetuada. O denominador não pode ser 0.\n");
            }
        }
        public void Mult(double num1, double num2)
        {
            mult = num1 * num2;
            Console.WriteLine("Multiplicação: " + mult);
        }

    }
}
