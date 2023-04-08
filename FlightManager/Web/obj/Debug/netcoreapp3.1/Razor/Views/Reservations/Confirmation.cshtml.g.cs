#pragma checksum "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0270ad020530c73afe6d99da0d1fe67aad260534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Confirmation), @"mvc.1.0.view", @"/Views/Reservations/Confirmation.cshtml")]
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
#line 1 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0270ad020530c73afe6d99da0d1fe67aad260534", @"/Views/Reservations/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservations_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Reservations.ConfirmationViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 style=\"text-align:center\">Your reservation</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr style=\"height:50px\"></tr>\n        <tr>\n            <th colspan=\"7\" style=\"text-align:center; border-top:none; border-bottom:solid\">\n                Flight ");
#nullable restore
#line 16 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
                  Write(Model.FlightSource);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -> ");
#nullable restore
#line 16 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
                                         Write(Model.FlightDestination);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
                                                                   Write(Model.DepartureTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>
                Първо име
            </th>
            <th>
                Презиме
            </th>
            <th>
                Фамилия
            </th>
            <th>
                Националност
            </th>
            <th>
                Телефонен номер
            </th>
            <th>
                ЕГН
            </th>
            <th>
                Вид на билета
            </th>
        </tr>
");
#nullable restore
#line 44 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
         foreach (var item in Model.Passangers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 48 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 51 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
               Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 54 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 57 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 60 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 63 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
               Write(Html.DisplayFor(modelItem => item.UCN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 66 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
               Write(Html.DisplayFor(modelItem => item.TicketType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 69 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Confirmation.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Reservations.ConfirmationViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
