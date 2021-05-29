using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class CountAllResponseViewModel : ResponseViewModel<CountAllRequestData, CountAllResponseData>
    {
        public CountAllResponseViewModel() : base()
        {

        }
        public CountAllResponseViewModel(CountAllRequestData RequestData) : base(RequestData)
        {

        }

    }
}