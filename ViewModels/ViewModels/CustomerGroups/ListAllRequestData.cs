using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.CustomerGroups
{
    public class ListAllRequestData:IRequestData
    {

        public long Offset { set; get; } = 0;
        public int Limit { set; get; } = 100;
    }
}