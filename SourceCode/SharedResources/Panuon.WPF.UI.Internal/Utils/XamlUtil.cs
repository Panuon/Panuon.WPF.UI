using System.Text;
using System.Windows.Markup;
using System.Xml;

namespace Panuon.WPF.UI.Internal.Utils
{
    internal static class XamlUtil
    {
        public static T CloneXamlObject<T>(T obj)
        {
            if (obj == null)
            {
                return default;
            }
            var xamlBuilder = new StringBuilder();
            var writer = XmlWriter.Create(xamlBuilder, new XmlWriterSettings
            {
                Indent = true,
                ConformanceLevel = ConformanceLevel.Fragment,
                OmitXmlDeclaration = true,
                NamespaceHandling = NamespaceHandling.OmitDuplicates,
            });
            var mgr = new XamlDesignerSerializationManager(writer);
            mgr.XamlWriterMode = XamlWriterMode.Expression;
            XamlWriter.Save(obj, mgr);
            return (T)XamlReader.Parse(xamlBuilder.ToString());
        }

        public static string ToXaml<T>(T obj)
        {
            if (obj == null)
            {
                return default;
            }
            var xamlBuilder = new StringBuilder();
            var writer = XmlWriter.Create(xamlBuilder, new XmlWriterSettings
            {
                Indent = true,
                ConformanceLevel = ConformanceLevel.Fragment,
                OmitXmlDeclaration = true,
                NamespaceHandling = NamespaceHandling.OmitDuplicates,
            });
            var mgr = new XamlDesignerSerializationManager(writer);
            mgr.XamlWriterMode = XamlWriterMode.Expression;
            XamlWriter.Save(obj, mgr);
            return xamlBuilder.ToString();
        }

        public static T FromXaml<T>(string xaml)
        {
            return (T)XamlReader.Parse(xaml);
        }
    }
}
