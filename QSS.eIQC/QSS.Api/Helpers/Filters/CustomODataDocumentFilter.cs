using Microsoft.AspNet.OData;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using Microsoft.OpenApi.Models;

namespace QSS.Helpers.Filters
{
    /// <summary>
    /// CustomODataDocumentFilter: Creates a Filter to extract the OData Controllers Information
    /// </summary>
    public class CustomODataDocumentFilter //: IDocumentFilter
    {
        /// <summary>
        /// The XML Comments Document Path
        /// </summary>
        private string xmlPath;

        /// <summary>
        /// Creates an Instance of <see cref="CustomODataDocumentFilter"/>
        /// </summary>
        /// <param name="xmlCommentsFile">The Path for XMLCommentsFile </param>
        public CustomODataDocumentFilter(string xmlCommentsFile)
        {
            xmlPath = xmlCommentsFile;
        }

        ///// <summary>
        ///// Applies the Filter to the current Swagger Configuration
        ///// </summary>
        ///// <param name="swaggerDoc"></param>
        ///// <param name="context"></param>
        //public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(xmlPath);

        //    var thisAssemblyTypes = Assembly.GetExecutingAssembly().GetTypes().ToList();
        //    var odatacontrollers = thisAssemblyTypes.Where(t => t.BaseType == typeof(ODataController)).ToList();
        //    var odatamethods = new[] { "Get", "Put", "Post", "Delete" };

        //    foreach (var odataContoller in odatacontrollers)  // this the OData controllers in the API
        //    {
        //        var methods = odataContoller.GetMethods().Where(a => odatamethods.Contains(a.Name)).ToList();
        //        if (!methods.Any())
        //            continue; // next controller 

        //        foreach (var method in methods)  // this is all of the methods in controller (e.g. GET, POST, PUT, etc)
        //        {
        //            var sb = new StringBuilder();
        //            var parameterInfo = method.GetParameters();
        //            if (parameterInfo.Length > 0)
        //            {
        //                sb.Append("/" + method.Name + "(");
        //                var listParams = new List<String>();

        //                foreach (ParameterInfo pi in parameterInfo)
        //                {
        //                    listParams.Add(pi.ParameterType + " " + pi.Name);
        //                }
        //                sb.Append(String.Join(", ", listParams.ToArray()));
        //                sb.Append(")");
        //            }

        //            var path = "/" + "odata" + "/" + odataContoller.Name
        //                    .Replace("Controller", "", StringComparison.InvariantCultureIgnoreCase)
        //                    .Replace("odata", "", StringComparison.InvariantCultureIgnoreCase) + sb;
        //            var odataPathItem = new PathItem();
        //            var op = new Operation();

        //            // The odata methods will be listed under a heading called OData in the swagger doc
        //            op.Tags = new List<string> {
        //                //"OData"
        //                odataContoller.Name
        //                    .Replace("Controller", "", StringComparison.InvariantCultureIgnoreCase)
        //                    .Replace("odata", "", StringComparison.InvariantCultureIgnoreCase)
        //            };
        //            op.OperationId = "OData_" + odataContoller.Name.Replace("Controller", "");

        //            // This hard-coded for now, set it to use XML comments if you want
        //            op.Summary = "Summary about method / data";
        //            op.Description = "Description / options for the call.";

        //            op.Consumes = new List<string>();
        //            op.Produces = new List<string> { "application/atom+xml", "application/json", "text/json", "application/xml", "text/xml" };
        //            op.Deprecated = false;

        //            var response = new Response
        //            {
        //                Description = "OK",
        //                Schema = new Schema
        //                {
        //                    Type = "array",
        //                    Items = context.SchemaRegistry.GetOrRegister(method.ReturnType)
        //                }
        //            };

        //            op.Responses = new Dictionary<string, Response> { { "200", response } };

        //            var security = GetSecurityForOperation(odataContoller);
        //            if (security != null)
        //                op.Security = new List<IDictionary<string, IEnumerable<string>>> { security };

        //            odataPathItem.Get = op;

