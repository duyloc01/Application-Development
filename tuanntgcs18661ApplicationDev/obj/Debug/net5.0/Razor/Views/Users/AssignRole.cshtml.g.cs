#pragma checksum "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa9d8281116bfde110b0cf2524c853812b50b0d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AssignRole), @"mvc.1.0.view", @"/Views/Users/AssignRole.cshtml")]
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
#line 1 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\_ViewImports.cshtml"
using tuanntgcs18661ApplicationDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\_ViewImports.cshtml"
using tuanntgcs18661ApplicationDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9d8281116bfde110b0cf2524c853812b50b0d4", @"/Views/Users/AssignRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9956ff0cb532c62cf26488b7f7cd42ad60099086", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AssignRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tuanntgcs18661ApplicationDev.Models.CUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
  
    var RemainingRoleIds = (List<string>)ViewData["RemainingRoleIds"];
    var CurrentRoleIds = (List<string>)ViewData["CurrentRoleIds"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Current Roles</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
     if (CurrentRoleIds.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td colspan=\"2\">There is no role.</td></tr>\r\n");
#nullable restore
#line 19 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
    }
    else
    {
        foreach (var role in CurrentRoleIds)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
               Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa9d8281116bfde110b0cf2524c853812b50b0d45424", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 716, "\"", 729, 1);
#nullable restore
#line 28 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
WriteAttributeValue("", 724, role, 724, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 793, "\"", 810, 1);
#nullable restore
#line 29 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
WriteAttributeValue("", 801, Model.Id, 801, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger\">Remove</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Remaining Roles</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
     if (RemainingRoleIds.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td colspan=\"2\">There is no remaining role.</td></tr>\r\n");
#nullable restore
#line 45 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
    }
    else
    {
        foreach (var role in RemainingRoleIds)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
               Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa9d8281116bfde110b0cf2524c853812b50b0d49224", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 1475, "\"", 1488, 1);
#nullable restore
#line 54 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
WriteAttributeValue("", 1483, role, 1483, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 1552, "\"", 1569, 1);
#nullable restore
#line 55 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
WriteAttributeValue("", 1560, Model.Id, 1560, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-success\">Add</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\PHONGVU\Desktop\loccss\loccss\tuanntgcs18661ApplicationDev\Views\Users\AssignRole.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>\r\n<br &numsp;>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tuanntgcs18661ApplicationDev.Models.CUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
