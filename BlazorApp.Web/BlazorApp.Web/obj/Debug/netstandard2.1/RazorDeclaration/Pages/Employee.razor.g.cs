#pragma checksum "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\Pages\Employee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cd5bd4d63b199bc30212da8e0751447c77f636d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using BlazorApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\_Imports.razor"
using BlazorApp.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\Pages\Employee.razor"
using BlazorApp.Web.Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "D:\Projects\Blazor-WebAssembly-Sample\BlazorApp.Web\BlazorApp.Web\Pages\Employee.razor"
       
    public Common.Employee employeeEntry= new Common.Employee();
    public List<Common.Employee> employees= new List<Common.Employee>();
    public bool AddNewOptionOpen = false;
    public bool AnyAlert = false;
    public string Message = string.Empty;
    public string AlertClass = "";
    protected override async Task OnInitializedAsync()
    {
        var respone = await Http.GetFromJsonAsync<Common.Employee[]>("sample-data/employee.json");
        employees = respone.ToList();

    }
    public void UpdateAddOption()
    {
        AddNewOptionOpen = !AddNewOptionOpen;
    }
    public void SaveNewEntry()
    {
        employeeEntry.Id= employees[employees.Count() - 1].Id + 1;
        employees.Add(employeeEntry);

        employeeEntry = new Common.Employee();
        Alert("Save Successfully",AlertEnum.Success);
    }



    public void Alert(string message,string type)
    {
        Message = message;
        AnyAlert = true;
        AlertClass = type;



    }
    public void DismissAlert()
    {
        AnyAlert = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
