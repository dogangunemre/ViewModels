using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Files
{
    public class CountDeletedOnesResponseViewModel : ResponseViewModel<CountDeletedOnesRequestData, CountDeletedOnesResponseData>
    {
        public CountDeletedOnesResponseViewModel() : base()
        {

        }
        public CountDeletedOnesResponseViewModel(CountDeletedOnesRequestData RequestData) : base(RequestData)
        {

        }
    }
}