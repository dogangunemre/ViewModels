using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class AddNewFilesResponseViewModel : ResponseViewModel<AddNewFilesRequestData, AddNewFilesResponseData>
    {
        public AddNewFilesResponseViewModel() : base()
        {

        }
        public AddNewFilesResponseViewModel(AddNewFilesRequestData RequestData) : base(RequestData)
        {

        }
    }
}