using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Ohtap.ECommerce.Domain.Models.Core.Communication;


namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Campaigns
{
    [DataContract]
    public class AddNewRuleConstraintResponseViewModel
    {
        public AddNewRuleConstraintRequestData RequestData { get; set; }
        public AddNewRuleConstraintResponseData ResponseData { get; set; }

    }
}