using Furion;
using System.Reflection;

namespace Light.Design.Pro.CSharp.Web.Entry
{
    public class SingleFilePublish : ISingleFilePublish
    {
        public Assembly[] IncludeAssemblies()
        {
            return Array.Empty<Assembly>();
        }

        public string[] IncludeAssemblyNames()
        {
            return new[]
            {
            "Light.Design.Pro.CSharp.Application",
            "Light.Design.Pro.CSharp.Core",
            "Light.Design.Pro.CSharp.EntityFramework.Core",
            "Light.Design.Pro.CSharp.Web.Core"
        };
        }
    }
}