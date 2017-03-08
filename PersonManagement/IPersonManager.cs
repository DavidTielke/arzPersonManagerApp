using System.Linq;
using ARZ.PersonManagerApp.CrossCutting.DataClasses;

namespace ARZ.PersonManagerApp.Logic.PersonManagement
{
    public interface IPersonManager
    {
        IQueryable<Person> GetAllChildren();
        IQueryable<Person> GetAdults();
        AgeStatistic GetAgeStatistic();
    }
}