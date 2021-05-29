using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Coupons
{
    public class ListAllResponseData:IResponseData
    {
        public CouponList Coupons { get; set; }

    }
}