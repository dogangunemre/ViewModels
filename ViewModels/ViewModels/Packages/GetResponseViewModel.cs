using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class GetResponseViewModel : ResponseViewModel<GetRequestData, GetResponseData>
    {
        public GetResponseViewModel() : base()
        {

        }
        public GetResponseViewModel(GetRequestData RequestData) : base(RequestData)
        {

        }
    }
}