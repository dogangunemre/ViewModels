﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Settings
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