using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Units
{
    public class UpdateResponseViewModel : ResponseViewModel<UpdateRequestData, UpdateResponseData>
    {
        public UpdateResponseViewModel() : base()
        {

        }
        public UpdateResponseViewModel(UpdateRequestData RequestData) : base(RequestData)
        {

        }
    }
}