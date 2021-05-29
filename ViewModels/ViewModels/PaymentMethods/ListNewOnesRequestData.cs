using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.PaymentMethods
{
    public class ListNewOnesRequestData:IRequestData
    {
        public int OperationDate { get; set; }

        public long Offset { set; get; } = 0;
        public int Limit { set; get; } = 100;
    }
}