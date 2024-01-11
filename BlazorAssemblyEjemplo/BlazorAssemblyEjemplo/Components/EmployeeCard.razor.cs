using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorAssemblyEjemplo.Components
{
    public partial class EmployeeCard
    {
        /// <summary>
        /// INPUT
        /// </summary>
        [Parameter]
        public Employee Employee { get; set; } = default!;

        /// <summary>
        /// OUTPUT
        /// </summary>
        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        /// <summary>
        /// Inyeccion de dependencias. Inyecte la instancia de NavigationManager a mi componente
        /// </summary>
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateToDetails(Employee selectedEmployee)
        => this.NavigationManager.NavigateTo($"/employeedetail/{selectedEmployee.EmployeeId}");
        
        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Employee.LastName))
                throw new Exception("Last name cant be empty");
        }
    }
}