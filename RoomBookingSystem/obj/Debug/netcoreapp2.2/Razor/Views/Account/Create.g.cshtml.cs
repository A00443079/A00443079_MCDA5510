#pragma checksum "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05feca7f77e36c5f8a4c1c437b103fa7d04f9c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Create), @"mvc.1.0.view", @"/Views/Account/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Create.cshtml", typeof(AspNetCore.Views_Account_Create))]
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
#line 1 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\_ViewImports.cshtml"
using RoomBookingSystem;

#line default
#line hidden
#line 2 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\_ViewImports.cshtml"
using RoomBookingSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05feca7f77e36c5f8a4c1c437b103fa7d04f9c8d", @"/Views/Account/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2915c59b3ab6057101748240a15c61913abea5ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(20, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05feca7f77e36c5f8a4c1c437b103fa7d04f9c8d3947", async() => {
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
            BeginContext(68, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
 using (Html.BeginForm("Create", "Account", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(138, 857, true);
            WriteLiteral(@"    <div class=""container-fluid px-1 px-md-5 px-lg-1 px-xl-5 py-5 mx-auto"">
        <div class=""card card0 border-0"">
            <div class=""row d-flex"">
                <div class=""col-lg-6"">
                    <div class=""card2 card border-0 px-4 py-5"">
                        <div class=""row mb-4 px-3"">
                            <h6 class=""mb-0 mr-4 mt-2"">Personal Details</h6>
                        </div>
                        <div class=""row px-3 mb-4"">
                            <div class=""line""></div>
                            <div class=""line""></div>
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">First Name</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(996, 125, false);
#line 23 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.FirstName, new { id = "txtFirstName", @class = "mb-4", placeholder = "First Name", maxlength = "20" }));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1152, 113, false);
#line 24 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.FirstName, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 271, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">Last Name</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(1537, 122, false);
#line 30 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.LastName, new { id = "txtLastName", @class = "mb-4", placeholder = "Last Name", maxlength = "20" }));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1690, 112, false);
#line 31 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.LastName, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 82, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row px-3\">\r\n");
            EndContext();
            BeginContext(1938, 57, true);
            WriteLiteral("                            <h6>Gender</h6><br /><br />\r\n");
            EndContext();
            BeginContext(2037, 35, true);
            WriteLiteral("                            <label>");
            EndContext();
            BeginContext(2073, 124, false);
#line 37 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                              Write(Html.RadioButtonFor(m => m.Gender, "Male", new { style = "width:20px;height:20px;margin-left:20px;vertical-align:middle;" }));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 68, true);
            WriteLiteral("&nbsp;<span>Male</span></label>\r\n                            <label>");
            EndContext();
            BeginContext(2266, 126, false);
#line 38 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                              Write(Html.RadioButtonFor(m => m.Gender, "Female", new { style = "width:20px;height:20px;margin-left:20px;vertical-align:middle;" }));

#line default
#line hidden
            EndContext();
            BeginContext(2392, 51, true);
            WriteLiteral(" &nbsp;Female</label>\r\n                            ");
            EndContext();
            BeginContext(2444, 110, false);
#line 39 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Gender, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(2554, 270, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">Username</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(2825, 121, false);
#line 45 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.Username, new { id = "txtUsername", @class = "mb-4", placeholder = "Username", maxlength = "20" }));

#line default
#line hidden
            EndContext();
            BeginContext(2946, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2977, 112, false);
#line 46 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Username, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 270, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">Password</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(3360, 122, false);
#line 52 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { id = "txtPassword", @class = "mb-4", placeholder = "Password", maxlength = "20" }));

#line default
#line hidden
            EndContext();
            BeginContext(3482, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3513, 112, false);
#line 53 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Password, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(3625, 267, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">Email</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(3893, 112, false);
#line 59 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { id = "txtEmail", @class = "mb-4", placeholder = "Email", maxlength = "50" }));

#line default
#line hidden
            EndContext();
            BeginContext(4005, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4036, 109, false);
#line 60 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Email, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(4145, 799, true);
            WriteLiteral(@"
                        </div>

                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""card2 card border-0 px-4 py-5"">
                        <div class=""row mb-4 px-3"">
                            <h6 class=""mb-0 mr-4 mt-2"">Contact / Address Details</h6>
                        </div>
                        <div class=""row px-3 mb-4"">
                            <div class=""line""></div>
                            <div class=""line""></div>
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">Mobile Number</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(4945, 128, false);
#line 78 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.MobileNumber, new { id = "txtMobile", @class = "mb-4", placeholder = "Mobile Number", maxlength = "10" }));

#line default
#line hidden
            EndContext();
            BeginContext(5073, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5104, 116, false);
#line 79 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.MobileNumber, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(5220, 309, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">Address <small>(house no,building,area)</small></h6>
                            </label>
                            ");
            EndContext();
            BeginContext(5530, 127, false);
#line 85 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.AddressLine, new { id = "txtAddressLine", @class = "mb-4", placeholder = "Address", maxlength = "100" }));

#line default
#line hidden
            EndContext();
            BeginContext(5657, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5688, 115, false);
#line 86 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.AddressLine, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(5803, 266, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">City</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(6070, 80, false);
#line 92 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.City, Model.States, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6150, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6181, 106, false);
#line 93 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.City, "", new { style = "color:red;margin-top:0px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(6287, 295, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3"" style=""margin-top:20px;"">
                            <label class=""mb-1"">
                                <h6 class=""mb-0 text-sm"">Pin Code</h6>
                            </label>
                            ");
            EndContext();
            BeginContext(6583, 119, false);
#line 99 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.PinCode, new { id = "txtPassword", @class = "mb-4", placeholder = "Pin Code", maxlength = "6" }));

#line default
#line hidden
            EndContext();
            BeginContext(6702, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6733, 111, false);
#line 100 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.PinCode, "", new { style = "color:red;margin-top:-20px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(6844, 239, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row px-3\">\r\n                            <label class=\"mb-1\">\r\n                                <h6 class=\"mb-0 text-sm\">State</h6>\r\n                            </label>\r\n");
            EndContext();
            BeginContext(7233, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(7262, 86, false);
#line 107 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.Country, Model.Countries, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(7348, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(7379, 109, false);
#line 108 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Country, "", new { style = "color:red;margin-top:0px;margin-bottom:20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(7488, 1038, true);
            WriteLiteral(@"
                        </div>
                        <div class=""row mb-3 px-3 text-right"">
                            <button type=""submit"" class=""btn btn-blue text-center"" style=""margin-top:25px;"">Register</button>
                            <button type=""button"" class=""btn btn-blue text-center"" style=""margin-top:25px;margin-left:10px"" onclick=""CancelRegister()"">Cancel</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""bg-blue py-4"">
                <div class=""row px-3"">
                    <small class=""ml-4 ml-sm-5 mb-2"">Copyright &copy; 2021. All rights reserved.</small>
                    <div class=""social-contact ml-4 ml-sm-auto""> <span class=""fa fa-facebook mr-4 text-sm""></span> <span class=""fa fa-google-plus mr-4 text-sm""></span> <span class=""fa fa-linkedin mr-4 text-sm""></span> <span class=""fa fa-twitter mr-4 mr-sm-5 text-sm""></span> </div>
                </div>
            </div>
        </div>");
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 125 "F:\Sachin_Work\Akhil\RoomBookingSystem\RoomBookingSystem\Views\Account\Create.cshtml"
}

#line default
#line hidden
            BeginContext(8529, 107, true);
            WriteLiteral("\r\n<script>\r\n    function CancelRegister() {\r\n        document.location = \"/Account/Login\"\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
