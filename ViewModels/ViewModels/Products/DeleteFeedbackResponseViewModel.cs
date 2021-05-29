﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Products
{
    public class DeleteFeedbackResponseViewModel : ResponseViewModel<DeleteFeedbackRequestData, DeleteFeedbackResponseData>
    {
        public DeleteFeedbackResponseViewModel() : base()
        {

        }
        public DeleteFeedbackResponseViewModel(DeleteFeedbackRequestData RequestData) : base(RequestData)
        {

        }
    }
}