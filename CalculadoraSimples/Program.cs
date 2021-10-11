using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora op = new Calculadora();
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            op.Soma(num1, num2);//posso chamar quantas vezes eu quiser
            op.Sub(num1, num2);
            op.Div(num1, num2);
            op.Mult(num1, num2);

        }
    }
}
