using BethanysPieShopHRM.Shared.Domain;
using BlazorAssemblyEjemplo.Models;
using BlazorAssemblyEjemplo.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorAssemblyEjemplo.Pages
{
    public partial class EmployeeDetail
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        /// <summary>
        /// Al agregar Parameter al atributo cuyo nombre es el mismo
        /// que se usa como parametro en la URL/Page. En cierta forma
        /// es como sobrecargarlo ya que tomara los datos tanto de
        /// la url como si se lo usara como INPUT
        /// </summary>
        [Parameter]
        public String EmployeeId { get; set; }

        public Employee? Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            this.Employee = await this.EmployeeDataService.GetEmployeeDetails(
                int.Parse(this.EmployeeId));
        }
    }
}