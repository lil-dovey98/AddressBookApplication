#pragma checksum "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3d259041061aee1a9a57e9a55387617aab08afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Addresses_Delete), @"mvc.1.0.view", @"/Views/Addresses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Addresses/Delete.cshtml", typeof(AspNetCore.Views_Addresses_Delete))]
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
#line 1 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d259041061aee1a9a57e9a55387617aab08afe", @"/Views/Addresses/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Addresses_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Address>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Address</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(252, 45, false);
#line 15 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Forenames));

#line default
#line hidden
            EndContext();
            BeginContext(297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(341, 41, false);
#line 18 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Forenames));

#line default
#line hidden
            EndContext();
            BeginContext(382, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(426, 43, false);
#line 21 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 39, false);
#line 24 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(552, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(596, 50, false);
#line 27 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLineOne));

#line default
#line hidden
            EndContext();
            BeginContext(646, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(690, 46, false);
#line 30 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AddressLineOne));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(780, 50, false);
#line 33 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLineTwo));

#line default
#line hidden
            EndContext();
            BeginContext(830, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(874, 46, false);
#line 36 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AddressLineTwo));

#line default
#line hidden
            EndContext();
            BeginContext(920, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(964, 44, false);
#line 39 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Postcode));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1052, 40, false);
#line 42 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Postcode));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1136, 40, false);
#line 45 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Town));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1220, 36, false);
#line 48 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Town));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1300, 43, false);
#line 51 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1387, 39, false);
#line 54 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1470, 41, false);
#line 57 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1555, 37, false);
#line 60 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1636, 44, false);
#line 63 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MobileNo));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1724, 40, false);
#line 66 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MobileNo));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1802, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2370cb96e8204440a56b4799257286ef", async() => {
                BeginContext(1828, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1838, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7666a913c2441e3ae54ca83c59447da", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "D:\InterviewAssignment\AddressBookApplication\WebApplication1\WebApplication1\Views\Addresses\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1874, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1958, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdda5c1736484ddd829a1abf13325efc", async() => {
                    BeginContext(1980, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1996, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2009, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591