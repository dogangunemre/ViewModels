using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Adapters
{

    public class GetConfigResponseViewModel:ResponseViewModel<GetConfigRequestData,GetConfigResponseData>
    {
        public GetConfigResponseViewModel() : base()
        {

        }

        public GetConfigResponseViewModel(GetConfigRequestData RequestData):base(RequestData)
        {
            
        }

    }
}