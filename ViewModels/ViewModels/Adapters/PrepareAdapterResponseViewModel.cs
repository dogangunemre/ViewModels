using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Adapters
{

    public class PrepareAdapterResponseViewModel:ResponseViewModel<PrepareAdapterRequestData, PrepareAdapterResponseData>
    {
        public PrepareAdapterResponseViewModel() : base()
        {

        }

        public PrepareAdapterResponseViewModel(PrepareAdapterRequestData RequestData):base(RequestData)
        {
            
        }

    }
}