#pragma checksum "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e71fa606c6cab0ab248f17159f44de5ab787629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Partial__userTablePartial), @"mvc.1.0.view", @"/Views/Employee/Partial/_userTablePartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ravgoud\source\repos\MMMMedia\Views\_ViewImports.cshtml"
using MMMMedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ravgoud\source\repos\MMMMedia\Views\_ViewImports.cshtml"
using MMMMedia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e71fa606c6cab0ab248f17159f44de5ab787629", @"/Views/Employee/Partial/_userTablePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c3bfb45ca00104cf8b4e34e5e09e8e9cd9d3e05", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Partial__userTablePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MMMMedia.ViewModels.EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/pencil-square.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/trash3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<tbody id=\"snv-table-body\" >\r\n");
#nullable restore
#line 3 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
      
        var users = Model.EmployeeMasterData.ToArray();

        for (int i = 0; i < users.Count(); i++)
        {
            var user = users[i];
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=", 262, "", 307, 1);
#nullable restore
#line 10 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
WriteAttributeValue("", 269, i % 2 == 0 ? "" : "table-secondary", 269, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td scope=\"col\">");
#nullable restore
#line 11 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
                            Write(user.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"col\">");
#nullable restore
#line 12 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
                           Write(user.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"col\">");
#nullable restore
#line 13 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
                           Write(user.Designation.DesignationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"col\">");
#nullable restore
#line 14 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"col\">");
#nullable restore
#line 15 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
                           Write(user.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"col\">");
#nullable restore
#line 16 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
                           Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                          \r\n                <td scope=\"col\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 731, "\"", 806, 1);
#nullable restore
#line 18 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
WriteAttributeValue("", 738, Url.Action("GetRecord", "Employee",new { userId = user.EmployeeID}), 738, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e71fa606c6cab0ab248f17159f44de5ab7876296997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 954, 1);
#nullable restore
#line 19 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
WriteAttributeValue("", 883, Url.Action("RemoveRecord", "Employee",new { userId = user.EmployeeID}), 883, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e71fa606c6cab0ab248f17159f44de5ab7876298479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\ravgoud\source\repos\MMMMedia\Views\Employee\Partial\_userTablePartial.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MMMMedia.ViewModels.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
