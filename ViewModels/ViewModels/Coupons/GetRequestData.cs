using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Coupons
{
    public class GetRequestData:IRequestData
    {
        public string CouponID { get; set; }

    }
}