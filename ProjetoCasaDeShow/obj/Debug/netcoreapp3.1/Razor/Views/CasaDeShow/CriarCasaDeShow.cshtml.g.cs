#pragma checksum "C:\Users\rodri\Downloads\ProjetoCasaDeShow\Views\CasaDeShow\CriarCasaDeShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "908fe26c9f738161f7ffb7ef90c669fa88110163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CasaDeShow_CriarCasaDeShow), @"mvc.1.0.view", @"/Views/CasaDeShow/CriarCasaDeShow.cshtml")]
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
#line 1 "C:\Users\rodri\Downloads\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rodri\Downloads\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"908fe26c9f738161f7ffb7ef90c669fa88110163", @"/Views/CasaDeShow/CriarCasaDeShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28ad49606f57075bb711b0c0355f03ceb2197dda", @"/Views/_ViewImports.cshtml")]
    public class Views_CasaDeShow_CriarCasaDeShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3>Criar Casa</h3>

<div class=""panel panel-default"">
    <div>
        <div>
            <div class=""form-group"">
                <label class=""control-lavel"">Nome<input type=""text"" class=""form-control"" id=""nomeCasa"" placeHolder=""Villa Country""></label>
                <label class=""control-lavel"">Endereço<input type=""text"" class=""form-control"" id=""precoEvento"" placeHolder=""Av. Francisco Matarazzo, 774 - Água Branca, São Paulo - SP""></label>
                <label class=""control-lavel"">Capacidade<input type=""number"" class=""form-control"" id=""capacidadeCasa"" placeHolder=""800""></label>
            </div>
            <div class=""form-group"">
                <button type=""submit"" class=""btn btn-success"">
                    Criar
                </button>
            </div>
        </div>
    </div>
    
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
