using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
   
    public class IsExistResponseViewModel:ResponseViewModel<IsExistRequestData,IsExistResponseData>
    {
        public IsExistResponseViewModel(IsExistRequestData RequestData):base(RequestData)
        {
            
        }
    }
}