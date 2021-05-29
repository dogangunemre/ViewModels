using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Packages
{
    public class AddNewFeedbacksResponseViewModel:ResponseViewModel<AddNewFeedbacksRequestData,AddNewFeedbacksResponseData>
    {
        public AddNewFeedbacksResponseViewModel():base()
        {
            
        }

        public AddNewFeedbacksResponseViewModel(AddNewFeedbacksRequestData RequestData):base(RequestData)
        {
            
        }

    }
}