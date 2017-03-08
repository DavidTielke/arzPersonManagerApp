using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARZ.PersonManagerApp.Data.DataStoring;
using Ninject.Modules;

namespace ARZ.PersonManagerApp.Infrastructure.Mappings.Data
{
    class DataStoringMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonRepository>().To<PersonRepository>();
        }
    }
}
