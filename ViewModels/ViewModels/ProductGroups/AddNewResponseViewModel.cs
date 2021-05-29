using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.ProductGroups
{

    public class AddNewResponseViewModel:ResponseViewModel<AddNewRequestData,AddNewResponseData>
    {
        public AddNewResponseViewModel() : base()
        {

        }
        public AddNewResponseViewModel(AddNewRequestData RequestData):base(RequestData)
        {
            
        }

    }
}