        //            try
        //            {
        //                swaggerDoc.Paths.Add(path, odataPathItem);
        //            }
        //            catch
        //            {
        //                // ignored
        //            }
        //        }
        //    }
        //}


        //public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(xmlPath);

        //    var thisAssemblyTypes = Assembly.GetExecutingAssembly().GetTypes().ToList();
        //    var odatacontrollers = thisAssemblyTypes.Where(t => t.BaseType == typeof(ODataController)).ToList();
        //    var odatamethods = new[] { "Get", "Put", "Post", "Delete" };

        //    foreach (var odataContoller in odatacontrollers)  // this the OData controllers in the API
        //    {
        //        var methods = odataContoller.GetMethods().Where(a => odatamethods.Contains(a.Name)).ToList();
        //        if (!methods.Any())
        //            continue; // next controller 

        //        foreach (var method in methods)  // this is all of the methods in controller (e.g. GET, POST, PUT, etc)
        //        {
        //            var sb = new StringBuilder();
        //            var parameterInfo = method.GetParameters();
        //            if (parameterInfo.Length > 0)
        //            {
        //                sb.Append("/" + method.Name + "(");
        //                var listParams = new List<String>();

        //                foreach (ParameterInfo pi in parameterInfo)
        //                {
        //                    listParams.Add(pi.ParameterType + " " + pi.Name);
        //                }
        //                sb.Append(String.Join(", ", listParams.ToArray()));
        //                sb.Append(")");
        //            }

        //            var path = "/" + "odata" + "/" + odataContoller.Name
        //                    .Replace("Controller", "", StringComparison.InvariantCultureIgnoreCase)
        //                    .Replace("odata", "", StringComparison.InvariantCultureIgnoreCase) + sb;
        //            var odataPathItem = new OpenApiPathItem();
        //            var op = new OpenApiOperation();

        //            // The odata methods will be listed under a heading called OData in the swagger doc
        //            //op.Tags = new List<OpenApiTag> {
        //            //    new OpenApiTag {  }
        //            //};
        //            //op.Tags = new List<string> {
        //            //    //"OData"
        //            //    odataContoller.Name
        //            //        .Replace("Controller", "", StringComparison.InvariantCultureIgnoreCase)
        //            //        .Replace("odata", "", StringComparison.InvariantCultureIgnoreCase)
        //            //};
        //            op.OperationId = "OData_" + odataContoller.Name.Replace("Controller", "");

        //            // This hard-coded for now, set it to use XML comments if you want
        //            op.Summary = "Summary about method / data";
        //            op.Description = "Description / options for the call.";
        //            //op.Consumes = new List<string>();
        //            //op.Produces = new List<string> { "application/atom+xml", "application/json", "text/json", "application/xml", "text/xml" };
        //            op.Deprecated = false;

        //            var response = new Response
        //            {
        //                Description = "OK",
        //                Schema = new Schema
        //                {
        //                    Type = "array",
        //                    Items = context.SchemaRegistry.GetOrRegister(method.ReturnType)
        //                }
        //            };

        //            op.Responses = new Dictionary<string, Response> { { "200", response } };

        //            var security = GetSecurityForOperation(odataContoller);
        //            if (security != null)
        //                op.Security = new List<IDictionary<string, IEnumerable<string>>> { security };

        //            odataPathItem.Get = op;

        //            try
        //            {
        //                swaggerDoc.Paths.Add(path, odataPathItem);
        //            }
        //            catch
        //            {
        //                // ignored
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// The Document Filter <see cref="Dictionary{TKey, TValue}"/>
        /// </summary>
        /// <param name="odataContoller">The Controller</param>
        /// <returns><see cref="Dictionary{TKey, TValue}"/></returns>
        private Dictionary<string, IEnumerable<string>> GetSecurityForOperation(MemberInfo odataContoller)
        {
            Dictionary<string, IEnumerable<string>> securityEntries = null;
            if (odataContoller.GetCustomAttribute(typeof(Microsoft.AspNetCore.Authorization.AuthorizeAttribute)) != null)
            {
                securityEntries = new Dictionary<string, IEnumerable<string>> { { "oauth2", new[] { "actioncenter" } } };
            }
            return securityEntries;
        }
    }
}
