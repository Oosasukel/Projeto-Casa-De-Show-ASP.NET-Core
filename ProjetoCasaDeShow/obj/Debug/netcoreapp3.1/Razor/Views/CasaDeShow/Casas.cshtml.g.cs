#pragma checksum "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d2c1d7e7b967ad769f192e1ba13015944779a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CasaDeShow_Casas), @"mvc.1.0.view", @"/Views/CasaDeShow/Casas.cshtml")]
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
#line 1 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d2c1d7e7b967ad769f192e1ba13015944779a6d", @"/Views/CasaDeShow/Casas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60dc138c28fceb087f4962b6d22b1a18fd1266b", @"/Views/_ViewImports.cshtml")]
    public class Views_CasaDeShow_Casas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Casa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
  
    var casaDeShowRepository = ViewBag.casaDeShowRepository;

    var casas = casaDeShowRepository.GetCasas();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Casas de show</h3>\r\n<div>\r\n");
#nullable restore
#line 9 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
     foreach (var casa in casas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"tabela\">\r\n            <tr>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d2c1d7e7b967ad769f192e1ba13015944779a6d4670", async() => {
#nullable restore
#line 14 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                                                            Write(casa.Nome);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 14 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                                           WriteLiteral(casa.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    Capacidade: ");
#nullable restore
#line 17 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                           Write(casa.Capacidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
               Write(casa.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 23 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                      
                        int qtdEventos = casaDeShowRepository.GetQtdEventos(casa.Id);
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                     if(qtdEventos > 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>");
#nullable restore
#line 27 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                      Write(qtdEventos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" eventos.</a>\r\n");
#nullable restore
#line 28 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                    }
                    else if(qtdEventos == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>");
#nullable restore
#line 30 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                      Write(qtdEventos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" evento.</a>\r\n");
#nullable restore
#line 31 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                    }
                    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>Sem eventos.</a>\r\n");
#nullable restore
#line 34 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 38 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casas.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
