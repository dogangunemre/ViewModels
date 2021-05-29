using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Customers
{
    public class ListNewOnesResponseViewModel:ResponseViewModel<ListNewOnesRequestData,ListNewOnesResponseData>
    {
        public ListNewOnesResponseViewModel() : base()
        {

        }
        public ListNewOnesResponseViewModel(ListNewOnesRequestData RequestData):base(RequestData)
        {
            
        }
    }
}