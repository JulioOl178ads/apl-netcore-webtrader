#pragma checksum "C:\Projetos\apl-netcore-webtrader\Views\Product\_FormProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "073c0ba057a2709395005f158aa5f5c85af38bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__FormProducts), @"mvc.1.0.view", @"/Views/Product/_FormProducts.cshtml")]
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
#line 1 "C:\Projetos\apl-netcore-webtrader\Views\_ViewImports.cshtml"
using WebTrader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\apl-netcore-webtrader\Views\_ViewImports.cshtml"
using WebTrader.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"073c0ba057a2709395005f158aa5f5c85af38bb7", @"/Views/Product/_FormProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f872150c7b8817059f98bd74516b672b0432d6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__FormProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""form-group"">
        <label>Marca:</label>
        <input type=""text"" name=""marca"" class=""form-control"" id=""txtMarca"" aria-describedby=""Digite a Marca de seu produto"" placeholder=""Marca"">
    </div>

    <div class=""form-group"">
        <label>Modelo:</label>
        <input type=""text"" name=""modelo"" class=""form-control"" id=""txtModelo"" aria-describedby=""Digite o Modelo de seu produto"" placeholder=""Modelo"">
    </div>

    <div class=""form-group"">
        <label>Nome:</label>
        <input type=""text"" name=""nome"" class=""form-control"" id=""txtNome"" aria-describedby=""Digite o Nome de seu produto"" placeholder=""Nome"">
    </div>

    <div class=""form-group"">
        <label>Preço de Mercado:</label>
        <input type=""text"" name=""precomercado"" class=""form-control"" id=""txtPrecoMercado"" aria-describedby=""Digite o Preco de Mercado do Produto"" placeholder=""Preco de Mercado"">
    </div>

    <div class=""form-group"">
        <label>Preço do Produto:</label>
        <input type=""te");
            WriteLiteral("xt\" name=\"precodesejado\" class=\"form-control\" id=\"txtPrecoDesejado\" aria-describedby=\"Digite o Preco desejado do Produto\" placeholder=\"Preco desejado\">\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Adicionar</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
