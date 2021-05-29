using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Settings
{
    public class CountNewOnesResponseViewModel : ResponseViewModel<CountNewOnesRequestData, CountNewOnesResponseData>
    {
        public CountNewOnesResponseViewModel() : base()
        {

        }
        public CountNewOnesResponseViewModel(CountNewOnesRequestData RequestData) : base(RequestData)
        {

        }
    }
}