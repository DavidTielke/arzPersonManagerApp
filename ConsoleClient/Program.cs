using System;
using System.Linq;
using ARZ.PersonManagerApp.Infrastructure.Mappings;
using ARZ.PersonManagerApp.Logic.PersonManagement;
using Ninject;

namespace ARZ.PersonManagerApp.UI.ConsoleClient
{
    class Program
    {
        private static IPersonManager _manager;

        static Program()
        {
            var kernel = new StandardKernel(new Aggregator().Mappings);

            _manager = kernel.Get<IPersonManager>();
        }

        static void Main(string[] args)
        {
            PrintAdults();
            PrintChildren();

            Console.ReadKey();
        }

        private static void PrintChildren()
        {
            var amountChildren = _manager.GetAgeStatistic().AmountChildren;
            var children = _manager.GetAllChildren();
            Console.WriteLine($"### Kinder ({amountChildren}) ###");
            children.ToList().ForEach(p => Console.WriteLine(p.Name));
        }

        private static void PrintAdults()
        {
            var amountAdults = _manager.GetAgeStatistic().AmountAdults;
            var adults = _manager.GetAdults();
            Console.WriteLine($"### Erwachsene ({amountAdults}) ###");
            adults.ToList().ForEach(p => Console.WriteLine(p.Name));
        }
    }
}
