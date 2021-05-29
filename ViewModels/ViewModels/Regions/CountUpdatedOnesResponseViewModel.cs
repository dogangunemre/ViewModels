using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Regions
{
    public class CountUpdatedOnesResponseViewModel : ResponseViewModel<CountUpdatedOnesRequestData, CountUpdatedOnesResponseData>
    {
        public CountUpdatedOnesResponseViewModel() : base()
        {

        }
        public CountUpdatedOnesResponseViewModel(CountUpdatedOnesRequestData RequestData) : base(RequestData)
        {

        }
    }
}