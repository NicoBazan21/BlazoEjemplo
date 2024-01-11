using BethanysPieShopHRM.Shared.Domain;
using BlazorAssemblyEjemplo.Models;
using BlazorAssemblyEjemplo.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorAssemblyEjemplo.Pages
{
    public partial class EmployeeOverview
    {
        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }
        public List<Employee>? Employees { get; set; } = default!;

        private Employee? _selectedEmployee;

        private String Title = "Employee overview";

        /// <summary>
        /// OnInitialized es el equivalente a NgOnInit de Angular.
        /// *Recordar*
        /// Al ser un componente, en el momento de su creacion y principio de su ciclo de vida,
        /// se llama a la funcion OnInitialized/NgOnInit
        /// </summary>
        /*protected override void OnInitialized()
        => Employees = MockDataService.Employees;*/

        protected override async Task OnInitializedAsync()
        {
            this.Employees = (await this.EmployeeDataService.GetAllEmployees()).ToList();
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        => this._selectedEmployee = selectedEmployee;
    }
}