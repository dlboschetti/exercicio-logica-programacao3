using System;

namespace exercicio_logica_programacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converter celsius em fahrenheit e vice versa:

            //Crie duas funções para conversão de temperaturas: uma converterá celsius em fahrenheit e a outra fará o inverso.
            //Saiba que 100c é igual a 212f.

            Console.WriteLine("Digite 1 para converter de celsius para fahrenheit e 2 para converter fahrenheit para celsius: ");
            int opcao = Convert.ToInt32( Console.ReadLine());

            double valorConvertido;
            if (opcao == 1)
            {
                Console.WriteLine("Informe o valor em gra Celsius:");
                double valorCelsius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Temperatura convertida para grau Fahrenheit:");
                valorConvertido = (valorCelsius * 9/5)+32;
                Console.WriteLine(valorConvertido);
            }
            else
            {
                if (opcao == 2)
                {
                    Console.WriteLine("Informe o valor em grau Fahrenheit:");
                    double valorFahrenheit = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Temperatura convertida para grau Celsius:");
                    valorConvertido = (valorFahrenheit - 32) * 5/9;
                    Console.WriteLine(valorConvertido);
                }
                else
                    Console.WriteLine("Opção incorreta, escolha entre 1 ou 2");

            }

        }
    }
}
