using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System.Runtime.Serialization;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    public class ListDeletedOnesResponseData : IResponseData
    {
        public OperationItemList<CampaignBasic> Campaigns { get; set; }

    }
}