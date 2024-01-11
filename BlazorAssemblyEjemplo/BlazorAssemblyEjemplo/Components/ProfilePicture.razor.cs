using Microsoft.AspNetCore.Components;

namespace BlazorAssemblyEjemplo.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
