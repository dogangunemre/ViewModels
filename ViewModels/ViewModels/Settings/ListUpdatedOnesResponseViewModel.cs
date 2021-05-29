using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Settings
{
    public class ListUpdatedOnesResponseViewModel : ResponseViewModel<ListUpdatedOnesRequestData, ListUpdatedOnesResponseData>
    {
        public ListUpdatedOnesResponseViewModel() : base()
        {

        }
        public ListUpdatedOnesResponseViewModel(ListUpdatedOnesRequestData RequestData) : base(RequestData)
        {

        }
    }
}