#pragma checksum "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d094fc800226dc0fac6a9afbbe8102e605d378a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table1_Details), @"mvc.1.0.view", @"/Views/Table1/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Table1/Details.cshtml", typeof(AspNetCore.Views_Table1_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d094fc800226dc0fac6a9afbbe8102e605d378a", @"/Views/Table1/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8b05dfab381d84e9f68f84e61ba18bd61f0ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Table1_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillAPIProject.Models.Table1>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Table1</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(203, 45, false);
#line 14 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PartnerId));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 41, false);
#line 17 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.PartnerId));

#line default
#line hidden
            EndContext();
            BeginContext(333, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(377, 46, false);
#line 20 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 42, false);
#line 23 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(509, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(553, 48, false);
#line 26 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(601, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(645, 44, false);
#line 29 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(689, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(733, 41, false);
#line 32 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MpnId));

#line default
#line hidden
            EndContext();
            BeginContext(774, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(818, 37, false);
#line 35 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.MpnId));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(899, 43, false);
#line 38 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(986, 39, false);
#line 41 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1069, 72, false);
#line 44 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SyndicationPartnerSubscriptionNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1185, 68, false);
#line 47 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.SyndicationPartnerSubscriptionNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1297, 43, false);
#line 50 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1384, 39, false);
#line 53 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.OfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1467, 50, false);
#line 56 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DurableOfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1561, 46, false);
#line 59 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.DurableOfferId));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1651, 45, false);
#line 62 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OfferName));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1740, 41, false);
#line 65 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.OfferName));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1825, 57, false);
#line 68 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1926, 53, false);
#line 71 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2023, 55, false);
#line 74 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2122, 51, false);
#line 77 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2217, 51, false);
#line 80 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ChargeStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2312, 47, false);
#line 83 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.ChargeStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2359, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2403, 49, false);
#line 86 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ChargeEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2452, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2496, 45, false);
#line 89 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.ChargeEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2541, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2585, 46, false);
#line 92 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ChargeType));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2675, 42, false);
#line 95 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.ChargeType));

#line default
#line hidden
            EndContext();
            BeginContext(2717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2761, 45, false);
#line 98 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2850, 41, false);
#line 101 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2935, 44, false);
#line 104 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2979, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3023, 40, false);
#line 107 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(3063, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3107, 42, false);
#line 110 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(3149, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3193, 38, false);
#line 113 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(3231, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3275, 54, false);
#line 116 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalOtherDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(3329, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3373, 50, false);
#line 119 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalOtherDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(3423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3467, 44, false);
#line 122 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(3511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3555, 40, false);
#line 125 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(3595, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3639, 39, false);
#line 128 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(3678, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3722, 35, false);
#line 131 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(3757, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3801, 52, false);
#line 134 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalForCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(3853, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3897, 48, false);
#line 137 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalForCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(3945, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3989, 44, false);
#line 140 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(4033, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4077, 40, false);
#line 143 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(4117, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4161, 46, false);
#line 146 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DomainName));

#line default
#line hidden
            EndContext();
            BeginContext(4207, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4251, 42, false);
#line 149 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.DomainName));

#line default
#line hidden
            EndContext();
            BeginContext(4293, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4337, 52, false);
#line 152 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionName));

#line default
#line hidden
            EndContext();
            BeginContext(4389, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4433, 48, false);
#line 155 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionName));

#line default
#line hidden
            EndContext();
            BeginContext(4481, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4525, 59, false);
#line 158 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionDescription));

#line default
#line hidden
            EndContext();
            BeginContext(4584, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4628, 55, false);
#line 161 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionDescription));

#line default
#line hidden
            EndContext();
            BeginContext(4683, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4727, 52, false);
#line 164 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BillingCycleType));

#line default
#line hidden
            EndContext();
            BeginContext(4779, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4823, 48, false);
#line 167 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
       Write(Html.DisplayFor(model => model.BillingCycleType));

#line default
#line hidden
            EndContext();
            BeginContext(4871, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4918, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "228119b42c9b4a96ab4f760cc2b68028", async() => {
                BeginContext(4976, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 172 "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\Details.cshtml"
                           WriteLiteral(Model.SubscriptionId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4984, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(4992, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ab3868888c422b8b81fb6ded2a57e8", async() => {
                BeginContext(5014, 12, true);
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
            BeginContext(5030, 10, true);
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