using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem
{
    public class OperationItemList<T> : Lista<OperationItem<T>>
        where T : Objecta
    {
        public void Add(T item, int operationDate)
        {
            this.Add(new OperationItem<T>(item, operationDate));
        }
    }
}
