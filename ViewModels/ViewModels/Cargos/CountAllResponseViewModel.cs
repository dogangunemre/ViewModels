using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Cargos
{

    public class CountAllResponseViewModel:ResponseViewModel<CountAllRequestData,CountAllResponseData>
    {
        public CountAllResponseViewModel() : base()
        {

        }
        public CountAllResponseViewModel(CountAllRequestData RequestData):base(RequestData)
        {
            
        }
    }
}