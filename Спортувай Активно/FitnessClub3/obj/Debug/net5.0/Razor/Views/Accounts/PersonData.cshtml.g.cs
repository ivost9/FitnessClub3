#pragma checksum "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea220fc0e6b45a1ab4d32713445f4db9fe18765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_PersonData), @"mvc.1.0.view", @"/Views/Accounts/PersonData.cshtml")]
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
#line 1 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\_ViewImports.cshtml"
using FitnessClub3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\_ViewImports.cshtml"
using FitnessClub3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea220fc0e6b45a1ab4d32713445f4db9fe18765", @"/Views/Accounts/PersonData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e9d24e4461aaca24ebe9696dc3a91848257f69", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_PersonData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FitnessClub3.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
  
    ViewData["Title"] = "Лична информация";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Лична информация</h1>\r\n\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row table table-hover table-secondary\">\r\n        <dt class=\"col-sm-2\">\r\n            Имейл\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Потребителско име\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Телефонен номер\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\ivost\OneDrive\Desktop\Papka\Проект\Уеб приложение\Спортувай Активно\FitnessClub3\Views\Accounts\PersonData.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitnessClub3.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
