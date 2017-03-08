using System;
using System.Linq;
using ARZ.PersonManagerApp.Logic.PersonManagement;

namespace ARZ.PersonManagerApp.UI.ConsoleClient
{
    class Program
    {
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

        private static PersonManager _manager;

        static Program()
        {
            _manager = new PersonManager();
        }
    }
}
