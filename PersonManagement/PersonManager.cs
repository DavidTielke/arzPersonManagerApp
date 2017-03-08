using System.Linq;
using ARZ.PersonManagerApp.CrossCutting.DataClasses;
using ARZ.PersonManagerApp.Data.DataStoring;

namespace ARZ.PersonManagerApp.Logic.PersonManagement
{
    public class PersonManager
    {
        private readonly PersonRepository _repository;

        public PersonManager()
        {
            _repository = new PersonRepository();
        }

        public IQueryable<Person> GetAllChildren()
        {
            return _repository.LoadAll().Where(p => p.Age < 18);
        }

        public IQueryable<Person> GetAdults()
        {
            return _repository.LoadAll().Where(p => p.Age >= 18);
        }

        public AgeStatistic GetAgeStatistic()
        {
            return new AgeStatistic
            {
                AmountAdults = GetAdults().Count(),
                AmountChildren = GetAllChildren().Count()
            };
        }
    }
}