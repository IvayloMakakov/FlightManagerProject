#pragma checksum "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d692577505db6053fc6609f958a654b5880fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Email), @"mvc.1.0.view", @"/Views/Reservations/Email.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d692577505db6053fc6609f958a654b5880fc9", @"/Views/Reservations/Email.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservations_Email : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Reservations.ConfirmationViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h1 style=\"text-align:left\">Your reservation</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr style=\"height:50px\"></tr>\n        <tr>\n            <th colspan=\"7\" style=\"text-align:center; border-top:none; border-bottom:solid\">\n                Flight ");
#nullable restore
#line 11 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
                  Write(Model.FlightSource);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -> ");
#nullable restore
#line 11 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
                                         Write(Model.FlightDestination);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 11 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
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
#line 39 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
         foreach (var item in Model.Passangers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 43 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 46 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
               Write(item.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 49 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 52 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
               Write(item.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 55 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 58 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
               Write(item.UCN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 61 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
               Write(item.TicketType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 64 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Email.cshtml"
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
