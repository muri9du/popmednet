﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.HealthCare.ESPQueryBuilder.Views.ESPQueryBuilder.Terms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    using Lpp.Dns.HealthCare.Controllers;
    using Lpp.Dns.HealthCare.ESPQueryBuilder;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Models;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ESPQueryBuilder/Terms/EthnicitySelector.cshtml")]
    public partial class EthnicitySelector : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.ESPQueryBuilder.Models.ESPQueryBuilderModel>
    {
        public EthnicitySelector()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\ESPQueryBuilder\Terms\EthnicitySelector.cshtml"
  
    var id = Html.UniqueId();
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"RaceSelectorTerm Term panel panel-default\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" name=\"TermName\"");

WriteLiteral(" value=\"EthnicitySelector\"");

WriteLiteral(" hidden=\"hidden\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(" />\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui-button-remove\"");

WriteLiteral("></div>\r\n        Race-Ethnicity\r\n    </div>\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\"", 403), Tuple.Create("\"", 450)
            
            #line 12 "..\..\Views\ESPQueryBuilder\Terms\EthnicitySelector.cshtml"
, Tuple.Create(Tuple.Create("", 408), Tuple.Create<System.Object, System.Int32>(string.Format("binding-container{0}", id)
            
            #line default
            #line hidden
, 408), false)
);

WriteLiteral(" class=\" panel-body EthnicitySelector\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-striped\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th");

WriteLiteral(" style=\"width:20px;\"");

WriteLiteral("></th>\r\n                    <th>Race-Ethnicity</th>\r\n                </tr>\r\n     " +
"       </thead>\r\n            <tbody");

WriteLiteral(" data-bind=\"foreach: Ethnicities\"");

WriteLiteral(">\r\n                <tr>\r\n                    <td><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"value:StratificationCategoryId, checked: $root.SelectedEthnicity\"");

WriteLiteral(" /></td>\r\n                    <td");

WriteLiteral(" data-bind=\"text:CategoryText\"");

WriteLiteral("></td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n        <i" +
"nput");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Ethnicity\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1099), Tuple.Create("\"", 1138)
            
            #line 27 "..\..\Views\ESPQueryBuilder\Terms\EthnicitySelector.cshtml"
, Tuple.Create(Tuple.Create("", 1104), Tuple.Create<System.Object, System.Int32>(string.Format("Ethnicity{0}", id)
            
            #line default
            #line hidden
, 1104), false)
);

WriteLiteral(" data-bind=\"value: SelectedEthnicity\"");

WriteLiteral(" />\r\n    </div>\r\n    <script>\r\n        $(function () {\r\n            ko.applyBindi" +
"ngs({\r\n                Ethnicities : ");

            
            #line 32 "..\..\Views\ESPQueryBuilder\Terms\EthnicitySelector.cshtml"
                         Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.EthnicitySelections)));

            
            #line default
            #line hidden
WriteLiteral(",\r\n                SelectedEthnicity: ko.observableArray((\'");

            
            #line 33 "..\..\Views\ESPQueryBuilder\Terms\EthnicitySelector.cshtml"
                                                   Write(Model.Ethnicity);

            
            #line default
            #line hidden
WriteLiteral("\' || \'\').split(\',\'))\r\n            }, $(\'#");

            
            #line 34 "..\..\Views\ESPQueryBuilder\Terms\EthnicitySelector.cshtml"
              Write(string.Format("binding-container{0}", id));

            
            #line default
            #line hidden
WriteLiteral("\')[0]);\r\n        });\r\n</script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591