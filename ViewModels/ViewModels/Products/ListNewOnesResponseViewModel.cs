using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class ListNewOnesResponseViewModel : ResponseViewModel<ListNewOnesRequestData, ListNewOnesResponseData>
    {
        public ListNewOnesResponseViewModel() : base()
        {

        }
        public ListNewOnesResponseViewModel(ListNewOnesRequestData RequestData) : base(RequestData)
        {

        }
    }
}