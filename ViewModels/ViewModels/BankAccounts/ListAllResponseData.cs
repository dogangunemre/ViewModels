﻿using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.BankAccounts;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.BankAccounts
{
    public class ListAllResponseData:IResponseData
    {
        public BankAccountList BankAccounts { get; set; }

    }
}