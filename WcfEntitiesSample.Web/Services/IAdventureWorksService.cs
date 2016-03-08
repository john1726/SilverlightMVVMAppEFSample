using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfEntitiesSample.Model;

namespace WcfEntitiesSample.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdventureWorksService" in both code and config file together.
    public interface IAdventureWorksService
    {
        Product GetProductByID(int id);
    }
}
