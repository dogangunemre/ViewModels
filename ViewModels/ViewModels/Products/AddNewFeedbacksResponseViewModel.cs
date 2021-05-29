using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewFeedbacksResponseViewModel : ResponseViewModel<AddNewFeedbacksRequestData, AddNewFeedbacksResponseData>
    {
        public AddNewFeedbacksResponseViewModel() : base()
        {

        }
        public AddNewFeedbacksResponseViewModel(AddNewFeedbacksRequestData RequestData) : base(RequestData)
        {

        }
    }
}