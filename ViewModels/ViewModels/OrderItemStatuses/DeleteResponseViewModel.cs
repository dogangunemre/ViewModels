using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.OrderItemStatuses
{
   
    public class DeleteResponseViewModel:ResponseViewModel<DeleteRequestData,DeleteResponseData>
    {
        public DeleteResponseViewModel() : base()
        {

        }
        public DeleteResponseViewModel(DeleteRequestData RequestData):base(RequestData)
        {
            
        }

    }
}