using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System.Runtime.Serialization;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Options
{
    public class IsExistResponseData : IResponseData
    {
        public bool IsExist { get; set; }
    }
}