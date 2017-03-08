using System.Linq;
using ARZ.PersonManagerApp.CrossCutting.DataClasses;

namespace ARZ.PersonManagerApp.Data.DataStoring
{
    public interface IPersonRepository
    {
        IQueryable<Person> LoadAll();
    }
}