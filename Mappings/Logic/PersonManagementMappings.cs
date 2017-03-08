using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARZ.PersonManagerApp.Logic.PersonManagement;
using Ninject.Modules;

namespace ARZ.PersonManagerApp.Infrastructure.Mappings.Logic
{
    class PersonManagementMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonManager>().To<PersonManager>();
        }
    }
}
