#pragma checksum "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed13928a242d386f3b4a363bf4a7514ecad7914f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Details), @"mvc.1.0.view", @"/Views/Reservations/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed13928a242d386f3b4a363bf4a7514ecad7914f", @"/Views/Reservations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Reservations.ReservationDetailsListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Reservation details</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th colspan=\"7\" style=\"text-align:center; border-top:none;\">\n                Plane №");
#nullable restore
#line 14 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
                  Write(Model.PlaneNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
        </tr>
        <tr>
            <th colspan=""7"" style=""text-align:center; border-top:none;"">
                Passangers:
            </th>
        </tr>
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
        
    </thead>
    <tbody>
");
#nullable restore
#line 49 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
 foreach (var item in Model.Items) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 52 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 58 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 67 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.UCN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 70 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.TicketType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 73 "C:\Users\User\Documents\FlightManager-master\FlightManager\Web\Views\Reservations\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Reservations.ReservationDetailsListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591