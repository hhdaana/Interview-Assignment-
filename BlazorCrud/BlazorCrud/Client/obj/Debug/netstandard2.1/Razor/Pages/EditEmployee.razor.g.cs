#pragma checksum "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde240a61732c5ac4c09be06ae25c82d879ba98c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
using BlazorCrud.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{empID:int}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Employee</h2>\n<hr>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                  emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                      UpdateEmployee

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.AddMarkupContent(11, "<label class=\"control-label col-md-12\">Last Name</label>\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-4");
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                               emp.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.LastName = __value, emp.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 16 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                  () => emp.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group row");
                __builder2.AddMarkupContent(27, "\n        ");
                __builder2.AddMarkupContent(28, "<label class=\"control-label col-md-12\">First Name</label>\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-md-4");
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                               emp.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.FirstName = __value, emp.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n        ");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 23 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                  () => emp.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group row");
                __builder2.AddMarkupContent(44, "\n        ");
                __builder2.AddMarkupContent(45, "<label class=\"control-label col-md-12\">Phone Number</label>\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-md-4");
                __builder2.AddMarkupContent(48, "\n            ");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                               emp.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.PhoneNumber = __value, emp.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n        ");
                __builder2.OpenElement(55, "span");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_2(__builder2, 56, 57, 
#nullable restore
#line 30 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                        () => emp.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "\n        ");
                __builder2.AddMarkupContent(63, "<label class=\"control-label col-md-12\">Birth Date</label>\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-md-4");
                __builder2.AddMarkupContent(66, "\n            ");
                __builder2.OpenElement(67, "input");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                               emp.BirthDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.BirthDate = __value, emp.BirthDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n        ");
                __builder2.OpenElement(73, "span");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_3(__builder2, 74, 75, 
#nullable restore
#line 37 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                        () => emp.BirthDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group");
                __builder2.AddMarkupContent(80, "\n        ");
                __builder2.AddMarkupContent(81, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\n        ");
                __builder2.OpenElement(82, "button");
                __builder2.AddAttribute(83, "class", "btn btn-light");
                __builder2.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(85, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
       
    [Parameter]
    public int empID { get; set; }

    Contact emp = new Contact();

    protected override async Task OnInitializedAsync()
    {
        emp = await Http.GetJsonAsync<Contact>("/api/Employee/Details/" + empID);
    }

    protected async Task UpdateEmployee()
    {
        await Http.SendJsonAsync(HttpMethod.Put, "api/Employee/Edit", emp);
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
namespace __Blazor.BlazorCrud.Client.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
