#pragma checksum "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "086175a34cb40a604edc7bf31b617fbb35fca356"
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
#line 1 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\_ViewImports.cshtml"
using Bitsion_Ficticia_S.A;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\_ViewImports.cshtml"
using Bitsion_Ficticia_S.A.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
using Bitsion_Ficticia_S.A.Models.Cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
using Bitsion_Ficticia_S.A.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"086175a34cb40a604edc7bf31b617fbb35fca356", @"/Views/Cliente/ListadoClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd0a9de60788bb02865db5658e8f41652452a31", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_ListadoClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DTOModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
  
    ViewData["Title"] = "Gestión Clientes";
    ViewData["Objeto"] = "cliente";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/v/dt/dt-1.12.1/datatables.min.css\" />\r\n\r\n<div class=\"col-9 mt-3\">\r\n    <h2 class=\"text-red-2\"\r\n        title=\"Título general de la página\">\r\n        ");
#nullable restore
#line 16 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
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
#line 33 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
     if (Model.ListadoClientes != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
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
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 50 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
                     foreach (ClienteModel cliente in Model.ListadoClientes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Dni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
                                           Write(cliente.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
                           Write(cliente.Genero.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td style=\"width:25%;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1996, "\"", 2052, 2);
            WriteAttributeValue("", 2003, "/Cliente/AltaCliente?idCliente=", 2003, 31, true);
#nullable restore
#line 59 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
WriteAttributeValue("", 2034, cliente.IdCliente, 2034, 18, false);

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
            BeginWriteAttribute("href", " href=\"", 2334, "\"", 2394, 2);
            WriteAttributeValue("", 2341, "/Cliente/ConsultaCliente?idCliente=", 2341, 35, true);
#nullable restore
#line 64 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
WriteAttributeValue("", 2376, cliente.IdCliente, 2376, 18, false);

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
            BeginWriteAttribute("href", " href=\"", 2682, "\"", 2746, 2);
            WriteAttributeValue("", 2689, "/Cliente/DeshabilitarCliente?idCliente=", 2689, 39, true);
#nullable restore
#line 69 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
WriteAttributeValue("", 2728, cliente.IdCliente, 2728, 18, false);

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
#line 76 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
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
                    </tr>
                </tfoot>
            </table>
");
#nullable restore
#line 87 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
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
#line 105 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\German\Documents\GitHub\Bitsion-Ficticia-S.A\Views\Cliente\ListadoClientes.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<script type=\"text/javascript\" src=\"https://cdn.datatables.net/v/dt/dt-1.12.1/datatables.min.js\"></script>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#tabla\').DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DTOModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
