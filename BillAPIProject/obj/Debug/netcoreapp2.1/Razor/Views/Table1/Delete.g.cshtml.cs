#pragma checksum "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f461c44875b7414b715169e0d9687c454f492edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table1_Delete), @"mvc.1.0.view", @"/Views/Table1/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Table1/Delete.cshtml", typeof(AspNetCore.Views_Table1_Delete))]
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
#line 1 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\_ViewImports.cshtml"
using BillAPIProject;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\_ViewImports.cshtml"
using BillAPIProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f461c44875b7414b715169e0d9687c454f492edc", @"/Views/Table1/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8b05dfab381d84e9f68f84e61ba18bd61f0ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Table1_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillAPIProject.Models.Table1>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 167, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Table1</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(249, 45, false);
#line 15 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PartnerId));

#line default
#line hidden
            EndContext();
            BeginContext(294, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(338, 41, false);
#line 18 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PartnerId));

#line default
#line hidden
            EndContext();
            BeginContext(379, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(423, 46, false);
#line 21 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 42, false);
#line 24 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(555, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(599, 48, false);
#line 27 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(647, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(691, 44, false);
#line 30 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(735, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(779, 41, false);
#line 33 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MpnId));

#line default
#line hidden
            EndContext();
            BeginContext(820, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(864, 37, false);
#line 36 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MpnId));

#line default
#line hidden
            EndContext();
            BeginContext(901, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(945, 43, false);
#line 39 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(988, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1032, 39, false);
#line 42 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1115, 72, false);
#line 45 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SyndicationPartnerSubscriptionNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1231, 68, false);
#line 48 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SyndicationPartnerSubscriptionNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1343, 43, false);
#line 51 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1430, 39, false);
#line 54 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1513, 50, false);
#line 57 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DurableOfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1607, 46, false);
#line 60 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DurableOfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1653, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1697, 45, false);
#line 63 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OfferName));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1786, 41, false);
#line 66 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OfferName));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1871, 57, false);
#line 69 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1972, 53, false);
#line 72 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2069, 55, false);
#line 75 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2168, 51, false);
#line 78 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2263, 51, false);
#line 81 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ChargeStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2314, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2358, 47, false);
#line 84 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ChargeStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2405, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2449, 49, false);
#line 87 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ChargeEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2498, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2542, 45, false);
#line 90 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ChargeEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2631, 46, false);
#line 93 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ChargeType));

#line default
#line hidden
            EndContext();
            BeginContext(2677, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2721, 42, false);
#line 96 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ChargeType));

#line default
#line hidden
            EndContext();
            BeginContext(2763, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2807, 45, false);
#line 99 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2896, 41, false);
#line 102 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2937, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2981, 44, false);
#line 105 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(3025, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3069, 40, false);
#line 108 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(3109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3153, 42, false);
#line 111 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(3195, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3239, 38, false);
#line 114 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(3277, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3321, 54, false);
#line 117 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalOtherDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(3375, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3419, 50, false);
#line 120 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalOtherDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(3469, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3513, 44, false);
#line 123 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3601, 40, false);
#line 126 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(3641, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3685, 39, false);
#line 129 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(3724, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3768, 35, false);
#line 132 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(3803, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3847, 52, false);
#line 135 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalForCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(3899, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3943, 48, false);
#line 138 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalForCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(3991, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4035, 44, false);
#line 141 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(4079, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4123, 40, false);
#line 144 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(4163, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4207, 46, false);
#line 147 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DomainName));

#line default
#line hidden
            EndContext();
            BeginContext(4253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4297, 42, false);
#line 150 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DomainName));

#line default
#line hidden
            EndContext();
            BeginContext(4339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4383, 52, false);
#line 153 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionName));

#line default
#line hidden
            EndContext();
            BeginContext(4435, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4479, 48, false);
#line 156 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionName));

#line default
#line hidden
            EndContext();
            BeginContext(4527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4571, 59, false);
#line 159 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionDescription));

#line default
#line hidden
            EndContext();
            BeginContext(4630, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4674, 55, false);
#line 162 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionDescription));

#line default
#line hidden
            EndContext();
            BeginContext(4729, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4773, 52, false);
#line 165 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BillingCycleType));

#line default
#line hidden
            EndContext();
            BeginContext(4825, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4869, 48, false);
#line 168 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BillingCycleType));

#line default
#line hidden
            EndContext();
            BeginContext(4917, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4955, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f18737478bc343998431b425100d5e72", async() => {
                BeginContext(4981, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4991, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86d8ac4efe2c4201aa17c889af4eb5b3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 173 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubscriptionId);

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
                BeginContext(5039, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(5123, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15176e9f6195467eaaf4224344bc11a6", async() => {
                    BeginContext(5145, 12, true);
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
                BeginContext(5161, 6, true);
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
            BeginContext(5174, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillAPIProject.Models.Table1> Html { get; private set; }
    }
}
#pragma warning restore 1591
