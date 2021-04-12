using System;
using Microsoft.Extensions.DependencyInjection;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection collection = new ServiceCollection();
            collection.AddTransient<ICalculo, Soma>();
            collection.AddTransient<ICalculo, Multiplicacao>();
            collection.AddSingleton<Calculadora>();
            IServiceProvider serviceProvider = collection.BuildServiceProvider();

            Calculadora calculadora = serviceProvider.GetService<Calculadora>();

            calculadora.EfeturarCalculo(10, 20);
            Console.Read();
        }
    }
}