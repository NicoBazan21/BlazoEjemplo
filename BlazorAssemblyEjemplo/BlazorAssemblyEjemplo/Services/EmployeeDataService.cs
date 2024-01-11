using BethanysPieShopHRM.Shared.Domain;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorAssemblyEjemplo.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
            => this._httpClient = httpClient;



        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>
                (await this._httpClient.GetStreamAsync($"api/employee"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<Employee>
                (await this._httpClient.GetStreamAsync($"api/employee/{employeeId}"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        Task<Employee> IEmployeeDataService.AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IEmployeeDataService.DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IEmployeeDataService.UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
