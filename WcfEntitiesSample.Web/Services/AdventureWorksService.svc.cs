using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using WcfEntitiesSample.Model;

namespace WcfEntitiesSample.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdventureWorksService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdventureWorksService.svc or AdventureWorksService.svc.cs at the Solution Explorer and start debugging.
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AdventureWorksService : IAdventureWorksService
    {
        [OperationContract]
        public Product GetProductByID(int id)
        {
            var mgr = new ProductManager();
            return mgr.GetProductById(id);
        }
    }
}
