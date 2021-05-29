using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.CustomerGroups
{
    public class IsExistRequestData:IRequestData
    {
        public string CustomerGroupID { get; set; }

    }
}