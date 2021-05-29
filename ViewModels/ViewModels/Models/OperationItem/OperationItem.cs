using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.Models.OperationItem
{
    public class OperationItem<T> : Objecta
        where T : Objecta
    {
        public T Item { get; set; }
        public int OperationDate { get; set; }

        public OperationItem()
        {

        }
        public OperationItem(T item, int operationDate)
        {
            this.Item = item;
            this.OperationDate = operationDate;
        }
    }
}
