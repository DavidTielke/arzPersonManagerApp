using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARZ.PersonManagerApp.Data.DataStoring;
using ARZ.PersonManagerApp.Infrastructure.Mappings.Data;
using ARZ.PersonManagerApp.Infrastructure.Mappings.Logic;
using ARZ.PersonManagerApp.Logic.PersonManagement;
using Ninject;
using Ninject.Modules;

namespace ARZ.PersonManagerApp.Infrastructure.Mappings
{
    public class Aggregator
    {
        public INinjectModule[] Mappings
        {
            get
            {
                return new INinjectModule[]
                {
                    new DataStoringMappings(), 
                    new PersonManagementMappings(), 
                };
            }
        }
    }
}
