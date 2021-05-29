using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Specifications
{
    public class ListAllResponseViewModel : ResponseViewModel<ListAllRequestData, ListAllResponseData>
    {
        public ListAllResponseViewModel() : base()
        {

        }
        public ListAllResponseViewModel(ListAllRequestData RequestData) : base(RequestData)
        {

        }
    }
}