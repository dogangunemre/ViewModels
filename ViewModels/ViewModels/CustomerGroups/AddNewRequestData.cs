using Ohtap.ECommerce.Domain.Models.Core.Communication;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.CustomerGroups;

namespace Ohtap.ERPIntegration.MikroAdapterV16.ViewModels.CustomerGroups
{
    public class AddNewRequestData:IRequestData
    {
        public CustomerGroupBasic CustomerGroup { get; set; }
    }
}