#pragma checksum "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0da96b544e0c6b7e70639f59aa1fbb5cb8e842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_ListadoClientes), @"mvc.1.0.view", @"/Views/Cliente/ListadoClientes.cshtml")]
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
#line 1 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\_ViewImports.cshtml"
using BitsionFicticiaSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\_ViewImports.cshtml"
using BitsionFicticiaSA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
using BitsionFicticiaSA.Models.Cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
using BitsionFicticiaSA.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0da96b544e0c6b7e70639f59aa1fbb5cb8e842", @"/Views/Cliente/ListadoClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0deba6018c0fb6c588bfb94ca68d7d4b19f2c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cliente_ListadoClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DTOModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
  
    ViewData["Title"] = "Gestión Clientes";
    ViewData["Objeto"] = "cliente";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/v/dt/dt-1.12.1/datatables.min.css\" />\r\n\r\n<div class=\"col-9 mt-3\">\r\n    <h2 class=\"text-red-2\"\r\n        title=\"Título general de la página\">\r\n        ");
#nullable restore
#line 16 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h2>
</div>
<div class=""col-12 border-top-red-3 p-3"">
    <div class=""row"">
        <div class=""col-2"">
            <a href=""/Cliente/AltaCliente""
               value=""registrar"" title=""Botón de crear de un nuevo cliente""
               class=""btn btn-success redondeado text-white""
               style=""width: max-content;"">
                Añadir nuevo Cliente
            </a>
        </div>
    </div>

    <br />
    <br />
");
#nullable restore
#line 33 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
     if (Model.ListadoClientes != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
         if (Model.ListadoClientes.Count() >= 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table id=""tabla""
                   class=""table table-striped table-bordered""
                   style=""width:100%""
                   title=""Listado de todos los clientes"">
                <thead>
                    <tr>
                        <th>DNI</th>
                        <th>Nombre y Apellido</th>
                        <th>Edad</th>
                        <th>Genero</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 51 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
                     foreach (ClienteModel cliente in Model.ListadoClientes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Dni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
                                           Write(cliente.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Genero.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td style=\"width:25%;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2033, "\"", 2089, 2);
            WriteAttributeValue("", 2040, "/Cliente/AltaCliente?idCliente=", 2040, 31, true);
#nullable restore
#line 60 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
WriteAttributeValue("", 2071, cliente.IdCliente, 2071, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""btn btn-warning text-white btn-gral""
                                   title=""Botón de editar los datos del cliente"">
                                    Editar
                                </a>
                                <a");
            BeginWriteAttribute("href", " href=\"", 2371, "\"", 2431, 2);
            WriteAttributeValue("", 2378, "/Cliente/ConsultaCliente?idCliente=", 2378, 35, true);
#nullable restore
#line 65 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
WriteAttributeValue("", 2413, cliente.IdCliente, 2413, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""btn btn-primary text-white btn-gral""
                                   title=""Botón de consultar los datos del cliente"">
                                    Consultar
                                </a>
                                <a");
            BeginWriteAttribute("href", " href=\"", 2719, "\"", 2783, 2);
            WriteAttributeValue("", 2726, "/Cliente/DeshabilitarCliente?idCliente=", 2726, 39, true);
#nullable restore
#line 70 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
WriteAttributeValue("", 2765, cliente.IdCliente, 2765, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""btn btn-danger text-white btn-gral""
                                   title=""Botón de eliminar todos los datos y registros del cliente"">
                                    Eliminar
                                </a>
                            </td>
                        </tr>
");
#nullable restore
#line 77 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <th>DNI</th>
                        <th>Nombre y Apellido</th>
                        <th>Edad</th>
                        <th>Genero</th>
                                                <th>Acciones</th>

                    </tr>
                </tfoot>
            </table>
");
#nullable restore
#line 90 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table id=""tabla""
                   class=""table table-striped table-bordered""
                   style=""width:100%""
                   title=""Listado de todos los clientes"">
                <thead>
                    <tr>
                        <th>DNI</th>
                        <th>Nombre y Apellido</th>
                        <th>Edad</th>
                        <th>Genero</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
");
#nullable restore
#line 108 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\German\Documents\GitHub\BitsionFicticiaSA\Views\Cliente\ListadoClientes.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<script>\r\n$(document).ready( function () {\r\n    $(\'#tabla\').DataTable();\r\n} );\r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DTOModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
