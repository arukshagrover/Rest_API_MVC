#pragma checksum "C:\Users\Administrator\source\repos\BillAPIProject\BillAPIProject\Views\Table1\ReturnData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b608da2d1216c8b8cdb43b800490f9972d6cfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table1_ReturnData), @"mvc.1.0.view", @"/Views/Table1/ReturnData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Table1/ReturnData.cshtml", typeof(AspNetCore.Views_Table1_ReturnData))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b608da2d1216c8b8cdb43b800490f9972d6cfb", @"/Views/Table1/ReturnData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8b05dfab381d84e9f68f84e61ba18bd61f0ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Table1_ReturnData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Result1>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 733, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script><script>
    $(document).ready(function () {
        //Call EmpDetails jsonResult Method this two
        $.getJSON(""ReturnData"", function (json) {
            var tr;
            console.log(json.length);
            for (var i = 0; i < json.length; i++) {
                tr = $('<tr/>');
                tr.append(""<td>"" + json[i].CustName + ""</td>"");
                tr.append(""<td>"" + json[i].SubsName + ""</td>"");
                tr.append(""<td>"" + json[i].UnitP + ""</td>"");
                tr.append(""<td>"" + json[i].ct + ""</td>"");
                $('table').append(tr);
            }
})

        
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Result1> Html { get; private set; }
    }
}
#pragma warning restore 1591