#pragma checksum "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65feb14b6fdad043c466e8e9b97e58696d4ab622"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\AddEmployee.razor"
using BlazorCrud.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addemployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\AddEmployee.razor"
       
    Contact emp = new Contact();

    protected async Task CreateEmployee()
    {
        await Http.SendJsonAsync(HttpMethod.Post, "/api/Employee/Create", emp);
        urlNavigationManager.NavigateTo("/fetchemployee");
    }

    void Cancel()
    {
        urlNavigationManager.NavigateTo("/fetchemployee");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager urlNavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591