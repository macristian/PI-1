#pragma checksum "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182aa00d1d3194b9b149797ba06f254bd9e8a5b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Editar), @"mvc.1.0.view", @"/Views/Contato/Editar.cshtml")]
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
#line 1 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\_ViewImports.cshtml"
using Scisense;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\_ViewImports.cshtml"
using Scisense.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182aa00d1d3194b9b149797ba06f254bd9e8a5b9", @"/Views/Contato/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e223a1d3ddb8bf5551c372967df0f24321bd213c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contato>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
  

    ViewData["Title"] = "Inbox";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Caixa de Entrada</h1>\n</div>\n\n<div class=\"container\">\n    <div class=\"row d-flex justify-content-center\">\n");
#nullable restore
#line 14 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
         foreach (Contato cont in Model)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card mb-3 mr-3"" style=""width: 20rem;"">
                <img src=""https://scisense.000webhostapp.com/img/closed.jpg"" class=""card-img-top"" alt=""Inbox"">
                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 20 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
                                      Write(cont.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\n                    <p>");
#nullable restore
#line 21 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
                  Write(cont.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>");
#nullable restore
#line 22 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
                  Write(cont.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
                              Write(cont.ContactNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text\">");
#nullable restore
#line 23 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
                                    Write(cont.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 771, "\"", 805, 2);
            WriteAttributeValue("", 778, "/Contato/Editar?Id=", 778, 19, true);
#nullable restore
#line 24 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
WriteAttributeValue("", 797, cont.Id, 797, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Abrir</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 879, "\"", 914, 2);
            WriteAttributeValue("", 886, "/Contato/Excluir?Id=", 886, 20, true);
#nullable restore
#line 25 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"
WriteAttributeValue("", 906, cont.Id, 906, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Excluir</a>\n                </div>\n            </div>\n");
#nullable restore
#line 28 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Editar.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
