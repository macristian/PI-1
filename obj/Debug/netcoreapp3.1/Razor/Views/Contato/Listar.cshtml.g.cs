#pragma checksum "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be11faf31de8016a408ea594dfefb2fb72f4042b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Listar), @"mvc.1.0.view", @"/Views/Contato/Listar.cshtml")]
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
#line 2 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be11faf31de8016a408ea594dfefb2fb72f4042b", @"/Views/Contato/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e223a1d3ddb8bf5551c372967df0f24321bd213c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contato>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
  

    ViewData["Title"] = "Inbox";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Caixa de Entrada</h1>\n</div>\n\n<div class=\"container\">\n    <div class=\"row d-flex justify-content-center\">\n");
#nullable restore
#line 14 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
         foreach (Contato cont in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-3 mr-3\" style=\"width: 100rem;\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 394, "\"", 412, 1);
#nullable restore
#line 17 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
WriteAttributeValue("", 400, cont.Readed, 400, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Inbox\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 19 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
                                      Write(cont.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\n                    <p>");
#nullable restore
#line 20 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
                  Write(cont.ContactNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 590, "\"", 615, 2);
            WriteAttributeValue("", 597, "mailto:", 597, 7, true);
#nullable restore
#line 20 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
WriteAttributeValue("", 604, cont.Email, 604, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            < ");
#nullable restore
#line 21 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
                         Write(cont.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n                        </a></p>\n                    <p>");
#nullable restore
#line 23 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
                  Write(cont.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                    <p class=\"card-text\">");
#nullable restore
#line 24 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
                                    Write(cont.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 817, "\"", 851, 2);
            WriteAttributeValue("", 824, "/Contato/Editar?Id=", 824, 19, true);
#nullable restore
#line 25 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
WriteAttributeValue("", 843, cont.Id, 843, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Visualizado</a>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 923, "\"", 958, 2);
            WriteAttributeValue("", 930, "/Contato/Excluir?Id=", 930, 20, true);
#nullable restore
#line 26 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"
WriteAttributeValue("", 950, cont.Id, 950, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Excluir</a>\n                </div>\n            </div>\n");
#nullable restore
#line 29 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Contato\Listar.cshtml"

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
