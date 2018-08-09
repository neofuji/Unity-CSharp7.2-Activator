#if ENABLE_VSTU
using System.IO;
using System.Text;
using System.Xml.Linq;
using SyntaxTree.VisualStudio.Unity.Bridge;
using UnityEditor;

[InitializeOnLoad]
static class CSharp7_2Activator
{
    sealed class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }

    static CSharp7_2Activator()
    {
        ProjectFilesGenerator.ProjectFileGeneration += (name, content) =>
        {
            XNamespace ns = "http://schemas.microsoft.com/developer/msbuild/2003";

            var document = XDocument.Parse(content);

            foreach (var element in document.Root.Elements(ns + "PropertyGroup"))
            {
                foreach (var elem in element.Elements(ns + "LangVersion"))
                {
                    elem.Value = "7.2";
                }
            }

            using (var sw = new Utf8StringWriter())
            {
                document.Save(sw);
                return sw.ToString();
            }
        };
    }
}
#endif
