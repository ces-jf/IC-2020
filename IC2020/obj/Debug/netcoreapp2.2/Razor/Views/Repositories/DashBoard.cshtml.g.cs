#pragma checksum "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089412eb20dc02f780b04c5468070c7e2b51cb8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repositories_DashBoard), @"mvc.1.0.view", @"/Views/Repositories/DashBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Repositories/DashBoard.cshtml", typeof(AspNetCore.Views_Repositories_DashBoard))]
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
#line 1 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\_ViewImports.cshtml"
using IC2020;

#line default
#line hidden
#line 1 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
using IC2020.Models;

#line default
#line hidden
#line 7 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089412eb20dc02f780b04c5468070c7e2b51cb8a", @"/Views/Repositories/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0cdb9692461173cc7dbac5cbca5fe6befa101e", @"/Views/_ViewImports.cshtml")]
    public class Views_Repositories_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObjStructure>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables-responsive/css/responsive.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/chart/Chart.PieceLabel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
  
    ViewBag.Title = "DashBoard";

#line default
#line hidden
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(114, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "089412eb20dc02f780b04c5468070c7e2b51cb8a5596", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(205, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "089412eb20dc02f780b04c5468070c7e2b51cb8a6849", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(301, 9, true);
            WriteLiteral("\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 310, "\"", 358, 1);
#line 11 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
WriteAttributeValue("", 316, Url.Content("~/Scripts/jquery-1.10.2.js"), 316, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(359, 42, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 401, "\"", 459, 1);
#line 12 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
WriteAttributeValue("", 407, Url.Content("~/Scripts/jquery.unobtrusive-ajax.js"), 407, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 37, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n");
            EndContext();
            BeginContext(497, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089412eb20dc02f780b04c5468070c7e2b51cb8a9070", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(571, 493, true);
            WriteLiteral(@"


<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""info-box bg-danger"">
                    <span class=""info-box-icon""><i class=""far fa-flag""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">USUÁRIO/REPOSITÓRIO</span>
                        <span class=""info-box-text"" id=""nameRepo"">
                            ");
            EndContext();
            BeginContext(1065, 20, false);
#line 27 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                       Write(Model.repo.full_name);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 1003, true);
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">

                <div class=""card card-danger card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""far fa-chart-bar""></i>
                            DESENVOLVEDORES DE CADA VERSÃO
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table id=""example1"" class=""table table-hover"" height=""100"">
");
            EndContext();
#line 52 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                 if (Model.item.Count() == 0)
                                {

#line default
#line hidden
            BeginContext(2186, 177, true);
            WriteLiteral("                                    <tr>\r\n                                        <td colspan=\"10\">Não foram encontrados dados.</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2473, 454, true);
            WriteLiteral(@"                                    <thead>
                                        <tr style=""background-color:#DE022A; color:white"">
                                            <th scope=""col"">Desenvolvedor</th>
                                            <th scope=""col"">Versão</th>
                                            <th scope=""col"">Data</th>
                                        </tr>
                                    </thead>
");
            EndContext();
#line 68 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"



                                    foreach (var item in Model.item)
                                    {

#line default
#line hidden
            BeginContext(3042, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(3137, 17, false);
#line 74 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                           Write(item.author.login);

#line default
#line hidden
            EndContext();
            BeginContext(3154, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3210, 13, false);
#line 75 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                           Write(item.tag_name);

#line default
#line hidden
            EndContext();
            BeginContext(3223, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3279, 17, false);
#line 76 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                           Write(item.published_at);

#line default
#line hidden
            EndContext();
            BeginContext(3296, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 78 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(3424, 3525, true);
            WriteLiteral(@"                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""card card-danger card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""far fa-chart-bar""></i>
                            TOTAL DE COMMITS DE CADA VERSÃO
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""wrapper"">
                            <canvas id=""totalChart"" height=""303""></canvas>
                            <script>
             ");
            WriteLiteral(@"                   var ctx = document.getElementById(""totalChart"");
                                var chart = new Chart(ctx, {
                                    type: 'pie',
                                    data: {
                                        datasets: [{ backgroundColor: ['rgb(255, 99, 132)', 'rgb(255, 199, 132)', 'rgb(55, 99, 132)', 'rgba(0, 255, 0, 0.3)', ""#8e5ea2""], data: [72, 2, 2, 3, 1] }], labels: [""v14.12.0"", ""v14.11.0"", ""v14.10.1"", ""v12.18.4"", ""v10.22.1"",]
                                    },
                                    options: {
                                        responsive: true,
                                        title: {
                                            display: true,
                                            responsive: true
                                        },
                                        pieceLabel: {
                                            render: 'value',
                                            positi");
            WriteLiteral(@"on: 'outside',
                                            segment: true,
                                            fontSize: 14,
                                            fontStyle: 'bold',
                                            fontColor: '#000',
                                        }
                                    }
                                });
                            </script>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card card-danger card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""far fa-chart-bar""></i>
                            DATA x VERSÃO
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-c");
            WriteLiteral(@"ard-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""wrapper"">
                            <canvas id=""mixed-chart"" width=""800"" height=""400""></canvas>

                            <script>
                                  var events = ");
            EndContext();
            BeginContext(6950, 49, false);
#line 152 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                          Write(Html.Raw(JsonConvert.SerializeObject(Model.item)));

#line default
#line hidden
            EndContext();
            BeginContext(6999, 3321, true);
            WriteLiteral(@"
                                     console.log(events)
                                const tag = events.map(x => x.tag_name)
                                const datetag = events.map(x => x.published_at)
                                var y = tag.map(s => parseFloat(s.slice(1)));
                                                                    new Chart(document.getElementById(""mixed-chart""), {
                                        type: 'line',
                                        data: {
                                            labels: datetag,
                                            datasets: [{
                                                data: y,
                                                label: ""Versão"",
                                                borderColor: ""#8e5ea2"",
                                                fill: false
                                            },
                                            ]
                                 ");
            WriteLiteral(@"       },
                                        options: {
                                            responsive: true,
                                            title: {
                                                display: true,
                                                text: 'INTERVALO DE TEMPO ENTRE AS VERSÕES',
                                                responsive: true
                                            }
                                        }
                                    });
                            </script>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">

                <div class=""card card-danger card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""far fa-chart-bar""></i>
                            INFORMAÇÕES DO REPOS");
            WriteLiteral(@"ITÓRIO
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table id=""example1"" class=""table table-hover"" height=""100"">

                                <thead>
                                    <tr style=""background-color:#DE022A; color:white"">
                                        <th scope=""col"">Id</th>
                                        <th scope=""col"">Nome</th>
                                        <th scope=""col"">Branch Principal</th>
                                        <th scope=""col"">Watchers/Starred</th>
                                        <th scope=""col"">Iss");
            WriteLiteral("ues Abertas</th>\r\n                                        <th scope=\"col\">Forks</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(10321, 13, false);
#line 215 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                   Write(Model.repo.id);

#line default
#line hidden
            EndContext();
            BeginContext(10334, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(10382, 20, false);
#line 216 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                   Write(Model.repo.full_name);

#line default
#line hidden
            EndContext();
            BeginContext(10402, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(10450, 25, false);
#line 217 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                   Write(Model.repo.default_branch);

#line default
#line hidden
            EndContext();
            BeginContext(10475, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(10523, 25, false);
#line 218 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                   Write(Model.repo.watchers_count);

#line default
#line hidden
            EndContext();
            BeginContext(10548, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(10596, 28, false);
#line 219 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                   Write(Model.repo.open_issues_count);

#line default
#line hidden
            EndContext();
            BeginContext(10624, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(10672, 16, false);
#line 220 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                   Write(Model.repo.forks);

#line default
#line hidden
            EndContext();
            BeginContext(10688, 230, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObjStructure> Html { get; private set; }
    }
}
#pragma warning restore 1591
