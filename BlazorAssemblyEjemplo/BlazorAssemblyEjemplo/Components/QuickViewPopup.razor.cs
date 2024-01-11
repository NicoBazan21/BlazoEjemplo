using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorAssemblyEjemplo.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }

        private Employee? _employee;

        protected override void OnParametersSet()
        => this._employee = Employee;

        public void Close()
        => _employee = null;
    }
}