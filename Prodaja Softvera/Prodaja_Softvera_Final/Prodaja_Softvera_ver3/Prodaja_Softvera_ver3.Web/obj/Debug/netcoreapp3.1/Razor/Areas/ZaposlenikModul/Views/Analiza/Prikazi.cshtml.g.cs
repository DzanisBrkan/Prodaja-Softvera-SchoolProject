#pragma checksum "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774cf09e33ded7c476d13eb96241292712d98bbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ZaposlenikModul_Views_Analiza_Prikazi), @"mvc.1.0.view", @"/Areas/ZaposlenikModul/Views/Analiza/Prikazi.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\_ViewImports.cshtml"
using Prodaja_Softvera_ver3.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
using Prodaja_Softvera_ver3.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774cf09e33ded7c476d13eb96241292712d98bbc", @"/Areas/ZaposlenikModul/Views/Analiza/Prikazi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c795925c50bfc8786bf60c15a71244b13b1c48", @"/Areas/ZaposlenikModul/Views/_ViewImports.cshtml")]
    public class Areas_ZaposlenikModul_Views_Analiza_Prikazi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnalizaPrikaziVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Obrisi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Analiza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UrediForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dodaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
  
    ViewData["Title"] = "Prikazi";
    var porukaSuccess = (string)TempData["porukaSuccess"];
    var porukaWarning = (string)TempData["porukaWarning"];
    var porukaError = (string)TempData["porukaError"];
    Layout = "~/Areas/ZaposlenikModul/Views/Shared/_Layout.cshtml";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .pdf {\r\n        margin-left: 80%;\r\n    }\r\n</style>\r\n\r\n\r\n<div class=\"content-wrapper p-4\">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
     if (porukaError != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\" id=\"porukaBox\">\r\n            ");
#nullable restore
#line 25 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
       Write(porukaError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
     if (porukaWarning != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\" id=\"porukaBox\">\r\n            ");
#nullable restore
#line 32 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
       Write(porukaWarning);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
     if (porukaSuccess != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\" id=\"porukaBox\">\r\n            ");
#nullable restore
#line 39 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
       Write(porukaSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <p class=""h1""> Prikaz analiza: </p>

    <table class=""table table-dark"">
        <thead class=""thead-light"">
            <tr>
                <th>Naziv</th>
                <th>Datum analize</th>
                <th>Klijent</th>
                <th>Zaposlenik</th>
                <th>Softver</th>
                <th>Akcija</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 57 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
             foreach (AnalizaPrikaziViewModel x in Model.podaciZaHtmlTabelu)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                   Write(x.Datum_analize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 63 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                         if (x.Klijent == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label> Nema zapisa</label>\r\n");
#nullable restore
#line 66 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 69 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                              Write(x.Klijent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 70 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 73 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                         if (x.Zaposlenik == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Nema zapisa</label>\r\n");
#nullable restore
#line 76 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 79 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                              Write(x.Zaposlenik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 80 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 84 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                         if (x.Softver == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Nema zapisa</label>\r\n");
#nullable restore
#line 87 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 90 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                              Write(x.Softver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 91 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774cf09e33ded7c476d13eb96241292712d98bbc15971", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                                                                          WriteLiteral(x.AnalizaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774cf09e33ded7c476d13eb96241292712d98bbc18594", async() => {
                WriteLiteral("<i class=\"fa fa-pen\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
                                                                             WriteLiteral(x.AnalizaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 99 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774cf09e33ded7c476d13eb96241292712d98bbc21597", async() => {
                WriteLiteral("Dodaj analizu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div class=\"pdf\">\r\n");
#nullable restore
#line 106 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
          Html.BeginForm("ConvertToPDF", "Analiza", FormMethod.Get);
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n");
            WriteLiteral("                    <button type=\"submit\" value=\"Create Document\" class=\"btn btn-outline-info btn-lg\">Export u PDF</button>\r\n                </div>\r\n");
#nullable restore
#line 112 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Analiza\Prikazi.cshtml"
            }
            Html.EndForm();
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnalizaPrikaziVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
